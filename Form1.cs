using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Row = dataGridView1.SelectedCells[0].RowIndex;
            var Id = dataGridView1.Rows[Row].Cells[0].Value;
            var Name = dataGridView1.Rows[Row].Cells[1].Value;
            string myDir = "colon";
            //var path = @"colon\" + Id + "-" + Name + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".doc";
            var path = myDir + "\\" + Id + "-" + Name + ".doc";
            if(System.IO.File.Exists(path))
                Process.Start(path);

            else
            {
                ReportDocument cr = new ReportDocument();
                cr.Load("CrystalReport3.rpt");
                cr.SetParameterValue("@Id", Id);
                if (!System.IO.Directory.Exists(myDir))
                    System.IO.Directory.CreateDirectory(myDir);
                cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, path);
                Process.Start(path);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aormsDataSet.Colons' table. You can move, or remove it, as needed.
            this.colonsTableAdapter.Fill(this.aormsDataSet.Colons);

        }
    }
}
