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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.scBatchRunner = new System.Windows.Forms.SplitContainer();
            this.tlBatchValueMgmt = new System.Windows.Forms.TableLayoutPanel();
            this.tlBatchValueAktion = new System.Windows.Forms.TableLayoutPanel();
            this.lblBatchValueList = new System.Windows.Forms.Label();
            this.tlBPLoadSave = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadBatchVal = new System.Windows.Forms.Button();
            this.btnSaveBatchVal = new System.Windows.Forms.Button();
            this.dgvBatchValues = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcBV_Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcBV_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBatchValues = new System.Windows.Forms.BindingSource(this.components);
            this.tlBVLActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnMrkSelect = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.btnInvertSelect = new System.Windows.Forms.Button();
            this.btnFilterSelect = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTemplateList = new System.Windows.Forms.Label();
            this.btnRunBatch = new System.Windows.Forms.Button();
            this.prgBatchProgress = new System.Windows.Forms.ProgressBar();
            this.dgvBatchLog = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstTemplateSelect = new System.Windows.Forms.ComboBox();
            this.bsSelectedTemplate = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblTopTemplateEdit = new System.Windows.Forms.Label();
            this.scBatchRunnerMgmt = new System.Windows.Forms.SplitContainer();
            this.lblTopBatchRunner = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTemp = new System.Windows.Forms.TabPage();
            this.tpBatchRunner = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bsSelectedAssValue = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.bwBatchRunner = new System.ComponentModel.BackgroundWorker();
            this.cbWait = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.scBatchRunner)).BeginInit();
            this.scBatchRunner.Panel1.SuspendLayout();
            this.scBatchRunner.Panel2.SuspendLayout();
            this.scBatchRunner.SuspendLayout();
            this.tlBatchValueMgmt.SuspendLayout();
            this.tlBatchValueAktion.SuspendLayout();
            this.tlBPLoadSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBatchValues)).BeginInit();
            this.tlBVLActions.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatchRunnerMgmt)).BeginInit();
            this.scBatchRunnerMgmt.Panel1.SuspendLayout();
            this.scBatchRunnerMgmt.Panel2.SuspendLayout();
            this.scBatchRunnerMgmt.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignedParams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignedParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dtCT_ID,
            this.Param,
            this.Value});
            this.tableLayoutPanel4.SetColumnSpan(this.dgvAssignedParams, 4);
            this.dgvAssignedParams.DataSource = this.bsAssignedParams;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignedParams.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dgvAssignedParams, "dgvAssignedParams");
            this.dgvAssignedParams.Name = "dgvAssignedParams";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignedParams.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            // scBatchRunner
            // 
            resources.ApplyResources(this.scBatchRunner, "scBatchRunner");
            this.scBatchRunner.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scBatchRunner.Name = "scBatchRunner";
            // 
            // scBatchRunner.Panel1
            // 
            resources.ApplyResources(this.scBatchRunner.Panel1, "scBatchRunner.Panel1");
            this.scBatchRunner.Panel1.Controls.Add(this.tlBatchValueMgmt);
            // 
            // scBatchRunner.Panel2
            // 
            this.scBatchRunner.Panel2.Controls.Add(this.tableLayoutPanel8);
            // 
            // tlBatchValueMgmt
            // 
            resources.ApplyResources(this.tlBatchValueMgmt, "tlBatchValueMgmt");
            this.tlBatchValueMgmt.Controls.Add(this.tlBatchValueAktion, 0, 0);
            this.tlBatchValueMgmt.Controls.Add(this.dgvBatchValues, 0, 1);
            this.tlBatchValueMgmt.Controls.Add(this.tlBVLActions, 0, 2);
            this.tlBatchValueMgmt.Name = "tlBatchValueMgmt";
            // 
            // tlBatchValueAktion
            // 
            resources.ApplyResources(this.tlBatchValueAktion, "tlBatchValueAktion");
            this.tlBatchValueAktion.Controls.Add(this.lblBatchValueList, 0, 0);
            this.tlBatchValueAktion.Controls.Add(this.tlBPLoadSave, 0, 1);
            this.tlBatchValueAktion.Name = "tlBatchValueAktion";
            // 
            // lblBatchValueList
            // 
            resources.ApplyResources(this.lblBatchValueList, "lblBatchValueList");
            this.tlBatchValueAktion.SetColumnSpan(this.lblBatchValueList, 2);
            this.lblBatchValueList.Name = "lblBatchValueList";
            // 
            // tlBPLoadSave
            // 
            resources.ApplyResources(this.tlBPLoadSave, "tlBPLoadSave");
            this.tlBatchValueAktion.SetColumnSpan(this.tlBPLoadSave, 2);
            this.tlBPLoadSave.Controls.Add(this.btnLoadBatchVal, 0, 0);
            this.tlBPLoadSave.Controls.Add(this.btnSaveBatchVal, 1, 0);
            this.tlBPLoadSave.Name = "tlBPLoadSave";
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
            this.dgvcBV_Active,
            this.dgvcBV_Value});
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
            // dgvcBV_Active
            // 
            this.dgvcBV_Active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvcBV_Active.DataPropertyName = "Active";
            resources.ApplyResources(this.dgvcBV_Active, "dgvcBV_Active");
            this.dgvcBV_Active.Name = "dgvcBV_Active";
            // 
            // dgvcBV_Value
            // 
            this.dgvcBV_Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcBV_Value.DataPropertyName = "Value";
            resources.ApplyResources(this.dgvcBV_Value, "dgvcBV_Value");
            this.dgvcBV_Value.Name = "dgvcBV_Value";
            // 
            // bsBatchValues
            // 
            this.bsBatchValues.DataMember = "dtBatchList";
            this.bsBatchValues.DataSource = this.dsBatchProgramRunner;
            // 
            // tlBVLActions
            // 
            resources.ApplyResources(this.tlBVLActions, "tlBVLActions");
            this.tlBVLActions.Controls.Add(this.btnMrkSelect, 2, 0);
            this.tlBVLActions.Controls.Add(this.btnSelectAll, 0, 0);
            this.tlBVLActions.Controls.Add(this.btnSelectNone, 1, 0);
            this.tlBVLActions.Controls.Add(this.btnInvertSelect, 3, 0);
            this.tlBVLActions.Controls.Add(this.btnFilterSelect, 4, 0);
            this.tlBVLActions.Name = "tlBVLActions";
            // 
            // btnMrkSelect
            // 
            resources.ApplyResources(this.btnMrkSelect, "btnMrkSelect");
            this.btnMrkSelect.Name = "btnMrkSelect";
            this.btnMrkSelect.UseVisualStyleBackColor = true;
            this.btnMrkSelect.Click += new System.EventHandler(this.btnMrkSelect_Click);
            // 
            // btnSelectAll
            // 
            resources.ApplyResources(this.btnSelectAll, "btnSelectAll");
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            resources.ApplyResources(this.btnSelectNone, "btnSelectNone");
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnInvertSelect
            // 
            resources.ApplyResources(this.btnInvertSelect, "btnInvertSelect");
            this.btnInvertSelect.Name = "btnInvertSelect";
            this.btnInvertSelect.UseVisualStyleBackColor = true;
            this.btnInvertSelect.Click += new System.EventHandler(this.btnInvertSelect_Click);
            // 
            // btnFilterSelect
            // 
            resources.ApplyResources(this.btnFilterSelect, "btnFilterSelect");
            this.btnFilterSelect.Name = "btnFilterSelect";
            this.btnFilterSelect.UseVisualStyleBackColor = true;
            this.btnFilterSelect.Click += new System.EventHandler(this.btnFilterSelect_Click);
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.lblTemplateList, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnRunBatch, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.prgBatchProgress, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.dgvBatchLog, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lstTemplateSelect, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.cbWait, 2, 0);
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
            this.btnRunBatch.Click += new System.EventHandler(this.btnRunBatch_Click);
            // 
            // prgBatchProgress
            // 
            resources.ApplyResources(this.prgBatchProgress, "prgBatchProgress");
            this.prgBatchProgress.MarqueeAnimationSpeed = 10;
            this.prgBatchProgress.Name = "prgBatchProgress";
            this.prgBatchProgress.Step = 1;
            this.prgBatchProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // dgvBatchLog
            // 
            this.dgvBatchLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBatchLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBatchLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tableLayoutPanel8.SetColumnSpan(this.dgvBatchLog, 5);
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBatchLog.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.dgvBatchLog, "dgvBatchLog");
            this.dgvBatchLog.Name = "dgvBatchLog";
            this.dgvBatchLog.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBatchLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBatchLog.RowHeadersVisible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
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
            // scBatchRunnerMgmt
            // 
            resources.ApplyResources(this.scBatchRunnerMgmt, "scBatchRunnerMgmt");
            this.scBatchRunnerMgmt.Name = "scBatchRunnerMgmt";
            // 
            // scBatchRunnerMgmt.Panel1
            // 
            this.scBatchRunnerMgmt.Panel1.Controls.Add(this.lblTopBatchRunner);
            // 
            // scBatchRunnerMgmt.Panel2
            // 
            this.scBatchRunnerMgmt.Panel2.Controls.Add(this.scBatchRunner);
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
            this.tpBatchRunner.Controls.Add(this.scBatchRunnerMgmt);
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
            // bwBatchRunner
            // 
            this.bwBatchRunner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwBatchRunner_DoWork);
            this.bwBatchRunner.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwBatchRunner_RunWorkerCompleted);
            // 
            // cbWait
            // 
            resources.ApplyResources(this.cbWait, "cbWait");
            this.cbWait.Checked = true;
            this.cbWait.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWait.Name = "cbWait";
            this.cbWait.UseVisualStyleBackColor = true;
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
            this.scBatchRunner.Panel1.ResumeLayout(false);
            this.scBatchRunner.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBatchRunner)).EndInit();
            this.scBatchRunner.ResumeLayout(false);
            this.tlBatchValueMgmt.ResumeLayout(false);
            this.tlBatchValueMgmt.PerformLayout();
            this.tlBatchValueAktion.ResumeLayout(false);
            this.tlBatchValueAktion.PerformLayout();
            this.tlBPLoadSave.ResumeLayout(false);
            this.tlBPLoadSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBatchValues)).EndInit();
            this.tlBVLActions.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedTemplate)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.scBatchRunnerMgmt.Panel1.ResumeLayout(false);
            this.scBatchRunnerMgmt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBatchRunnerMgmt)).EndInit();
            this.scBatchRunnerMgmt.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer scBatchRunnerMgmt;
        private System.Windows.Forms.Label lblTopBatchRunner;
        private System.Windows.Forms.SplitContainer scBatchRunner;
        private System.Windows.Forms.TableLayoutPanel tlBatchValueMgmt;
        private System.Windows.Forms.TableLayoutPanel tlBatchValueAktion;
        private System.Windows.Forms.Label lblBatchValueList;
        private System.Windows.Forms.TableLayoutPanel tlBPLoadSave;
        private System.Windows.Forms.Button btnLoadBatchVal;
        private System.Windows.Forms.Button btnSaveBatchVal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lblTemplateList;
        private System.Windows.Forms.Button btnRunBatch;
        private System.Windows.Forms.ProgressBar prgBatchProgress;
        private System.Windows.Forms.DataGridView dgvBatchLog;
        private System.Windows.Forms.ComboBox lstTemplateSelect;
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
        private System.Windows.Forms.BindingSource bsBatchValues;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TableLayoutPanel tlBVLActions;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Button btnInvertSelect;
        private System.Windows.Forms.Button btnFilterSelect;
        private System.Windows.Forms.Button btnMrkSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcBV_Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcBV_Value;
        private System.ComponentModel.BackgroundWorker bwBatchRunner;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.CheckBox cbWait;
    }
}

