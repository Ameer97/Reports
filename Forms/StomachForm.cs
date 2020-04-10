using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Reports.Db;
using Reports.Enum;
using Reports.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Reports.Forms
{
    public partial class StomachForm : Form
    {
        public FormsDbContext _context = new FormsDbContext();
        public StomachForm()
        {
            InitializeComponent();
            var ScopeList = new List<string>()
            {
                Scope.Olympus,
                Scope.Pentax,
            };
            CScope.DataSource = ScopeList;

            var GenderList = new List<string>()
            {
                Gender.Male,
                Gender.Female,
            };
            CGender.DataSource = GenderList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Stomach = new Stomach
            {
                Name = TName.Text,
                Age = TAge.Text,
                Gender = CGender.Text,
                FileNo = TFileNo.Text,
                Date = dateTimePicker1.Value,
                Premedication = TPremedication.Text,
                Scope = CScope.Text,
                ReferredDoctor = TReferredDoctor.Text,
                ClinicalData = TClinicalData.Text,
                GEJ = TGEJ.Text,
                Esophagus = TEsophagus.Text,
                StomachDetails = TStomach.Text,
                D1 = TD1.Text,
                D2 = TD2.Text,
                Conclusion = TConclusion.Text,
                Assistant = TAssistant.Text,
                Endoscopist = TEndoscopist.Text,
            };
            _context.Stomaches.Add(Stomach);
            _context.SaveChanges();
            this.stomachesTableAdapter.Fill(this.stomachDataSet.Stomaches);
            string myDir = "Stomach";
            var path = myDir + "\\" + Stomach.Id + "-" + Stomach.Name + ".doc";

            ReportDocument cr = new ReportDocument();
            cr.Load("Stomach.rpt");
            cr.SetParameterValue("@Id", Stomach.Id);
            if (!System.IO.Directory.Exists(myDir))
                System.IO.Directory.CreateDirectory(myDir);
            cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, path);
            Process.Start(path);
        }

        private void SpeedStomache_Click(object sender, EventArgs e)
        {
            SpeedAll();
            TGEJ.Text = Interaction.InputBox("Input GEJ");
            TEsophagus.Text = Interaction.InputBox("Input Esophagus");
            TStomach.Text = Interaction.InputBox("Input Stomach");
            TD1.Text = Interaction.InputBox("Input D1");
            TD2.Text = Interaction.InputBox("Input D2");

            TConclusion.Text = Interaction.InputBox("Input Conclusion");
            TEndoscopist.Text = Interaction.InputBox("Input Endoscopist");
            TAssistant.Text = Interaction.InputBox("Input Assistant");
        }

        void SpeedAll()
        {
            TName.Text = Interaction.InputBox("Input Name");
            TAge.Text = Interaction.InputBox("Input Age");
            TFileNo.Text = Interaction.InputBox("Input File No");
            TPremedication.Text = Interaction.InputBox("Input Premedication");
            TReferredDoctor.Text = Interaction.InputBox("Input Referred Doctor");
            TClinicalData.Text = Interaction.InputBox("Input Clinical Data");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var Row = dataGridView1.SelectedCells[0].RowIndex;
            var Id = dataGridView1.Rows[Row].Cells[0].Value;
            var Name = dataGridView1.Rows[Row].Cells[1].Value;

            string myDir = "Stomach";
            var path = myDir + "\\" + Id + "-" + Name + ".doc";

            if (!System.IO.Directory.Exists(myDir))
                System.IO.Directory.CreateDirectory(myDir);

            ReportDocument cr = new ReportDocument();
            cr.Load("Stomach.rpt");
            cr.SetParameterValue("@Id", Id);
            cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, path);
            Process.Start(path);
        }

        private void StomachForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stomachDataSet.Stomaches' table. You can move, or remove it, as needed.
            this.stomachesTableAdapter.Fill(this.stomachDataSet.Stomaches);

        }
    }
}
