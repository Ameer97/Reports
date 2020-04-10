namespace Reports.Forms
{
    partial class StomachForm
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
            this.CScope = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.label2 = new System.Windows.Forms.Label();
            this.SpeedStomache = new System.Windows.Forms.Button();
            this.LEsophagus = new System.Windows.Forms.Label();
            this.TEsophagus = new System.Windows.Forms.TextBox();
            this.LD2 = new System.Windows.Forms.Label();
            this.TD2 = new System.Windows.Forms.TextBox();
            this.LD1 = new System.Windows.Forms.Label();
            this.TD1 = new System.Windows.Forms.TextBox();
            this.LStomach = new System.Windows.Forms.Label();
            this.TStomach = new System.Windows.Forms.TextBox();
            this.LGEJ = new System.Windows.Forms.Label();
            this.TGEJ = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TAssistant = new System.Windows.Forms.TextBox();
            this.LAssitant = new System.Windows.Forms.Label();
            this.LConclusion = new System.Windows.Forms.Label();
            this.TConclusion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stomachDataSet = new Reports.StomachDataSet();
            this.stomachesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stomachesTableAdapter = new Reports.StomachDataSetTableAdapters.StomachesTableAdapter();
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
            this.gEJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esophagusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stomachDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endoscopistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stomachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stomachesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 164;
            this.label3.Text = "Gender";
            // 
            // CGender
            // 
            this.CGender.FormattingEnabled = true;
            this.CGender.Location = new System.Drawing.Point(376, 143);
            this.CGender.Name = "CGender";
            this.CGender.Size = new System.Drawing.Size(112, 21);
            this.CGender.TabIndex = 163;
            // 
            // TEndoscopist
            // 
            this.TEndoscopist.Location = new System.Drawing.Point(109, 569);
            this.TEndoscopist.Name = "TEndoscopist";
            this.TEndoscopist.Size = new System.Drawing.Size(379, 20);
            this.TEndoscopist.TabIndex = 162;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 161;
            this.label1.Text = "Endoscopist";
            // 
            // CScope
            // 
            this.CScope.FormattingEnabled = true;
            this.CScope.Location = new System.Drawing.Point(325, 87);
            this.CScope.Name = "CScope";
            this.CScope.Size = new System.Drawing.Size(163, 21);
            this.CScope.TabIndex = 160;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 159;
            // 
            // LClinicalData
            // 
            this.LClinicalData.AutoSize = true;
            this.LClinicalData.Location = new System.Drawing.Point(12, 181);
            this.LClinicalData.Name = "LClinicalData";
            this.LClinicalData.Size = new System.Drawing.Size(66, 13);
            this.LClinicalData.TabIndex = 158;
            this.LClinicalData.Text = "Clinical Data";
            // 
            // TClinicalData
            // 
            this.TClinicalData.Location = new System.Drawing.Point(109, 174);
            this.TClinicalData.Multiline = true;
            this.TClinicalData.Name = "TClinicalData";
            this.TClinicalData.Size = new System.Drawing.Size(379, 50);
            this.TClinicalData.TabIndex = 157;
            // 
            // LReferredDoctor
            // 
            this.LReferredDoctor.AutoSize = true;
            this.LReferredDoctor.Location = new System.Drawing.Point(228, 119);
            this.LReferredDoctor.Name = "LReferredDoctor";
            this.LReferredDoctor.Size = new System.Drawing.Size(83, 13);
            this.LReferredDoctor.TabIndex = 156;
            this.LReferredDoctor.Text = "Referred Doctor";
            // 
            // TReferredDoctor
            // 
            this.TReferredDoctor.Location = new System.Drawing.Point(325, 115);
            this.TReferredDoctor.Name = "TReferredDoctor";
            this.TReferredDoctor.Size = new System.Drawing.Size(163, 20);
            this.TReferredDoctor.TabIndex = 155;
            // 
            // LScope
            // 
            this.LScope.AutoSize = true;
            this.LScope.Location = new System.Drawing.Point(253, 89);
            this.LScope.Name = "LScope";
            this.LScope.Size = new System.Drawing.Size(38, 13);
            this.LScope.TabIndex = 154;
            this.LScope.Text = "Scope";
            // 
            // LPremedication
            // 
            this.LPremedication.AutoSize = true;
            this.LPremedication.Location = new System.Drawing.Point(228, 63);
            this.LPremedication.Name = "LPremedication";
            this.LPremedication.Size = new System.Drawing.Size(74, 13);
            this.LPremedication.TabIndex = 153;
            this.LPremedication.Text = "Premedication";
            // 
            // TPremedication
            // 
            this.TPremedication.Location = new System.Drawing.Point(325, 59);
            this.TPremedication.Name = "TPremedication";
            this.TPremedication.Size = new System.Drawing.Size(163, 20);
            this.TPremedication.TabIndex = 152;
            // 
            // LDate
            // 
            this.LDate.AutoSize = true;
            this.LDate.Location = new System.Drawing.Point(12, 146);
            this.LDate.Name = "LDate";
            this.LDate.Size = new System.Drawing.Size(30, 13);
            this.LDate.TabIndex = 151;
            this.LDate.Text = "Date";
            // 
            // LFileNo
            // 
            this.LFileNo.AutoSize = true;
            this.LFileNo.Location = new System.Drawing.Point(12, 118);
            this.LFileNo.Name = "LFileNo";
            this.LFileNo.Size = new System.Drawing.Size(40, 13);
            this.LFileNo.TabIndex = 150;
            this.LFileNo.Text = "File No";
            // 
            // TFileNo
            // 
            this.TFileNo.Location = new System.Drawing.Point(109, 115);
            this.TFileNo.Name = "TFileNo";
            this.TFileNo.Size = new System.Drawing.Size(100, 20);
            this.TFileNo.TabIndex = 149;
            // 
            // LAge
            // 
            this.LAge.AutoSize = true;
            this.LAge.Location = new System.Drawing.Point(12, 92);
            this.LAge.Name = "LAge";
            this.LAge.Size = new System.Drawing.Size(26, 13);
            this.LAge.TabIndex = 148;
            this.LAge.Text = "Age";
            // 
            // TAge
            // 
            this.TAge.Location = new System.Drawing.Point(109, 89);
            this.TAge.Name = "TAge";
            this.TAge.Size = new System.Drawing.Size(100, 20);
            this.TAge.TabIndex = 147;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(12, 66);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(35, 13);
            this.LName.TabIndex = 146;
            this.LName.Text = "Name";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(109, 63);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(100, 20);
            this.TName.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 144;
            this.label2.Text = "OGD";
            // 
            // SpeedStomache
            // 
            this.SpeedStomache.Location = new System.Drawing.Point(506, 59);
            this.SpeedStomache.Name = "SpeedStomache";
            this.SpeedStomache.Size = new System.Drawing.Size(67, 57);
            this.SpeedStomache.TabIndex = 143;
            this.SpeedStomache.Text = "Speed";
            this.SpeedStomache.UseVisualStyleBackColor = true;
            // 
            // LEsophagus
            // 
            this.LEsophagus.AutoSize = true;
            this.LEsophagus.Location = new System.Drawing.Point(12, 271);
            this.LEsophagus.Name = "LEsophagus";
            this.LEsophagus.Size = new System.Drawing.Size(60, 13);
            this.LEsophagus.TabIndex = 142;
            this.LEsophagus.Text = "Esophagus";
            // 
            // TEsophagus
            // 
            this.TEsophagus.Location = new System.Drawing.Point(109, 264);
            this.TEsophagus.Name = "TEsophagus";
            this.TEsophagus.Size = new System.Drawing.Size(379, 20);
            this.TEsophagus.TabIndex = 141;
            // 
            // LD2
            // 
            this.LD2.AutoSize = true;
            this.LD2.Location = new System.Drawing.Point(12, 441);
            this.LD2.Name = "LD2";
            this.LD2.Size = new System.Drawing.Size(21, 13);
            this.LD2.TabIndex = 139;
            this.LD2.Text = "D2";
            // 
            // TD2
            // 
            this.TD2.Location = new System.Drawing.Point(109, 438);
            this.TD2.Name = "TD2";
            this.TD2.Size = new System.Drawing.Size(379, 20);
            this.TD2.TabIndex = 138;
            // 
            // LD1
            // 
            this.LD1.AutoSize = true;
            this.LD1.Location = new System.Drawing.Point(12, 400);
            this.LD1.Name = "LD1";
            this.LD1.Size = new System.Drawing.Size(21, 13);
            this.LD1.TabIndex = 137;
            this.LD1.Text = "D1";
            // 
            // TD1
            // 
            this.TD1.Location = new System.Drawing.Point(109, 383);
            this.TD1.Multiline = true;
            this.TD1.Name = "TD1";
            this.TD1.Size = new System.Drawing.Size(379, 41);
            this.TD1.TabIndex = 136;
            // 
            // LStomach
            // 
            this.LStomach.AutoSize = true;
            this.LStomach.Location = new System.Drawing.Point(12, 318);
            this.LStomach.Name = "LStomach";
            this.LStomach.Size = new System.Drawing.Size(49, 13);
            this.LStomach.TabIndex = 135;
            this.LStomach.Text = "Stomach";
            // 
            // TStomach
            // 
            this.TStomach.Location = new System.Drawing.Point(109, 298);
            this.TStomach.Multiline = true;
            this.TStomach.Name = "TStomach";
            this.TStomach.Size = new System.Drawing.Size(379, 61);
            this.TStomach.TabIndex = 134;
            // 
            // LGEJ
            // 
            this.LGEJ.AutoSize = true;
            this.LGEJ.Location = new System.Drawing.Point(12, 240);
            this.LGEJ.Name = "LGEJ";
            this.LGEJ.Size = new System.Drawing.Size(27, 13);
            this.LGEJ.TabIndex = 133;
            this.LGEJ.Text = "GEJ";
            // 
            // TGEJ
            // 
            this.TGEJ.Location = new System.Drawing.Point(109, 233);
            this.TGEJ.Name = "TGEJ";
            this.TGEJ.Size = new System.Drawing.Size(379, 20);
            this.TGEJ.TabIndex = 132;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 57);
            this.button2.TabIndex = 131;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TAssistant
            // 
            this.TAssistant.Location = new System.Drawing.Point(109, 598);
            this.TAssistant.Name = "TAssistant";
            this.TAssistant.Size = new System.Drawing.Size(379, 20);
            this.TAssistant.TabIndex = 130;
            // 
            // LAssitant
            // 
            this.LAssitant.AutoSize = true;
            this.LAssitant.Location = new System.Drawing.Point(12, 598);
            this.LAssitant.Name = "LAssitant";
            this.LAssitant.Size = new System.Drawing.Size(44, 13);
            this.LAssitant.TabIndex = 129;
            this.LAssitant.Text = "Assitant";
            // 
            // LConclusion
            // 
            this.LConclusion.AutoSize = true;
            this.LConclusion.Location = new System.Drawing.Point(12, 510);
            this.LConclusion.Name = "LConclusion";
            this.LConclusion.Size = new System.Drawing.Size(59, 13);
            this.LConclusion.TabIndex = 128;
            this.LConclusion.Text = "Conclusion";
            // 
            // TConclusion
            // 
            this.TConclusion.Location = new System.Drawing.Point(109, 499);
            this.TConclusion.Multiline = true;
            this.TConclusion.Name = "TConclusion";
            this.TConclusion.Size = new System.Drawing.Size(381, 57);
            this.TConclusion.TabIndex = 127;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.gEJDataGridViewTextBoxColumn,
            this.esophagusDataGridViewTextBoxColumn,
            this.stomachDetailsDataGridViewTextBoxColumn,
            this.d1DataGridViewTextBoxColumn,
            this.d2DataGridViewTextBoxColumn,
            this.conclusionDataGridViewTextBoxColumn,
            this.assistantDataGridViewTextBoxColumn,
            this.endoscopistDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stomachesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(588, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 399);
            this.dataGridView1.TabIndex = 165;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // stomachDataSet
            // 
            this.stomachDataSet.DataSetName = "StomachDataSet";
            this.stomachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stomachesBindingSource
            // 
            this.stomachesBindingSource.DataMember = "Stomaches";
            this.stomachesBindingSource.DataSource = this.stomachDataSet;
            // 
            // stomachesTableAdapter
            // 
            this.stomachesTableAdapter.ClearBeforeFill = true;
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
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // fileNoDataGridViewTextBoxColumn
            // 
            this.fileNoDataGridViewTextBoxColumn.DataPropertyName = "FileNo";
            this.fileNoDataGridViewTextBoxColumn.HeaderText = "FileNo";
            this.fileNoDataGridViewTextBoxColumn.Name = "fileNoDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // premedicationDataGridViewTextBoxColumn
            // 
            this.premedicationDataGridViewTextBoxColumn.DataPropertyName = "Premedication";
            this.premedicationDataGridViewTextBoxColumn.HeaderText = "Premedication";
            this.premedicationDataGridViewTextBoxColumn.Name = "premedicationDataGridViewTextBoxColumn";
            // 
            // scopeDataGridViewTextBoxColumn
            // 
            this.scopeDataGridViewTextBoxColumn.DataPropertyName = "Scope";
            this.scopeDataGridViewTextBoxColumn.HeaderText = "Scope";
            this.scopeDataGridViewTextBoxColumn.Name = "scopeDataGridViewTextBoxColumn";
            // 
            // referredDoctorDataGridViewTextBoxColumn
            // 
            this.referredDoctorDataGridViewTextBoxColumn.DataPropertyName = "ReferredDoctor";
            this.referredDoctorDataGridViewTextBoxColumn.HeaderText = "ReferredDoctor";
            this.referredDoctorDataGridViewTextBoxColumn.Name = "referredDoctorDataGridViewTextBoxColumn";
            // 
            // clinicalDataDataGridViewTextBoxColumn
            // 
            this.clinicalDataDataGridViewTextBoxColumn.DataPropertyName = "ClinicalData";
            this.clinicalDataDataGridViewTextBoxColumn.HeaderText = "ClinicalData";
            this.clinicalDataDataGridViewTextBoxColumn.Name = "clinicalDataDataGridViewTextBoxColumn";
            // 
            // gEJDataGridViewTextBoxColumn
            // 
            this.gEJDataGridViewTextBoxColumn.DataPropertyName = "GEJ";
            this.gEJDataGridViewTextBoxColumn.HeaderText = "GEJ";
            this.gEJDataGridViewTextBoxColumn.Name = "gEJDataGridViewTextBoxColumn";
            // 
            // esophagusDataGridViewTextBoxColumn
            // 
            this.esophagusDataGridViewTextBoxColumn.DataPropertyName = "Esophagus";
            this.esophagusDataGridViewTextBoxColumn.HeaderText = "Esophagus";
            this.esophagusDataGridViewTextBoxColumn.Name = "esophagusDataGridViewTextBoxColumn";
            // 
            // stomachDetailsDataGridViewTextBoxColumn
            // 
            this.stomachDetailsDataGridViewTextBoxColumn.DataPropertyName = "StomachDetails";
            this.stomachDetailsDataGridViewTextBoxColumn.HeaderText = "StomachDetails";
            this.stomachDetailsDataGridViewTextBoxColumn.Name = "stomachDetailsDataGridViewTextBoxColumn";
            // 
            // d1DataGridViewTextBoxColumn
            // 
            this.d1DataGridViewTextBoxColumn.DataPropertyName = "D1";
            this.d1DataGridViewTextBoxColumn.HeaderText = "D1";
            this.d1DataGridViewTextBoxColumn.Name = "d1DataGridViewTextBoxColumn";
            // 
            // d2DataGridViewTextBoxColumn
            // 
            this.d2DataGridViewTextBoxColumn.DataPropertyName = "D2";
            this.d2DataGridViewTextBoxColumn.HeaderText = "D2";
            this.d2DataGridViewTextBoxColumn.Name = "d2DataGridViewTextBoxColumn";
            // 
            // conclusionDataGridViewTextBoxColumn
            // 
            this.conclusionDataGridViewTextBoxColumn.DataPropertyName = "Conclusion";
            this.conclusionDataGridViewTextBoxColumn.HeaderText = "Conclusion";
            this.conclusionDataGridViewTextBoxColumn.Name = "conclusionDataGridViewTextBoxColumn";
            // 
            // assistantDataGridViewTextBoxColumn
            // 
            this.assistantDataGridViewTextBoxColumn.DataPropertyName = "Assistant";
            this.assistantDataGridViewTextBoxColumn.HeaderText = "Assistant";
            this.assistantDataGridViewTextBoxColumn.Name = "assistantDataGridViewTextBoxColumn";
            // 
            // endoscopistDataGridViewTextBoxColumn
            // 
            this.endoscopistDataGridViewTextBoxColumn.DataPropertyName = "Endoscopist";
            this.endoscopistDataGridViewTextBoxColumn.HeaderText = "Endoscopist";
            this.endoscopistDataGridViewTextBoxColumn.Name = "endoscopistDataGridViewTextBoxColumn";
            // 
            // StomachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 629);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CGender);
            this.Controls.Add(this.TEndoscopist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CScope);
            this.Controls.Add(this.dateTimePicker1);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpeedStomache);
            this.Controls.Add(this.LEsophagus);
            this.Controls.Add(this.TEsophagus);
            this.Controls.Add(this.LD2);
            this.Controls.Add(this.TD2);
            this.Controls.Add(this.LD1);
            this.Controls.Add(this.TD1);
            this.Controls.Add(this.LStomach);
            this.Controls.Add(this.TStomach);
            this.Controls.Add(this.LGEJ);
            this.Controls.Add(this.TGEJ);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TAssistant);
            this.Controls.Add(this.LAssitant);
            this.Controls.Add(this.LConclusion);
            this.Controls.Add(this.TConclusion);
            this.Name = "StomachForm";
            this.Text = "StomachForm";
            this.Load += new System.EventHandler(this.StomachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stomachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stomachesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CGender;
        private System.Windows.Forms.TextBox TEndoscopist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CScope;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SpeedStomache;
        private System.Windows.Forms.Label LEsophagus;
        private System.Windows.Forms.TextBox TEsophagus;
        private System.Windows.Forms.Label LD2;
        private System.Windows.Forms.TextBox TD2;
        private System.Windows.Forms.Label LD1;
        private System.Windows.Forms.TextBox TD1;
        private System.Windows.Forms.Label LStomach;
        private System.Windows.Forms.TextBox TStomach;
        private System.Windows.Forms.Label LGEJ;
        private System.Windows.Forms.TextBox TGEJ;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TAssistant;
        private System.Windows.Forms.Label LAssitant;
        private System.Windows.Forms.Label LConclusion;
        private System.Windows.Forms.TextBox TConclusion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StomachDataSet stomachDataSet;
        private System.Windows.Forms.BindingSource stomachesBindingSource;
        private StomachDataSetTableAdapters.StomachesTableAdapter stomachesTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn gEJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esophagusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stomachDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endoscopistDataGridViewTextBoxColumn;
    }
}