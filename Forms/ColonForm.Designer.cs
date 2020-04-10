namespace Reports.Forms
{
    partial class ColonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.CGender = new System.Windows.Forms.ComboBox();
            this.TEndoscopist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TAssistant = new System.Windows.Forms.TextBox();
            this.CScope = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LAssitant = new System.Windows.Forms.Label();
            this.LConclusion = new System.Windows.Forms.Label();
            this.TConclusion = new System.Windows.Forms.TextBox();
            this.LClinicalData = new System.Windows.Forms.Label();
            this.TClinicalData = new System.Windows.Forms.TextBox();
            this.LReferredDoctor = new System.Windows.Forms.Label();
            this.TReferredDoctor = new System.Windows.Forms.TextBox();
            this.LScope = new System.Windows.Forms.Label();
            this.LPremedication = new System.Windows.Forms.Label();
            this.TPremedication = new System.Windows.Forms.TextBox();
            this.LDate = new System.Windows.Forms.Label();
            this.LFileNo = new System.Windows.Forms.Label();
            this.TFileNo = new System.Windows.Forms.TextBox();
            this.LAge = new System.Windows.Forms.Label();
            this.TAge = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.SpeedColon = new System.Windows.Forms.Button();
            this.CPreparation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LRectumRetroflexion = new System.Windows.Forms.Label();
            this.TRectum = new System.Windows.Forms.TextBox();
            this.LColon = new System.Windows.Forms.Label();
            this.TColon = new System.Windows.Forms.TextBox();
            this.LIleum = new System.Windows.Forms.Label();
            this.TIleum = new System.Windows.Forms.TextBox();
            this.LPRExam = new System.Windows.Forms.Label();
            this.TPRExam = new System.Windows.Forms.TextBox();
            this.LAnalInspection = new System.Windows.Forms.Label();
            this.TAnalInspection = new System.Windows.Forms.TextBox();
            this.LPreparation = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premedicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scopeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referredDoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicalDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analInspectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRExamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ileumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rectumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endoscopistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colonDataSet = new Reports.ColonDataSet();
            this.colonsTableAdapter = new Reports.ColonDataSetTableAdapters.ColonsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 150;
            this.label3.Text = "Gender";
            // 
            // CGender
            // 
            this.CGender.FormattingEnabled = true;
            this.CGender.Location = new System.Drawing.Point(373, 147);
            this.CGender.Name = "CGender";
            this.CGender.Size = new System.Drawing.Size(112, 21);
            this.CGender.TabIndex = 149;
            // 
            // TEndoscopist
            // 
            this.TEndoscopist.Location = new System.Drawing.Point(108, 620);
            this.TEndoscopist.Name = "TEndoscopist";
            this.TEndoscopist.Size = new System.Drawing.Size(379, 20);
            this.TEndoscopist.TabIndex = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 147;
            this.label1.Text = "Endoscopist";
            // 
            // TAssistant
            // 
            this.TAssistant.Location = new System.Drawing.Point(108, 649);
            this.TAssistant.Name = "TAssistant";
            this.TAssistant.Size = new System.Drawing.Size(377, 20);
            this.TAssistant.TabIndex = 146;
            // 
            // CScope
            // 
            this.CScope.FormattingEnabled = true;
            this.CScope.Location = new System.Drawing.Point(324, 91);
            this.CScope.Name = "CScope";
            this.CScope.Size = new System.Drawing.Size(163, 21);
            this.CScope.TabIndex = 145;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 144;
            // 
            // LAssitant
            // 
            this.LAssitant.AutoSize = true;
            this.LAssitant.Location = new System.Drawing.Point(11, 649);
            this.LAssitant.Name = "LAssitant";
            this.LAssitant.Size = new System.Drawing.Size(44, 13);
            this.LAssitant.TabIndex = 143;
            this.LAssitant.Text = "Assitant";
            // 
            // LConclusion
            // 
            this.LConclusion.AutoSize = true;
            this.LConclusion.Location = new System.Drawing.Point(11, 539);
            this.LConclusion.Name = "LConclusion";
            this.LConclusion.Size = new System.Drawing.Size(59, 13);
            this.LConclusion.TabIndex = 142;
            this.LConclusion.Text = "Conclusion";
            // 
            // TConclusion
            // 
            this.TConclusion.Location = new System.Drawing.Point(108, 528);
            this.TConclusion.Multiline = true;
            this.TConclusion.Name = "TConclusion";
            this.TConclusion.Size = new System.Drawing.Size(379, 57);
            this.TConclusion.TabIndex = 141;
            // 
            // LClinicalData
            // 
            this.LClinicalData.AutoSize = true;
            this.LClinicalData.Location = new System.Drawing.Point(11, 187);
            this.LClinicalData.Name = "LClinicalData";
            this.LClinicalData.Size = new System.Drawing.Size(66, 13);
            this.LClinicalData.TabIndex = 140;
            this.LClinicalData.Text = "Clinical Data";
            // 
            // TClinicalData
            // 
            this.TClinicalData.Location = new System.Drawing.Point(108, 180);
            this.TClinicalData.Multiline = true;
            this.TClinicalData.Name = "TClinicalData";
            this.TClinicalData.Size = new System.Drawing.Size(379, 50);
            this.TClinicalData.TabIndex = 139;
            // 
            // LReferredDoctor
            // 
            this.LReferredDoctor.AutoSize = true;
            this.LReferredDoctor.Location = new System.Drawing.Point(227, 123);
            this.LReferredDoctor.Name = "LReferredDoctor";
            this.LReferredDoctor.Size = new System.Drawing.Size(83, 13);
            this.LReferredDoctor.TabIndex = 138;
            this.LReferredDoctor.Text = "Referred Doctor";
            // 
            // TReferredDoctor
            // 
            this.TReferredDoctor.Location = new System.Drawing.Point(324, 119);
            this.TReferredDoctor.Name = "TReferredDoctor";
            this.TReferredDoctor.Size = new System.Drawing.Size(163, 20);
            this.TReferredDoctor.TabIndex = 137;
            // 
            // LScope
            // 
            this.LScope.AutoSize = true;
            this.LScope.Location = new System.Drawing.Point(252, 93);
            this.LScope.Name = "LScope";
            this.LScope.Size = new System.Drawing.Size(38, 13);
            this.LScope.TabIndex = 136;
            this.LScope.Text = "Scope";
            // 
            // LPremedication
            // 
            this.LPremedication.AutoSize = true;
            this.LPremedication.Location = new System.Drawing.Point(227, 67);
            this.LPremedication.Name = "LPremedication";
            this.LPremedication.Size = new System.Drawing.Size(74, 13);
            this.LPremedication.TabIndex = 135;
            this.LPremedication.Text = "Premedication";
            // 
            // TPremedication
            // 
            this.TPremedication.Location = new System.Drawing.Point(324, 63);
            this.TPremedication.Name = "TPremedication";
            this.TPremedication.Size = new System.Drawing.Size(163, 20);
            this.TPremedication.TabIndex = 134;
            // 
            // LDate
            // 
            this.LDate.AutoSize = true;
            this.LDate.Location = new System.Drawing.Point(11, 150);
            this.LDate.Name = "LDate";
            this.LDate.Size = new System.Drawing.Size(30, 13);
            this.LDate.TabIndex = 133;
            this.LDate.Text = "Date";
            // 
            // LFileNo
            // 
            this.LFileNo.AutoSize = true;
            this.LFileNo.Location = new System.Drawing.Point(11, 122);
            this.LFileNo.Name = "LFileNo";
            this.LFileNo.Size = new System.Drawing.Size(40, 13);
            this.LFileNo.TabIndex = 132;
            this.LFileNo.Text = "File No";
            // 
            // TFileNo
            // 
            this.TFileNo.Location = new System.Drawing.Point(108, 119);
            this.TFileNo.Name = "TFileNo";
            this.TFileNo.Size = new System.Drawing.Size(100, 20);
            this.TFileNo.TabIndex = 131;
            // 
            // LAge
            // 
            this.LAge.AutoSize = true;
            this.LAge.Location = new System.Drawing.Point(11, 96);
            this.LAge.Name = "LAge";
            this.LAge.Size = new System.Drawing.Size(26, 13);
            this.LAge.TabIndex = 130;
            this.LAge.Text = "Age";
            // 
            // TAge
            // 
            this.TAge.Location = new System.Drawing.Point(108, 93);
            this.TAge.Name = "TAge";
            this.TAge.Size = new System.Drawing.Size(100, 20);
            this.TAge.TabIndex = 129;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(11, 70);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(35, 13);
            this.LName.TabIndex = 128;
            this.LName.Text = "Name";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(108, 67);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(100, 20);
            this.TName.TabIndex = 127;
            // 
            // SpeedColon
            // 
            this.SpeedColon.Location = new System.Drawing.Point(503, 63);
            this.SpeedColon.Name = "SpeedColon";
            this.SpeedColon.Size = new System.Drawing.Size(65, 62);
            this.SpeedColon.TabIndex = 126;
            this.SpeedColon.Text = "Speed";
            this.SpeedColon.UseVisualStyleBackColor = true;
            this.SpeedColon.Click += new System.EventHandler(this.SpeedColon_Click);
            // 
            // CPreparation
            // 
            this.CPreparation.FormattingEnabled = true;
            this.CPreparation.Location = new System.Drawing.Point(108, 252);
            this.CPreparation.Name = "CPreparation";
            this.CPreparation.Size = new System.Drawing.Size(100, 21);
            this.CPreparation.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 124;
            this.label2.Text = "Colonoscopy";
            // 
            // LRectumRetroflexion
            // 
            this.LRectumRetroflexion.AutoSize = true;
            this.LRectumRetroflexion.Location = new System.Drawing.Point(11, 492);
            this.LRectumRetroflexion.Name = "LRectumRetroflexion";
            this.LRectumRetroflexion.Size = new System.Drawing.Size(44, 13);
            this.LRectumRetroflexion.TabIndex = 122;
            this.LRectumRetroflexion.Text = "Rectum";
            // 
            // TRectum
            // 
            this.TRectum.Location = new System.Drawing.Point(108, 489);
            this.TRectum.Name = "TRectum";
            this.TRectum.Size = new System.Drawing.Size(377, 20);
            this.TRectum.TabIndex = 121;
            // 
            // LColon
            // 
            this.LColon.AutoSize = true;
            this.LColon.Location = new System.Drawing.Point(9, 435);
            this.LColon.Name = "LColon";
            this.LColon.Size = new System.Drawing.Size(34, 13);
            this.LColon.TabIndex = 120;
            this.LColon.Text = "Colon";
            // 
            // TColon
            // 
            this.TColon.Location = new System.Drawing.Point(108, 407);
            this.TColon.Multiline = true;
            this.TColon.Name = "TColon";
            this.TColon.Size = new System.Drawing.Size(377, 63);
            this.TColon.TabIndex = 119;
            // 
            // LIleum
            // 
            this.LIleum.AutoSize = true;
            this.LIleum.Location = new System.Drawing.Point(11, 372);
            this.LIleum.Name = "LIleum";
            this.LIleum.Size = new System.Drawing.Size(32, 13);
            this.LIleum.TabIndex = 118;
            this.LIleum.Text = "Ileum";
            // 
            // TIleum
            // 
            this.TIleum.Location = new System.Drawing.Point(108, 369);
            this.TIleum.Name = "TIleum";
            this.TIleum.Size = new System.Drawing.Size(377, 20);
            this.TIleum.TabIndex = 117;
            // 
            // LPRExam
            // 
            this.LPRExam.AutoSize = true;
            this.LPRExam.Location = new System.Drawing.Point(11, 334);
            this.LPRExam.Name = "LPRExam";
            this.LPRExam.Size = new System.Drawing.Size(48, 13);
            this.LPRExam.TabIndex = 116;
            this.LPRExam.Text = "PRExam";
            // 
            // TPRExam
            // 
            this.TPRExam.Location = new System.Drawing.Point(108, 331);
            this.TPRExam.Name = "TPRExam";
            this.TPRExam.Size = new System.Drawing.Size(377, 20);
            this.TPRExam.TabIndex = 115;
            // 
            // LAnalInspection
            // 
            this.LAnalInspection.AutoSize = true;
            this.LAnalInspection.Location = new System.Drawing.Point(11, 292);
            this.LAnalInspection.Name = "LAnalInspection";
            this.LAnalInspection.Size = new System.Drawing.Size(80, 13);
            this.LAnalInspection.TabIndex = 114;
            this.LAnalInspection.Text = "Anal Inspection";
            // 
            // TAnalInspection
            // 
            this.TAnalInspection.Location = new System.Drawing.Point(108, 289);
            this.TAnalInspection.Name = "TAnalInspection";
            this.TAnalInspection.Size = new System.Drawing.Size(377, 20);
            this.TAnalInspection.TabIndex = 113;
            // 
            // LPreparation
            // 
            this.LPreparation.AutoSize = true;
            this.LPreparation.Location = new System.Drawing.Point(11, 255);
            this.LPreparation.Name = "LPreparation";
            this.LPreparation.Size = new System.Drawing.Size(61, 13);
            this.LPreparation.TabIndex = 112;
            this.LPreparation.Text = "Preparation";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(503, 133);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(65, 62);
            this.Button1.TabIndex = 111;
            this.Button1.Text = "Insert";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.fileNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.premedicationDataGridViewTextBoxColumn,
            this.scopeDataGridViewTextBoxColumn,
            this.referredDoctorDataGridViewTextBoxColumn,
            this.clinicalDataDataGridViewTextBoxColumn,
            this.preparationDataGridViewTextBoxColumn,
            this.analInspectionDataGridViewTextBoxColumn,
            this.pRExamDataGridViewTextBoxColumn,
            this.ileumDataGridViewTextBoxColumn,
            this.colonDetailsDataGridViewTextBoxColumn,
            this.rectumDataGridViewTextBoxColumn,
            this.conclusionDataGridViewTextBoxColumn,
            this.assistantDataGridViewTextBoxColumn,
            this.endoscopistDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.colonsBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(584, 63);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.Size = new System.Drawing.Size(637, 446);
            this.DataGridView1.TabIndex = 151;
            this.DataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileNoDataGridViewTextBoxColumn
            // 
            this.fileNoDataGridViewTextBoxColumn.DataPropertyName = "FileNo";
            this.fileNoDataGridViewTextBoxColumn.HeaderText = "FileNo";
            this.fileNoDataGridViewTextBoxColumn.Name = "fileNoDataGridViewTextBoxColumn";
            this.fileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // premedicationDataGridViewTextBoxColumn
            // 
            this.premedicationDataGridViewTextBoxColumn.DataPropertyName = "Premedication";
            this.premedicationDataGridViewTextBoxColumn.HeaderText = "Premedication";
            this.premedicationDataGridViewTextBoxColumn.Name = "premedicationDataGridViewTextBoxColumn";
            this.premedicationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scopeDataGridViewTextBoxColumn
            // 
            this.scopeDataGridViewTextBoxColumn.DataPropertyName = "Scope";
            this.scopeDataGridViewTextBoxColumn.HeaderText = "Scope";
            this.scopeDataGridViewTextBoxColumn.Name = "scopeDataGridViewTextBoxColumn";
            this.scopeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referredDoctorDataGridViewTextBoxColumn
            // 
            this.referredDoctorDataGridViewTextBoxColumn.DataPropertyName = "ReferredDoctor";
            this.referredDoctorDataGridViewTextBoxColumn.HeaderText = "ReferredDoctor";
            this.referredDoctorDataGridViewTextBoxColumn.Name = "referredDoctorDataGridViewTextBoxColumn";
            this.referredDoctorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clinicalDataDataGridViewTextBoxColumn
            // 
            this.clinicalDataDataGridViewTextBoxColumn.DataPropertyName = "ClinicalData";
            this.clinicalDataDataGridViewTextBoxColumn.HeaderText = "ClinicalData";
            this.clinicalDataDataGridViewTextBoxColumn.Name = "clinicalDataDataGridViewTextBoxColumn";
            this.clinicalDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preparationDataGridViewTextBoxColumn
            // 
            this.preparationDataGridViewTextBoxColumn.DataPropertyName = "Preparation";
            this.preparationDataGridViewTextBoxColumn.HeaderText = "Preparation";
            this.preparationDataGridViewTextBoxColumn.Name = "preparationDataGridViewTextBoxColumn";
            this.preparationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // analInspectionDataGridViewTextBoxColumn
            // 
            this.analInspectionDataGridViewTextBoxColumn.DataPropertyName = "AnalInspection";
            this.analInspectionDataGridViewTextBoxColumn.HeaderText = "AnalInspection";
            this.analInspectionDataGridViewTextBoxColumn.Name = "analInspectionDataGridViewTextBoxColumn";
            this.analInspectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRExamDataGridViewTextBoxColumn
            // 
            this.pRExamDataGridViewTextBoxColumn.DataPropertyName = "PRExam";
            this.pRExamDataGridViewTextBoxColumn.HeaderText = "PRExam";
            this.pRExamDataGridViewTextBoxColumn.Name = "pRExamDataGridViewTextBoxColumn";
            this.pRExamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ileumDataGridViewTextBoxColumn
            // 
            this.ileumDataGridViewTextBoxColumn.DataPropertyName = "Ileum";
            this.ileumDataGridViewTextBoxColumn.HeaderText = "Ileum";
            this.ileumDataGridViewTextBoxColumn.Name = "ileumDataGridViewTextBoxColumn";
            this.ileumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colonDetailsDataGridViewTextBoxColumn
            // 
            this.colonDetailsDataGridViewTextBoxColumn.DataPropertyName = "ColonDetails";
            this.colonDetailsDataGridViewTextBoxColumn.HeaderText = "ColonDetails";
            this.colonDetailsDataGridViewTextBoxColumn.Name = "colonDetailsDataGridViewTextBoxColumn";
            this.colonDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rectumDataGridViewTextBoxColumn
            // 
            this.rectumDataGridViewTextBoxColumn.DataPropertyName = "Rectum";
            this.rectumDataGridViewTextBoxColumn.HeaderText = "Rectum";
            this.rectumDataGridViewTextBoxColumn.Name = "rectumDataGridViewTextBoxColumn";
            this.rectumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conclusionDataGridViewTextBoxColumn
            // 
            this.conclusionDataGridViewTextBoxColumn.DataPropertyName = "Conclusion";
            this.conclusionDataGridViewTextBoxColumn.HeaderText = "Conclusion";
            this.conclusionDataGridViewTextBoxColumn.Name = "conclusionDataGridViewTextBoxColumn";
            this.conclusionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assistantDataGridViewTextBoxColumn
            // 
            this.assistantDataGridViewTextBoxColumn.DataPropertyName = "Assistant";
            this.assistantDataGridViewTextBoxColumn.HeaderText = "Assistant";
            this.assistantDataGridViewTextBoxColumn.Name = "assistantDataGridViewTextBoxColumn";
            this.assistantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endoscopistDataGridViewTextBoxColumn
            // 
            this.endoscopistDataGridViewTextBoxColumn.DataPropertyName = "Endoscopist";
            this.endoscopistDataGridViewTextBoxColumn.HeaderText = "Endoscopist";
            this.endoscopistDataGridViewTextBoxColumn.Name = "endoscopistDataGridViewTextBoxColumn";
            this.endoscopistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colonsBindingSource
            // 
            this.colonsBindingSource.DataMember = "Colons";
            this.colonsBindingSource.DataSource = this.colonDataSet;
            // 
            // colonDataSet
            // 
            this.colonDataSet.DataSetName = "ColonDataSet";
            this.colonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colonsTableAdapter
            // 
            this.colonsTableAdapter.ClearBeforeFill = true;
            // 
            // ColonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 693);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CGender);
            this.Controls.Add(this.TEndoscopist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TAssistant);
            this.Controls.Add(this.CScope);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LAssitant);
            this.Controls.Add(this.LConclusion);
            this.Controls.Add(this.TConclusion);
            this.Controls.Add(this.LClinicalData);
            this.Controls.Add(this.TClinicalData);
            this.Controls.Add(this.LReferredDoctor);
            this.Controls.Add(this.TReferredDoctor);
            this.Controls.Add(this.LScope);
            this.Controls.Add(this.LPremedication);
            this.Controls.Add(this.TPremedication);
            this.Controls.Add(this.LDate);
            this.Controls.Add(this.LFileNo);
            this.Controls.Add(this.TFileNo);
            this.Controls.Add(this.LAge);
            this.Controls.Add(this.TAge);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.SpeedColon);
            this.Controls.Add(this.CPreparation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LRectumRetroflexion);
            this.Controls.Add(this.TRectum);
            this.Controls.Add(this.LColon);
            this.Controls.Add(this.TColon);
            this.Controls.Add(this.LIleum);
            this.Controls.Add(this.TIleum);
            this.Controls.Add(this.LPRExam);
            this.Controls.Add(this.TPRExam);
            this.Controls.Add(this.LAnalInspection);
            this.Controls.Add(this.TAnalInspection);
            this.Controls.Add(this.LPreparation);
            this.Controls.Add(this.Button1);
            this.Name = "ColonForm";
            this.Text = "ColonForm";
            this.Load += new System.EventHandler(this.ColonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CGender;
        private System.Windows.Forms.TextBox TEndoscopist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TAssistant;
        private System.Windows.Forms.ComboBox CScope;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LAssitant;
        private System.Windows.Forms.Label LConclusion;
        private System.Windows.Forms.TextBox TConclusion;
        private System.Windows.Forms.Label LClinicalData;
        private System.Windows.Forms.TextBox TClinicalData;
        private System.Windows.Forms.Label LReferredDoctor;
        private System.Windows.Forms.TextBox TReferredDoctor;
        private System.Windows.Forms.Label LScope;
        private System.Windows.Forms.Label LPremedication;
        private System.Windows.Forms.TextBox TPremedication;
        private System.Windows.Forms.Label LDate;
        private System.Windows.Forms.Label LFileNo;
        private System.Windows.Forms.TextBox TFileNo;
        private System.Windows.Forms.Label LAge;
        private System.Windows.Forms.TextBox TAge;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Button SpeedColon;
        private System.Windows.Forms.ComboBox CPreparation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LRectumRetroflexion;
        private System.Windows.Forms.TextBox TRectum;
        private System.Windows.Forms.Label LColon;
        private System.Windows.Forms.TextBox TColon;
        private System.Windows.Forms.Label LIleum;
        private System.Windows.Forms.TextBox TIleum;
        private System.Windows.Forms.Label LPRExam;
        private System.Windows.Forms.TextBox TPRExam;
        private System.Windows.Forms.Label LAnalInspection;
        private System.Windows.Forms.TextBox TAnalInspection;
        private System.Windows.Forms.Label LPreparation;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private ColonDataSet colonDataSet;
        private System.Windows.Forms.BindingSource colonsBindingSource;
        private ColonDataSetTableAdapters.ColonsTableAdapter colonsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premedicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scopeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referredDoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicalDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn analInspectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRExamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ileumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rectumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endoscopistDataGridViewTextBoxColumn;
    }
}