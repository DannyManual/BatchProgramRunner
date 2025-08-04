using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchProgramRunner
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            InitializeDataHandling();
            prepareBatchrun();
        }

        private void InitializeDataHandling()
        {
            // try loading xml database
            try
            {

                dsBatchProgramRunner.ReadXml("dsBatchProgramRunner.xml");
                dgvAssignedParams.Columns["iDDataGridViewTextBoxColumn"].Visible = false;
                dgvBatchValues.Columns["iDDataGridViewTextBoxColumn1"].Visible = false;

            }
            catch (FileNotFoundException)
            {

            }

            // assign Change Events to save Data in time
            foreach (DataTable table in dsBatchProgramRunner.Tables)
            {
                table.RowChanged += Table_Changed;
                table.RowDeleted += Table_Changed;
                table.TableNewRow += Table_Changed;
                table.ColumnChanged += Table_Changed;
            }
        }

        private void Table_Changed(object sender, EventArgs e)
        {
            try
            {
                dsBatchProgramRunner.WriteXmlSchema("dsBatchProgramRunner.xsd");
                dsBatchProgramRunner.WriteXml("dsBatchProgramRunner.xml", XmlWriteMode.IgnoreSchema);
            }
            catch (Exception)
            {

            }
        }

        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                dtCommandTemplates.Rows.Add(new object[] { null, txtNewTempName.Text, "" });
                bsCommndTemplate.Position = bsCommndTemplate.Count - 1;
                txtNewTempName.Clear();
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Eintrag mit dem selben Namen bereits vorhanden. Bitte einen anderen wählen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveTemplate_Click(object sender, EventArgs e)
        {
            bsCommndTemplate.Remove(lstTemplates.SelectedItem);
        }

        private void btnOpenPathToEXE_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = false;
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtPathToExe.Text = openFileDialog.FileName;
            }
        }

        private void txtPathToExe_TextChanged(object sender, EventArgs e)
        {
            string path = ((TextBox)sender).Text;
            if (File.Exists(path) && Path.GetExtension(path).Equals(".exe", StringComparison.OrdinalIgnoreCase))
            {
                rdChckStatPathToExe.ForeColor = Color.Green;
            }
            else
            {
                rdChckStatPathToExe.ForeColor = Color.LightGray;
            }
        }

        private void btnSaveBatchVal_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "XML-Dateien|*.xml";
            saveFileDialog.DefaultExt = ".xml";
            saveFileDialog.Title = "Save Batch Value List to XML...";
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    dtBatchList.WriteXml(saveFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fehler beim Speichern.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadBatchVal_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "XML-Dateien|*.xml";
            openFileDialog.DefaultExt = ".xml";
            openFileDialog.Title = "Load Batch Value List from XML File...";
            openFileDialog.Multiselect = false;

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    dtBatchList.ReadXml(openFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fehler beim Speichern.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lstTemplateSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            prepareBatchrun();
        }

        private void prepareBatchrun()
        {
            string cmdStr = buildCommandString();
            dgBatchLog.Rows.Clear();
            dgBatchLog.Rows.Add(cmdStr, 0, "");
        }

        private string buildCommandString()
        {
            string commandString = "";

            try
            {
                DataRowView currentTemplate = bsSelectedTemplate.Current as DataRowView;

                string currentBatchValue = dgvBatchValues.CurrentRow.Cells["valueDataGridViewTextBoxColumn"].Value as string;
                if (currentTemplate != null)
                {
                    commandString += currentTemplate["CommandPath"];

                    foreach (DataRowView currentRow in bsSelectedAssValue.List)
                    {
                        commandString += currentRow["Param"].ToString().Replace("{batch1}", currentBatchValue);
                        commandString += currentRow["Value"].ToString().Replace("{batch1}", currentBatchValue);
                    }
                }
            } catch (Exception)
            {

            }

            return commandString;

        }

        
        private void dgvBatchValues_SelectionChanged(object sender, EventArgs e)
        {
            prepareBatchrun();
        }
    }
}
