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
    public partial class ColonForm : Form
    {
        public FormsDbContext _context = new FormsDbContext();

        public ColonForm()
        {
            InitializeComponent();
            var PreparationList = new List<string>()
            {
                Preparation.Good,
                Preparation.Fair,
                Preparation.Bad
            };
            CPreparation.DataSource = PreparationList;

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

        private void button1_Click(object sender, EventArgs e)
        {
            var Colon = new Colon
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
                Preparation = CPreparation.Text,
                AnalInspection = TAnalInspection.Text,
                PRExam = TPRExam.Text,
                Ileum = TIleum.Text,
                ColonDetails = TColon.Text,
                Rectum = TRectum.Text,
                Conclusion = TConclusion.Text,
                Assistant = TAssistant.Text,
                Endoscopist = TEndoscopist.Text,
            };

            _context.Colons.Add(Colon);
            _context.SaveChanges();

            
            string myDir = "colon";
            var path = myDir + "\\" + Colon.Id + "-" + Colon.Name + ".doc";

            ReportDocument cr = new ReportDocument();
            cr.Load("Colon.rpt");
            cr.SetParameterValue("@Id", Colon.Id);
            if (!System.IO.Directory.Exists(myDir))
                System.IO.Directory.CreateDirectory(myDir);
            cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, path);
            Process.Start(path);
        }
        
        private void SpeedColon_Click(object sender, EventArgs e)
        {
            SpeedAll();
            TAnalInspection.Text = Interaction.InputBox("Input Anal Inspection");
            TPRExam.Text = Interaction.InputBox("Input PRExam");
            TIleum.Text = Interaction.InputBox("Input Ileum");
            TColon.Text = Interaction.InputBox("Input Colon");
            TRectum.Text = Interaction.InputBox("Input Rectum");

            TConclusion.Text = Interaction.InputBox("Input Conclusion");
            TAssistant.Text = Interaction.InputBox("Input Assistant");
            TEndoscopist.Text = Interaction.InputBox("Input Endoscopist");
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
            
            string myDir = "Colon";
            var path = myDir + "\\" + Id + "-" + Name + ".doc";

            if (!System.IO.Directory.Exists(myDir))
                System.IO.Directory.CreateDirectory(myDir);

            ReportDocument cr = new ReportDocument();
            cr.Load("Colon.rpt");
            cr.SetParameterValue("@Id", Id);
            cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, path);
            Process.Start(path);
        }
    }
}
