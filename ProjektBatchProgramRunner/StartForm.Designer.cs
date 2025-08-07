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
            this.cbWait = new System.Windows.Forms.CheckBox();
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
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Panel1MinSize = 230;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer2.Panel2MinSize = 200;
            this.splitContainer2.Size = new System.Drawing.Size(781, 282);
            this.splitContainer2.SplitterDistance = 230;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lstTemplates, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(230, 282);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTempNewTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTempNewName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNewTempName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 86);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTempNewTitle
            // 
            this.lblTempNewTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTempNewTitle, 2);
            this.lblTempNewTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTempNewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTempNewTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTempNewTitle.Name = "lblTempNewTitle";
            this.lblTempNewTitle.Size = new System.Drawing.Size(224, 25);
            this.lblTempNewTitle.TabIndex = 0;
            this.lblTempNewTitle.Text = "New Templates";
            this.lblTempNewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempNewName
            // 
            this.lblTempNewName.AutoSize = true;
            this.lblTempNewName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTempNewName.Location = new System.Drawing.Point(0, 25);
            this.lblTempNewName.Margin = new System.Windows.Forms.Padding(0);
            this.lblTempNewName.Name = "lblTempNewName";
            this.lblTempNewName.Size = new System.Drawing.Size(63, 26);
            this.lblTempNewName.TabIndex = 1;
            this.lblTempNewName.Text = "New Name:";
            this.lblTempNewName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewTempName
            // 
            this.txtNewTempName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewTempName.Location = new System.Drawing.Point(66, 28);
            this.txtNewTempName.Name = "txtNewTempName";
            this.txtNewTempName.Size = new System.Drawing.Size(161, 20);
            this.txtNewTempName.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddTemplate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRemoveTemplate, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(224, 29);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.AutoSize = true;
            this.btnAddTemplate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddTemplate.Location = new System.Drawing.Point(3, 3);
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.Size = new System.Drawing.Size(68, 23);
            this.btnAddTemplate.TabIndex = 0;
            this.btnAddTemplate.Text = "Add";
            this.btnAddTemplate.UseVisualStyleBackColor = true;
            this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
            // 
            // btnRemoveTemplate
            // 
            this.btnRemoveTemplate.AutoSize = true;
            this.btnRemoveTemplate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveTemplate.Location = new System.Drawing.Point(77, 3);
            this.btnRemoveTemplate.Name = "btnRemoveTemplate";
            this.btnRemoveTemplate.Size = new System.Drawing.Size(68, 23);
            this.btnRemoveTemplate.TabIndex = 1;
            this.btnRemoveTemplate.Text = "Remove";
            this.btnRemoveTemplate.UseVisualStyleBackColor = true;
            this.btnRemoveTemplate.Click += new System.EventHandler(this.btnRemoveTemplate_Click);
            // 
            // lstTemplates
            // 
            this.lstTemplates.DataSource = this.bsCommndTemplate;
            this.lstTemplates.DisplayMember = "Name";
            this.lstTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTemplates.FormattingEnabled = true;
            this.lstTemplates.Location = new System.Drawing.Point(3, 89);
            this.lstTemplates.Name = "lstTemplates";
            this.lstTemplates.Size = new System.Drawing.Size(224, 190);
            this.lstTemplates.TabIndex = 1;
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
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.lblPathToExe, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtPathToExe, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnOpenPathToEXE, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.rdChckStatPathToExe, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.dgvAssignedParams, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(550, 282);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lblPathToExe
            // 
            this.lblPathToExe.AutoSize = true;
            this.lblPathToExe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPathToExe.Location = new System.Drawing.Point(0, 0);
            this.lblPathToExe.Margin = new System.Windows.Forms.Padding(0);
            this.lblPathToExe.Name = "lblPathToExe";
            this.lblPathToExe.Size = new System.Drawing.Size(68, 29);
            this.lblPathToExe.TabIndex = 1;
            this.lblPathToExe.Text = "Path to EXE:";
            this.lblPathToExe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPathToExe
            // 
            this.txtPathToExe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCommndTemplate, "CommandPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPathToExe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPathToExe.Location = new System.Drawing.Point(71, 3);
            this.txtPathToExe.Name = "txtPathToExe";
            this.txtPathToExe.Size = new System.Drawing.Size(399, 20);
            this.txtPathToExe.TabIndex = 0;
            this.txtPathToExe.TextChanged += new System.EventHandler(this.txtPathToExe_TextChanged);
            // 
            // btnOpenPathToEXE
            // 
            this.btnOpenPathToEXE.AutoSize = true;
            this.btnOpenPathToEXE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenPathToEXE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenPathToEXE.Location = new System.Drawing.Point(476, 3);
            this.btnOpenPathToEXE.Name = "btnOpenPathToEXE";
            this.btnOpenPathToEXE.Size = new System.Drawing.Size(52, 23);
            this.btnOpenPathToEXE.TabIndex = 2;
            this.btnOpenPathToEXE.Text = "Open...";
            this.btnOpenPathToEXE.UseVisualStyleBackColor = true;
            this.btnOpenPathToEXE.Click += new System.EventHandler(this.btnOpenPathToEXE_Click);
            // 
            // rdChckStatPathToExe
            // 
            this.rdChckStatPathToExe.AutoCheck = false;
            this.rdChckStatPathToExe.AutoSize = true;
            this.rdChckStatPathToExe.BackColor = System.Drawing.Color.Transparent;
            this.rdChckStatPathToExe.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdChckStatPathToExe.Checked = true;
            this.rdChckStatPathToExe.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdChckStatPathToExe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdChckStatPathToExe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdChckStatPathToExe.FlatAppearance.BorderSize = 5;
            this.rdChckStatPathToExe.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rdChckStatPathToExe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdChckStatPathToExe.ForeColor = System.Drawing.Color.Red;
            this.rdChckStatPathToExe.Location = new System.Drawing.Point(534, 3);
            this.rdChckStatPathToExe.Name = "rdChckStatPathToExe";
            this.rdChckStatPathToExe.Size = new System.Drawing.Size(13, 23);
            this.rdChckStatPathToExe.TabIndex = 1;
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
            this.dgvAssignedParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignedParams.Location = new System.Drawing.Point(3, 32);
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
            this.dgvAssignedParams.Size = new System.Drawing.Size(544, 247);
            this.dgvAssignedParams.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtCT_ID
            // 
            this.dtCT_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtCT_ID.DataPropertyName = "dtCT_ID";
            this.dtCT_ID.FillWeight = 20F;
            this.dtCT_ID.HeaderText = "dtCT_ID";
            this.dtCT_ID.Name = "dtCT_ID";
            this.dtCT_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dtCT_ID.Visible = false;
            // 
            // Param
            // 
            this.Param.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Param.DataPropertyName = "Param";
            this.Param.HeaderText = "Param";
            this.Param.Name = "Param";
            this.Param.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Value";
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
            this.scBatchRunner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBatchRunner.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scBatchRunner.IsSplitterFixed = true;
            this.scBatchRunner.Location = new System.Drawing.Point(0, 0);
            this.scBatchRunner.Name = "scBatchRunner";
            // 
            // scBatchRunner.Panel1
            // 
            this.scBatchRunner.Panel1.AutoScroll = true;
            this.scBatchRunner.Panel1.Controls.Add(this.tlBatchValueMgmt);
            this.scBatchRunner.Panel1MinSize = 230;
            // 
            // scBatchRunner.Panel2
            // 
            this.scBatchRunner.Panel2.Controls.Add(this.tableLayoutPanel8);
            this.scBatchRunner.Panel2MinSize = 200;
            this.scBatchRunner.Size = new System.Drawing.Size(781, 282);
            this.scBatchRunner.SplitterDistance = 230;
            this.scBatchRunner.SplitterWidth = 1;
            this.scBatchRunner.TabIndex = 0;
            // 
            // tlBatchValueMgmt
            // 
            this.tlBatchValueMgmt.ColumnCount = 1;
            this.tlBatchValueMgmt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlBatchValueMgmt.Controls.Add(this.tlBatchValueAktion, 0, 0);
            this.tlBatchValueMgmt.Controls.Add(this.dgvBatchValues, 0, 1);
            this.tlBatchValueMgmt.Controls.Add(this.tlBVLActions, 0, 2);
            this.tlBatchValueMgmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBatchValueMgmt.Location = new System.Drawing.Point(0, 0);
            this.tlBatchValueMgmt.Name = "tlBatchValueMgmt";
            this.tlBatchValueMgmt.RowCount = 3;
            this.tlBatchValueMgmt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlBatchValueMgmt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlBatchValueMgmt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlBatchValueMgmt.Size = new System.Drawing.Size(230, 282);
            this.tlBatchValueMgmt.TabIndex = 0;
            // 
            // tlBatchValueAktion
            // 
            this.tlBatchValueAktion.ColumnCount = 2;
            this.tlBatchValueAktion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlBatchValueAktion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlBatchValueAktion.Controls.Add(this.lblBatchValueList, 0, 0);
            this.tlBatchValueAktion.Controls.Add(this.tlBPLoadSave, 0, 1);
            this.tlBatchValueAktion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBatchValueAktion.Location = new System.Drawing.Point(0, 0);
            this.tlBatchValueAktion.Margin = new System.Windows.Forms.Padding(0);
            this.tlBatchValueAktion.Name = "tlBatchValueAktion";
            this.tlBatchValueAktion.RowCount = 2;
            this.tlBatchValueAktion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlBatchValueAktion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlBatchValueAktion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlBatchValueAktion.Size = new System.Drawing.Size(230, 44);
            this.tlBatchValueAktion.TabIndex = 0;
            // 
            // lblBatchValueList
            // 
            this.lblBatchValueList.AutoSize = true;
            this.tlBatchValueAktion.SetColumnSpan(this.lblBatchValueList, 2);
            this.lblBatchValueList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBatchValueList.Location = new System.Drawing.Point(3, 0);
            this.lblBatchValueList.Name = "lblBatchValueList";
            this.lblBatchValueList.Size = new System.Drawing.Size(224, 13);
            this.lblBatchValueList.TabIndex = 0;
            this.lblBatchValueList.Text = "Batch Value List";
            this.lblBatchValueList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlBPLoadSave
            // 
            this.tlBPLoadSave.AutoSize = true;
            this.tlBPLoadSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlBPLoadSave.ColumnCount = 2;
            this.tlBatchValueAktion.SetColumnSpan(this.tlBPLoadSave, 2);
            this.tlBPLoadSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBPLoadSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBPLoadSave.Controls.Add(this.btnLoadBatchVal, 0, 0);
            this.tlBPLoadSave.Controls.Add(this.btnSaveBatchVal, 1, 0);
            this.tlBPLoadSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBPLoadSave.Location = new System.Drawing.Point(3, 16);
            this.tlBPLoadSave.Name = "tlBPLoadSave";
            this.tlBPLoadSave.RowCount = 1;
            this.tlBPLoadSave.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlBPLoadSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlBPLoadSave.Size = new System.Drawing.Size(224, 29);
            this.tlBPLoadSave.TabIndex = 1;
            // 
            // btnLoadBatchVal
            // 
            this.btnLoadBatchVal.AutoSize = true;
            this.btnLoadBatchVal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadBatchVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadBatchVal.Location = new System.Drawing.Point(3, 3);
            this.btnLoadBatchVal.Name = "btnLoadBatchVal";
            this.btnLoadBatchVal.Size = new System.Drawing.Size(106, 23);
            this.btnLoadBatchVal.TabIndex = 0;
            this.btnLoadBatchVal.Text = "Load...";
            this.btnLoadBatchVal.UseVisualStyleBackColor = true;
            this.btnLoadBatchVal.Click += new System.EventHandler(this.btnLoadBatchVal_Click);
            // 
            // btnSaveBatchVal
            // 
            this.btnSaveBatchVal.AutoSize = true;
            this.btnSaveBatchVal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveBatchVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveBatchVal.Location = new System.Drawing.Point(115, 3);
            this.btnSaveBatchVal.Name = "btnSaveBatchVal";
            this.btnSaveBatchVal.Size = new System.Drawing.Size(106, 23);
            this.btnSaveBatchVal.TabIndex = 1;
            this.btnSaveBatchVal.Text = "Save...";
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
            this.dgvBatchValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBatchValues.Location = new System.Drawing.Point(0, 44);
            this.dgvBatchValues.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBatchValues.Name = "dgvBatchValues";
            this.dgvBatchValues.RowHeadersWidth = 20;
            this.dgvBatchValues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBatchValues.Size = new System.Drawing.Size(230, 213);
            this.dgvBatchValues.TabIndex = 4;
            this.dgvBatchValues.SelectionChanged += new System.EventHandler(this.dgvBatchValues_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dgvcBV_Active
            // 
            this.dgvcBV_Active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvcBV_Active.DataPropertyName = "Active";
            this.dgvcBV_Active.HeaderText = "Active";
            this.dgvcBV_Active.Name = "dgvcBV_Active";
            this.dgvcBV_Active.Width = 5;
            // 
            // dgvcBV_Value
            // 
            this.dgvcBV_Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcBV_Value.DataPropertyName = "Value";
            this.dgvcBV_Value.HeaderText = "Value";
            this.dgvcBV_Value.Name = "dgvcBV_Value";
            // 
            // bsBatchValues
            // 
            this.bsBatchValues.DataMember = "dtBatchList";
            this.bsBatchValues.DataSource = this.dsBatchProgramRunner;
            // 
            // tlBVLActions
            // 
            this.tlBVLActions.AutoSize = true;
            this.tlBVLActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlBVLActions.ColumnCount = 5;
            this.tlBVLActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlBVLActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlBVLActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlBVLActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlBVLActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlBVLActions.Controls.Add(this.btnMrkSelect, 2, 0);
            this.tlBVLActions.Controls.Add(this.btnSelectAll, 0, 0);
            this.tlBVLActions.Controls.Add(this.btnSelectNone, 1, 0);
            this.tlBVLActions.Controls.Add(this.btnInvertSelect, 3, 0);
            this.tlBVLActions.Controls.Add(this.btnFilterSelect, 4, 0);
            this.tlBVLActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBVLActions.Location = new System.Drawing.Point(0, 257);
            this.tlBVLActions.Margin = new System.Windows.Forms.Padding(0);
            this.tlBVLActions.MinimumSize = new System.Drawing.Size(25, 25);
            this.tlBVLActions.Name = "tlBVLActions";
            this.tlBVLActions.RowCount = 1;
            this.tlBVLActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlBVLActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlBVLActions.Size = new System.Drawing.Size(230, 25);
            this.tlBVLActions.TabIndex = 5;
            // 
            // btnMrkSelect
            // 
            this.btnMrkSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMrkSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMrkSelect.Location = new System.Drawing.Point(92, 0);
            this.btnMrkSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnMrkSelect.Name = "btnMrkSelect";
            this.btnMrkSelect.Size = new System.Drawing.Size(46, 25);
            this.btnMrkSelect.TabIndex = 4;
            this.btnMrkSelect.Text = "MarkS";
            this.btnMrkSelect.UseVisualStyleBackColor = true;
            this.btnMrkSelect.Click += new System.EventHandler(this.btnMrkSelect_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectAll.Location = new System.Drawing.Point(0, 0);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(46, 25);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.Text = "All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectNone.Location = new System.Drawing.Point(46, 0);
            this.btnSelectNone.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(46, 25);
            this.btnSelectNone.TabIndex = 1;
            this.btnSelectNone.Text = "None";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnInvertSelect
            // 
            this.btnInvertSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvertSelect.Location = new System.Drawing.Point(138, 0);
            this.btnInvertSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnInvertSelect.Name = "btnInvertSelect";
            this.btnInvertSelect.Size = new System.Drawing.Size(46, 25);
            this.btnInvertSelect.TabIndex = 2;
            this.btnInvertSelect.Text = "Invert";
            this.btnInvertSelect.UseVisualStyleBackColor = true;
            this.btnInvertSelect.Click += new System.EventHandler(this.btnInvertSelect_Click);
            // 
            // btnFilterSelect
            // 
            this.btnFilterSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterSelect.Enabled = false;
            this.btnFilterSelect.Location = new System.Drawing.Point(184, 0);
            this.btnFilterSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilterSelect.Name = "btnFilterSelect";
            this.btnFilterSelect.Size = new System.Drawing.Size(46, 25);
            this.btnFilterSelect.TabIndex = 3;
            this.btnFilterSelect.Text = "FilterS";
            this.btnFilterSelect.UseVisualStyleBackColor = true;
            this.btnFilterSelect.Click += new System.EventHandler(this.btnFilterSelect_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Controls.Add(this.lblTemplateList, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnRunBatch, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.prgBatchProgress, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.dgvBatchLog, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lstTemplateSelect, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.cbWait, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(550, 282);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // lblTemplateList
            // 
            this.lblTemplateList.AutoSize = true;
            this.lblTemplateList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTemplateList.Location = new System.Drawing.Point(0, 0);
            this.lblTemplateList.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemplateList.Name = "lblTemplateList";
            this.lblTemplateList.Size = new System.Drawing.Size(54, 37);
            this.lblTemplateList.TabIndex = 1;
            this.lblTemplateList.Text = "Template:";
            this.lblTemplateList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRunBatch
            // 
            this.btnRunBatch.AutoSize = true;
            this.btnRunBatch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRunBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRunBatch.Location = new System.Drawing.Point(425, 3);
            this.btnRunBatch.Name = "btnRunBatch";
            this.btnRunBatch.Size = new System.Drawing.Size(39, 31);
            this.btnRunBatch.TabIndex = 4;
            this.btnRunBatch.Text = "Start";
            this.btnRunBatch.UseVisualStyleBackColor = true;
            this.btnRunBatch.Click += new System.EventHandler(this.btnRunBatch_Click);
            // 
            // prgBatchProgress
            // 
            this.prgBatchProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgBatchProgress.Location = new System.Drawing.Point(470, 3);
            this.prgBatchProgress.MarqueeAnimationSpeed = 10;
            this.prgBatchProgress.Name = "prgBatchProgress";
            this.prgBatchProgress.Size = new System.Drawing.Size(77, 31);
            this.prgBatchProgress.Step = 1;
            this.prgBatchProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBatchProgress.TabIndex = 3;
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
            this.dgvBatchLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBatchLog.Location = new System.Drawing.Point(3, 40);
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
            this.dgvBatchLog.Size = new System.Drawing.Size(544, 239);
            this.dgvBatchLog.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Command";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 414;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "ExitCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Stdout";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 63;
            // 
            // lstTemplateSelect
            // 
            this.lstTemplateSelect.DataSource = this.bsSelectedTemplate;
            this.lstTemplateSelect.DisplayMember = "Name";
            this.lstTemplateSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTemplateSelect.FormattingEnabled = true;
            this.lstTemplateSelect.Location = new System.Drawing.Point(57, 3);
            this.lstTemplateSelect.Name = "lstTemplateSelect";
            this.lstTemplateSelect.Size = new System.Drawing.Size(323, 21);
            this.lstTemplateSelect.TabIndex = 2;
            this.lstTemplateSelect.ValueMember = "CommandPath";
            // 
            // bsSelectedTemplate
            // 
            this.bsSelectedTemplate.DataMember = "dtCommandTemplates";
            this.bsSelectedTemplate.DataSource = this.dsBatchProgramRunner;
            // 
            // cbWait
            // 
            this.cbWait.AutoSize = true;
            this.cbWait.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbWait.Checked = true;
            this.cbWait.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWait.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbWait.Location = new System.Drawing.Point(386, 3);
            this.cbWait.Name = "cbWait";
            this.cbWait.Size = new System.Drawing.Size(33, 31);
            this.cbWait.TabIndex = 5;
            this.cbWait.Text = "Wait";
            this.cbWait.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblTopTemplateEdit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(781, 319);
            this.splitContainer1.SplitterDistance = 33;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblTopTemplateEdit
            // 
            this.lblTopTemplateEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTopTemplateEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTopTemplateEdit.Location = new System.Drawing.Point(0, 0);
            this.lblTopTemplateEdit.Name = "lblTopTemplateEdit";
            this.lblTopTemplateEdit.Size = new System.Drawing.Size(781, 33);
            this.lblTopTemplateEdit.TabIndex = 0;
            this.lblTopTemplateEdit.Text = "Template Editor";
            this.lblTopTemplateEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scBatchRunnerMgmt
            // 
            this.scBatchRunnerMgmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBatchRunnerMgmt.Location = new System.Drawing.Point(3, 3);
            this.scBatchRunnerMgmt.Name = "scBatchRunnerMgmt";
            this.scBatchRunnerMgmt.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBatchRunnerMgmt.Panel1
            // 
            this.scBatchRunnerMgmt.Panel1.Controls.Add(this.lblTopBatchRunner);
            // 
            // scBatchRunnerMgmt.Panel2
            // 
            this.scBatchRunnerMgmt.Panel2.Controls.Add(this.scBatchRunner);
            this.scBatchRunnerMgmt.Size = new System.Drawing.Size(781, 319);
            this.scBatchRunnerMgmt.SplitterDistance = 33;
            this.scBatchRunnerMgmt.TabIndex = 1;
            // 
            // lblTopBatchRunner
            // 
            this.lblTopBatchRunner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTopBatchRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTopBatchRunner.Location = new System.Drawing.Point(0, 0);
            this.lblTopBatchRunner.Name = "lblTopBatchRunner";
            this.lblTopBatchRunner.Size = new System.Drawing.Size(781, 33);
            this.lblTopBatchRunner.TabIndex = 0;
            this.lblTopBatchRunner.Text = "Batch Runner";
            this.lblTopBatchRunner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTemp);
            this.tabControl1.Controls.Add(this.tpBatchRunner);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 351);
            this.tabControl1.TabIndex = 0;
            // 
            // tpTemp
            // 
            this.tpTemp.Controls.Add(this.splitContainer1);
            this.tpTemp.Location = new System.Drawing.Point(4, 22);
            this.tpTemp.Name = "tpTemp";
            this.tpTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tpTemp.Size = new System.Drawing.Size(787, 325);
            this.tpTemp.TabIndex = 0;
            this.tpTemp.Text = "Templates";
            this.tpTemp.UseVisualStyleBackColor = true;
            // 
            // tpBatchRunner
            // 
            this.tpBatchRunner.Controls.Add(this.scBatchRunnerMgmt);
            this.tpBatchRunner.Location = new System.Drawing.Point(4, 22);
            this.tpBatchRunner.Name = "tpBatchRunner";
            this.tpBatchRunner.Padding = new System.Windows.Forms.Padding(3);
            this.tpBatchRunner.Size = new System.Drawing.Size(787, 325);
            this.tpBatchRunner.TabIndex = 1;
            this.tpBatchRunner.Text = "Batch Runner";
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(805, 361);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Programm Runner";
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

