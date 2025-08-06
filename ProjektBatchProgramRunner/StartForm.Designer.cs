namespace BatchProgramRunner
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTempNewTitle = new System.Windows.Forms.Label();
            this.lblTempNewName = new System.Windows.Forms.Label();
            this.txtNewTempName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddTemplate = new System.Windows.Forms.Button();
            this.btnRemoveTemplate = new System.Windows.Forms.Button();
            this.lstTemplates = new System.Windows.Forms.ListBox();
            this.bsCommndTemplate = new System.Windows.Forms.BindingSource(this.components);
            this.dsBatchProgramRunner = new System.Data.DataSet();
            this.dtCommandTemplates = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dtAssignedParams = new System.Data.DataTable();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dtBatchList = new System.Data.DataTable();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPathToExe = new System.Windows.Forms.Label();
            this.txtPathToExe = new System.Windows.Forms.TextBox();
            this.btnOpenPathToEXE = new System.Windows.Forms.Button();
            this.rdChckStatPathToExe = new System.Windows.Forms.RadioButton();
            this.dgvAssignedParams = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAssignedParams = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBatchValueList = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadBatchVal = new System.Windows.Forms.Button();
            this.btnSaveBatchVal = new System.Windows.Forms.Button();
            this.dgvBatchValues = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBatchValues = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTemplateList = new System.Windows.Forms.Label();
            this.btnRunBatch = new System.Windows.Forms.Button();
            this.prgBatchProgress = new System.Windows.Forms.ProgressBar();
            this.dgBatchLog = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstTemplateSelect = new System.Windows.Forms.ComboBox();
            this.bsSelectedTemplate = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblTopTemplateEdit = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lblTopBatchRunner = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTemp = new System.Windows.Forms.TabPage();
            this.tpBatchRunner = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bsSelectedAssValue = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCommndTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBatchProgramRunner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCommandTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAssignedParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBatchList)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssignedParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBatchValues)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBatchLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpTemp.SuspendLayout();
            this.tpBatchRunner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedAssValue)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel4);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lstTemplates, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblTempNewTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTempNewName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNewTempName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblTempNewTitle
            // 
            resources.ApplyResources(this.lblTempNewTitle, "lblTempNewTitle");
            this.tableLayoutPanel1.SetColumnSpan(this.lblTempNewTitle, 2);
            this.lblTempNewTitle.Name = "lblTempNewTitle";
            // 
            // lblTempNewName
            // 
            resources.ApplyResources(this.lblTempNewName, "lblTempNewName");
            this.lblTempNewName.Name = "lblTempNewName";
            // 
            // txtNewTempName
            // 
            resources.ApplyResources(this.txtNewTempName, "txtNewTempName");
            this.txtNewTempName.Name = "txtNewTempName";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAddTemplate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRemoveTemplate, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btnAddTemplate
            // 
            resources.ApplyResources(this.btnAddTemplate, "btnAddTemplate");
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.UseVisualStyleBackColor = true;
            this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
            // 
            // btnRemoveTemplate
            // 
            resources.ApplyResources(this.btnRemoveTemplate, "btnRemoveTemplate");
            this.btnRemoveTemplate.Name = "btnRemoveTemplate";
            this.btnRemoveTemplate.UseVisualStyleBackColor = true;
            this.btnRemoveTemplate.Click += new System.EventHandler(this.btnRemoveTemplate_Click);
            // 
            // lstTemplates
            // 
            this.lstTemplates.DataSource = this.bsCommndTemplate;
            this.lstTemplates.DisplayMember = "Name";
            resources.ApplyResources(this.lstTemplates, "lstTemplates");
            this.lstTemplates.FormattingEnabled = true;
            this.lstTemplates.Name = "lstTemplates";
            this.lstTemplates.ValueMember = "Name";
            // 
            // bsCommndTemplate
            // 
            this.bsCommndTemplate.DataMember = "dtCommandTemplates";
            this.bsCommndTemplate.DataSource = this.dsBatchProgramRunner;
            // 
            // dsBatchProgramRunner
            // 
            this.dsBatchProgramRunner.DataSetName = "BatchProgramRunnerDataSet";
            this.dsBatchProgramRunner.Relations.AddRange(new System.Data.DataRelation[] {
            new System.Data.DataRelation("Relation1", "dtCommandTemplates", "dtAssignedParams", new string[] {
                        "ID"}, new string[] {
                        "dtCT_ID"}, false)});
            this.dsBatchProgramRunner.Tables.AddRange(new System.Data.DataTable[] {
            this.dtCommandTemplates,
            this.dtAssignedParams,
            this.dtBatchList});
            // 
            // dtCommandTemplates
            // 
            this.dtCommandTemplates.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.dtCommandTemplates.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ID"}, true),
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "Name"}, false)});
            this.dtCommandTemplates.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn1};
            this.dtCommandTemplates.TableName = "dtCommandTemplates";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.AutoIncrement = true;
            this.dataColumn1.Caption = "ID";
            this.dataColumn1.ColumnName = "ID";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.AllowDBNull = false;
            this.dataColumn2.Caption = "Name";
            this.dataColumn2.ColumnName = "Name";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "CommandPath";
            this.dataColumn3.ColumnName = "CommandPath";
            // 
            // dtAssignedParams
            // 
            this.dtAssignedParams.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.dtAssignedParams.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ID"}, true),
            new System.Data.ForeignKeyConstraint("Relation1", "dtCommandTemplates", new string[] {
                        "ID"}, new string[] {
                        "dtCT_ID"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)});
            this.dtAssignedParams.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn4};
            this.dtAssignedParams.TableName = "dtAssignedParams";
            // 
            // dataColumn4
            // 
            this.dataColumn4.AllowDBNull = false;
            this.dataColumn4.AutoIncrement = true;
            this.dataColumn4.Caption = "ID";
            this.dataColumn4.ColumnName = "ID";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.AllowDBNull = false;
            this.dataColumn5.Caption = "dtCT_ID";
            this.dataColumn5.ColumnName = "dtCT_ID";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Param";
            this.dataColumn6.ColumnName = "Param";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Value";
            this.dataColumn7.ColumnName = "Value";
            // 
            // dtBatchList
            // 
            this.dtBatchList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10});
            this.dtBatchList.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ID"}, false)});
            this.dtBatchList.TableName = "dtBatchList";
            // 
            // dataColumn8
            // 
            this.dataColumn8.AllowDBNull = false;
            this.dataColumn8.AutoIncrement = true;
            this.dataColumn8.Caption = "ID";
            this.dataColumn8.ColumnName = "ID";
            this.dataColumn8.DataType = typeof(int);
            // 
            // dataColumn9
            // 
            this.dataColumn9.Caption = "Value";
            this.dataColumn9.ColumnName = "Value";
            // 
            // dataColumn10
            // 
            this.dataColumn10.Caption = "Active";
            this.dataColumn10.ColumnName = "Active";
            this.dataColumn10.DataType = typeof(bool);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.lblPathToExe, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtPathToExe, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnOpenPathToEXE, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.rdChckStatPathToExe, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.dgvAssignedParams, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // lblPathToExe
            // 
            resources.ApplyResources(this.lblPathToExe, "lblPathToExe");
            this.lblPathToExe.Name = "lblPathToExe";
            // 
            // txtPathToExe
            // 
            this.txtPathToExe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCommndTemplate, "CommandPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtPathToExe, "txtPathToExe");
            this.txtPathToExe.Name = "txtPathToExe";
            this.txtPathToExe.TextChanged += new System.EventHandler(this.txtPathToExe_TextChanged);
            // 
            // btnOpenPathToEXE
            // 
            resources.ApplyResources(this.btnOpenPathToEXE, "btnOpenPathToEXE");
            this.btnOpenPathToEXE.Name = "btnOpenPathToEXE";
            this.btnOpenPathToEXE.UseVisualStyleBackColor = true;
            this.btnOpenPathToEXE.Click += new System.EventHandler(this.btnOpenPathToEXE_Click);
            // 
            // rdChckStatPathToExe
            // 
            this.rdChckStatPathToExe.AutoCheck = false;
            resources.ApplyResources(this.rdChckStatPathToExe, "rdChckStatPathToExe");
            this.rdChckStatPathToExe.BackColor = System.Drawing.Color.Transparent;
            this.rdChckStatPathToExe.Checked = true;
            this.rdChckStatPathToExe.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdChckStatPathToExe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdChckStatPathToExe.FlatAppearance.BorderSize = 5;
            this.rdChckStatPathToExe.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rdChckStatPathToExe.ForeColor = System.Drawing.Color.Red;
            this.rdChckStatPathToExe.Name = "rdChckStatPathToExe";
            this.rdChckStatPathToExe.TabStop = true;
            this.rdChckStatPathToExe.UseVisualStyleBackColor = false;
            // 
            // dgvAssignedParams
            // 
            this.dgvAssignedParams.AllowUserToResizeColumns = false;
            this.dgvAssignedParams.AllowUserToResizeRows = false;
            this.dgvAssignedParams.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignedParams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAssignedParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dtCT_ID,
            this.Param,
            this.Value});
            this.tableLayoutPanel4.SetColumnSpan(this.dgvAssignedParams, 4);
            this.dgvAssignedParams.DataSource = this.bsAssignedParams;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignedParams.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.dgvAssignedParams, "dgvAssignedParams");
            this.dgvAssignedParams.Name = "dgvAssignedParams";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignedParams.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAssignedParams.RowHeadersVisible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtCT_ID
            // 
            this.dtCT_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtCT_ID.DataPropertyName = "dtCT_ID";
            this.dtCT_ID.FillWeight = 20F;
            resources.ApplyResources(this.dtCT_ID, "dtCT_ID");
            this.dtCT_ID.Name = "dtCT_ID";
            this.dtCT_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param
            // 
            this.Param.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Param.DataPropertyName = "Param";
            resources.ApplyResources(this.Param, "Param");
            this.Param.Name = "Param";
            this.Param.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.DataPropertyName = "Value";
            resources.ApplyResources(this.Value, "Value");
            this.Value.Name = "Value";
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bsAssignedParams
            // 
            this.bsAssignedParams.DataMember = "Relation1";
            this.bsAssignedParams.DataSource = this.bsCommndTemplate;
            // 
            // splitContainer4
            // 
            resources.ApplyResources(this.splitContainer4, "splitContainer4");
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            resources.ApplyResources(this.splitContainer4.Panel1, "splitContainer4.Panel1");
            this.splitContainer4.Panel1.Controls.Add(this.tableLayoutPanel5);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tableLayoutPanel8);
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dgvBatchValues, 0, 1);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.lblBatchValueList, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // lblBatchValueList
            // 
            resources.ApplyResources(this.lblBatchValueList, "lblBatchValueList");
            this.tableLayoutPanel6.SetColumnSpan(this.lblBatchValueList, 2);
            this.lblBatchValueList.Name = "lblBatchValueList";
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel6.SetColumnSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.Controls.Add(this.btnLoadBatchVal, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnSaveBatchVal, 1, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // btnLoadBatchVal
            // 
            resources.ApplyResources(this.btnLoadBatchVal, "btnLoadBatchVal");
            this.btnLoadBatchVal.Name = "btnLoadBatchVal";
            this.btnLoadBatchVal.UseVisualStyleBackColor = true;
            this.btnLoadBatchVal.Click += new System.EventHandler(this.btnLoadBatchVal_Click);
            // 
            // btnSaveBatchVal
            // 
            resources.ApplyResources(this.btnSaveBatchVal, "btnSaveBatchVal");
            this.btnSaveBatchVal.Name = "btnSaveBatchVal";
            this.btnSaveBatchVal.UseVisualStyleBackColor = true;
            this.btnSaveBatchVal.Click += new System.EventHandler(this.btnSaveBatchVal_Click);
            // 
            // dgvBatchValues
            // 
            this.dgvBatchValues.AllowUserToResizeColumns = false;
            this.dgvBatchValues.AllowUserToResizeRows = false;
            this.dgvBatchValues.AutoGenerateColumns = false;
            this.dgvBatchValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBatchValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchValues.ColumnHeadersVisible = false;
            this.dgvBatchValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.activeDataGridViewCheckBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dgvBatchValues.DataSource = this.bsBatchValues;
            resources.ApplyResources(this.dgvBatchValues, "dgvBatchValues");
            this.dgvBatchValues.Name = "dgvBatchValues";
            this.dgvBatchValues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBatchValues.SelectionChanged += new System.EventHandler(this.dgvBatchValues_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn1, "iDDataGridViewTextBoxColumn1");
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            resources.ApplyResources(this.activeDataGridViewCheckBoxColumn, "activeDataGridViewCheckBoxColumn");
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            resources.ApplyResources(this.valueDataGridViewTextBoxColumn, "valueDataGridViewTextBoxColumn");
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // bsBatchValues
            // 
            this.bsBatchValues.DataMember = "dtBatchList";
            this.bsBatchValues.DataSource = this.dsBatchProgramRunner;
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.lblTemplateList, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnRunBatch, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.prgBatchProgress, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.dgBatchLog, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lstTemplateSelect, 1, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // lblTemplateList
            // 
            resources.ApplyResources(this.lblTemplateList, "lblTemplateList");
            this.lblTemplateList.Name = "lblTemplateList";
            // 
            // btnRunBatch
            // 
            resources.ApplyResources(this.btnRunBatch, "btnRunBatch");
            this.btnRunBatch.Name = "btnRunBatch";
            this.btnRunBatch.UseVisualStyleBackColor = true;
            // 
            // prgBatchProgress
            // 
            resources.ApplyResources(this.prgBatchProgress, "prgBatchProgress");
            this.prgBatchProgress.Name = "prgBatchProgress";
            // 
            // dgBatchLog
            // 
            this.dgBatchLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBatchLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgBatchLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBatchLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tableLayoutPanel8.SetColumnSpan(this.dgBatchLog, 4);
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBatchLog.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.dgBatchLog, "dgBatchLog");
            this.dgBatchLog.Name = "dgBatchLog";
            this.dgBatchLog.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBatchLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgBatchLog.RowHeadersVisible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // lstTemplateSelect
            // 
            this.lstTemplateSelect.DataSource = this.bsSelectedTemplate;
            this.lstTemplateSelect.DisplayMember = "Name";
            resources.ApplyResources(this.lstTemplateSelect, "lstTemplateSelect");
            this.lstTemplateSelect.FormattingEnabled = true;
            this.lstTemplateSelect.Name = "lstTemplateSelect";
            this.lstTemplateSelect.ValueMember = "CommandPath";
            // 
            // bsSelectedTemplate
            // 
            this.bsSelectedTemplate.DataMember = "dtCommandTemplates";
            this.bsSelectedTemplate.DataSource = this.dsBatchProgramRunner;
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblTopTemplateEdit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            // 
            // lblTopTemplateEdit
            // 
            resources.ApplyResources(this.lblTopTemplateEdit, "lblTopTemplateEdit");
            this.lblTopTemplateEdit.Name = "lblTopTemplateEdit";
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lblTopBatchRunner);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            // 
            // lblTopBatchRunner
            // 
            resources.ApplyResources(this.lblTopBatchRunner, "lblTopBatchRunner");
            this.lblTopBatchRunner.Name = "lblTopBatchRunner";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTemp);
            this.tabControl1.Controls.Add(this.tpBatchRunner);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tpTemp
            // 
            this.tpTemp.Controls.Add(this.splitContainer1);
            resources.ApplyResources(this.tpTemp, "tpTemp");
            this.tpTemp.Name = "tpTemp";
            this.tpTemp.UseVisualStyleBackColor = true;
            // 
            // tpBatchRunner
            // 
            this.tpBatchRunner.Controls.Add(this.splitContainer3);
            resources.ApplyResources(this.tpBatchRunner, "tpBatchRunner");
            this.tpBatchRunner.Name = "tpBatchRunner";
            this.tpBatchRunner.UseVisualStyleBackColor = true;
            // 
            // bsSelectedAssValue
            // 
            this.bsSelectedAssValue.DataMember = "Relation1";
            this.bsSelectedAssValue.DataSource = this.bsSelectedTemplate;
            this.bsSelectedAssValue.CurrentChanged += new System.EventHandler(this.lstTemplateSelect_SelectedIndexChanged);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMain";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCommndTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBatchProgramRunner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCommandTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAssignedParams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBatchList)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedParams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssignedParams)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBatchValues)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBatchLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedTemplate)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpTemp.ResumeLayout(false);
            this.tpBatchRunner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedAssValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTemp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTempNewTitle;
        private System.Windows.Forms.Label lblTempNewName;
        private System.Windows.Forms.TextBox txtNewTempName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAddTemplate;
        private System.Windows.Forms.Button btnRemoveTemplate;
        private System.Windows.Forms.DataGridView dgvAssignedParams;
        private System.Windows.Forms.TabPage tpBatchRunner;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblPathToExe;
        private System.Windows.Forms.TextBox txtPathToExe;
        private System.Windows.Forms.Button btnOpenPathToEXE;
        private System.Windows.Forms.RadioButton rdChckStatPathToExe;
        private System.Windows.Forms.ListBox lstTemplates;
        private System.Windows.Forms.Label lblTopTemplateEdit;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label lblTopBatchRunner;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblBatchValueList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnLoadBatchVal;
        private System.Windows.Forms.Button btnSaveBatchVal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lblTemplateList;
        private System.Windows.Forms.Button btnRunBatch;
        private System.Windows.Forms.ProgressBar prgBatchProgress;
        private System.Windows.Forms.DataGridView dgBatchLog;
        private System.Windows.Forms.ComboBox lstTemplateSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Data.DataSet dsBatchProgramRunner;
        private System.Data.DataTable dtCommandTemplates;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.BindingSource bsCommndTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Data.DataTable dtAssignedParams;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.BindingSource bsAssignedParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.BindingSource bsSelectedTemplate;
        private System.Windows.Forms.BindingSource bsSelectedAssValue;
        private System.Data.DataTable dtBatchList;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.DataGridView dgvBatchValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsBatchValues;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

