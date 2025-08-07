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
using System.Diagnostics;

namespace BatchProgramRunner
{
    public partial class frmMain : Form
    {
        private bool batchIsRunning = false;
        private bool requestToStop = false;

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
                table.RowChanged += table_Changed;
                table.RowDeleted += table_Changed;
                table.TableNewRow += table_Changed;
                table.ColumnChanged += table_Changed;
            }
        }

        private void table_Changed(object sender, EventArgs e)
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
            updatePathCheck(sender);
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

        }

        private void dgvBatchValues_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void prepareBatchrun()
        {
            string cmdStr = buildCommandString();
            dgvBatchLog.Rows.Clear();
            dgvBatchLog.Rows.Add(cmdStr, 0, "");
        }

        private string buildCommandString()
        {
            string commandString = "";

            try
            {
                DataRowView currentTemplate = bsSelectedTemplate.Current as DataRowView;

                string currentBatchValue = dgvBatchValues.CurrentRow.Cells["dgvcBV_Value"].Value as string;
                if (currentTemplate != null)
                {
                    commandString += currentTemplate["CommandPath"];
                }
            }
            catch (Exception)
            {

            }

            return commandString;

        }

        private string buildArgsString()
        {
            string argString = "";

            try
            {
                DataRowView currentTemplate = bsSelectedTemplate.Current as DataRowView;

                string currentBatchValue = dgvBatchValues.CurrentRow.Cells["dgvcBV_Value"].Value as string;
                if (currentTemplate != null)
                {
                    foreach (DataRowView currentRow in bsSelectedAssValue.List)
                    {
                        argString += currentRow["Param"].ToString().Replace("{batch1}", currentBatchValue);
                        argString += currentRow["Value"].ToString().Replace("{batch1}", currentBatchValue);
                    }
                }
            }
            catch (Exception)
            {

            }

            return argString;

        }

        private void updatePathCheck(object sender)
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

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataRowView row in bsBatchValues)
            {
                row["Active"] = true;
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            foreach (DataRowView row in bsBatchValues)
            {
                row["Active"] = false;
            }
        }

        private void btnInvertSelect_Click(object sender, EventArgs e)
        {
            foreach (DataRowView row in bsBatchValues)
            {
                row["Active"] = !((bool)row["Active"]);
            }
        }

        private void btnFilterSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnMrkSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBatchValues.SelectedRows)
            {
                row.Cells["dgvcBV_Active"].Value = true;
            }
        }



        private void bwBatchRunner_DoWork(object sender, DoWorkEventArgs e)
        {
            BatchProcessArgs bpArgs = (BatchProcessArgs)e.Argument;

            // Befehl asynchron ausführen
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = bpArgs.cmd,
                Arguments = bpArgs.args,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process proc = Process.Start(psi))
            {
                if (proc == null)
                    throw new InvalidOperationException("Prozess konnte nicht gestartet werden.");

                string output = proc.StandardOutput.ReadToEnd();

                proc.WaitForExit();

                int exitCode = proc.ExitCode;

                // DataRow befüllen (nur im DoWork erzeugen; Einfügen später im UI-Thread!)
                BatchProcessResult bpr = new BatchProcessResult()
                {
                    buildCommandString = bpArgs.cmd + bpArgs.args,
                    exitCode = exitCode,
                    stdOut = output
                };

                e.Result = bpr;
            }
        }

        private void bwBatchRunner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Fehler: " + e.Error.Message);
                return;
            }

            BatchProcessResult bpr = e.Result as BatchProcessResult;
            dgvBatchLog.Rows.Add(bpr.buildCommandString, bpr.exitCode, bpr.stdOut);
        }

        private void btnRunBatch_Click(object sender, EventArgs e)
        {
            RunBatch();
        }

        public async Task<BatchProcessResult> ExecProcessAsync(BatchProcessArgs args)
        {
            return await Task.Run(() =>
            {
                var psi = new ProcessStartInfo
                {
                    FileName = args.cmd,
                    Arguments = args.args,
                    RedirectStandardOutput = args.wait ? true : false,
                    UseShellExecute = args.wait ? false : true,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.GetEncoding("CP858")
                };

                using (Process proc = Process.Start(psi))
                {
                    if (proc == null)
                        throw new InvalidOperationException("Prozess konnte nicht gestartet werden.");
                    string output = "";
                    try
                    {
                        output = proc.StandardOutput.ReadToEnd();
                    }
                    catch (Exception)
                    {

                    }
                    proc.WaitForExit();
                    return new BatchProcessResult
                    {
                        buildCommandString = args.cmd + " " + args.args,
                        exitCode = proc.ExitCode,
                        stdOut = output
                    };
                }
            });
        }

        private async void RunBatch()
        {
            if (batchIsRunning)
            {
                requestToStop = true;
                return;
            }

            btnRunBatch.Text = "Stop";
            batchIsRunning = true;
            dgvBatchLog.Rows.Clear();
            prgBatchProgress.Value = 0;


            List<DataRowView> currentBatchList = new List<DataRowView>();

            foreach (DataRowView row in bsBatchValues)
            {
                if ((bool)row["Active"] == true)
                {
                    currentBatchList.Add(row);
                }
            }

            foreach (DataRowView row in currentBatchList)
            {
                
                if (requestToStop)
                {
                    requestToStop = false;
                    batchIsRunning = false;
                    btnRunBatch.Text = "Start";
                    return;
                }

                bsBatchValues.Position = bsBatchValues.IndexOf(row);
                if (dgvBatchValues.CurrentRow != null && !dgvBatchValues.CurrentRow.IsNewRow)
                {
                    dgvBatchValues.FirstDisplayedScrollingRowIndex = dgvBatchValues.CurrentRow.Index;
                }

                BatchProcessArgs bpa = new BatchProcessArgs()
                {
                    cmd = buildCommandString(),
                    args = buildArgsString(),
                    wait = cbWait.Checked
                };

                int logRowID = dgvBatchLog.Rows.Add(bpa.cmd + bpa.args, null, "");
                DataGridViewRow logRow = dgvBatchLog.Rows[logRowID];

                BatchProcessResult bpr = await ExecProcessAsync(bpa);
                if (bpr != null)
                {
                    logRow.Cells[0].Value = bpr.buildCommandString;
                    logRow.Cells[1].Value = bpr.exitCode;
                    logRow.Cells[2].Value = bpr.stdOut;
                }

                prgBatchProgress.Value += (100 / currentBatchList.Count);
                await Task.Delay(1000);

                
            }
            batchIsRunning = false;
            btnRunBatch.Text = "Start";
            prgBatchProgress.Value = 0;
        }
    }
}
