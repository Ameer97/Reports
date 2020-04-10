namespace Reports
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aormsDataSet = new Reports.AormsDataSet();
            this.colonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colonsTableAdapter = new Reports.AormsDataSetTableAdapters.ColonsTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aormsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.preparationDataGridViewTextBoxColumn,
            this.analInspectionDataGridViewTextBoxColumn,
            this.pRExamDataGridViewTextBoxColumn,
            this.ileumDataGridViewTextBoxColumn,
            this.colonDetailsDataGridViewTextBoxColumn,
            this.rectumDataGridViewTextBoxColumn,
            this.conclusionDataGridViewTextBoxColumn,
            this.assistantDataGridViewTextBoxColumn,
            this.endoscopistDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.colonsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // aormsDataSet
            // 
            this.aormsDataSet.DataSetName = "AormsDataSet";
            this.aormsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colonsBindingSource
            // 
            this.colonsBindingSource.DataMember = "Colons";
            this.colonsBindingSource.DataSource = this.aormsDataSet;
            // 
            // colonsTableAdapter
            // 
            this.colonsTableAdapter.ClearBeforeFill = true;
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
            // preparationDataGridViewTextBoxColumn
            // 
            this.preparationDataGridViewTextBoxColumn.DataPropertyName = "Preparation";
            this.preparationDataGridViewTextBoxColumn.HeaderText = "Preparation";
            this.preparationDataGridViewTextBoxColumn.Name = "preparationDataGridViewTextBoxColumn";
            // 
            // analInspectionDataGridViewTextBoxColumn
            // 
            this.analInspectionDataGridViewTextBoxColumn.DataPropertyName = "AnalInspection";
            this.analInspectionDataGridViewTextBoxColumn.HeaderText = "AnalInspection";
            this.analInspectionDataGridViewTextBoxColumn.Name = "analInspectionDataGridViewTextBoxColumn";
            // 
            // pRExamDataGridViewTextBoxColumn
            // 
            this.pRExamDataGridViewTextBoxColumn.DataPropertyName = "PRExam";
            this.pRExamDataGridViewTextBoxColumn.HeaderText = "PRExam";
            this.pRExamDataGridViewTextBoxColumn.Name = "pRExamDataGridViewTextBoxColumn";
            // 
            // ileumDataGridViewTextBoxColumn
            // 
            this.ileumDataGridViewTextBoxColumn.DataPropertyName = "Ileum";
            this.ileumDataGridViewTextBoxColumn.HeaderText = "Ileum";
            this.ileumDataGridViewTextBoxColumn.Name = "ileumDataGridViewTextBoxColumn";
            // 
            // colonDetailsDataGridViewTextBoxColumn
            // 
            this.colonDetailsDataGridViewTextBoxColumn.DataPropertyName = "ColonDetails";
            this.colonDetailsDataGridViewTextBoxColumn.HeaderText = "ColonDetails";
            this.colonDetailsDataGridViewTextBoxColumn.Name = "colonDetailsDataGridViewTextBoxColumn";
            // 
            // rectumDataGridViewTextBoxColumn
            // 
            this.rectumDataGridViewTextBoxColumn.DataPropertyName = "Rectum";
            this.rectumDataGridViewTextBoxColumn.HeaderText = "Rectum";
            this.rectumDataGridViewTextBoxColumn.Name = "rectumDataGridViewTextBoxColumn";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aormsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AormsDataSet aormsDataSet;
        private System.Windows.Forms.BindingSource colonsBindingSource;
        private AormsDataSetTableAdapters.ColonsTableAdapter colonsTableAdapter;
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

