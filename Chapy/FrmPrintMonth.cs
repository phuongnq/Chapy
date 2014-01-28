using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Chapy
{
    public partial class FrmPrintMonth : Form
    {
        public FrmPrintMonth()
        {
            InitializeComponent();
        }

        private void FrmPrintMonth_Load(object sender, EventArgs e)
        {
            DsPrint dsPrint = new DsPrint();
            DataTable table = dsPrint.DataTable1;

            //add header

            DataRow row_header1 = table.NewRow();
            row_header1["Class"] = "曜日";
            row_header1["Teacher"] = "月";
            row_header1["Day1"] = "火";
            row_header1["Day2"] = "火";
            row_header1["Day3"] = "火";
            row_header1["Day4"] = "火";
            row_header1["Day5"] = "火";
            row_header1["Day6"] = "火";
            row_header1["Day7"] = "火";
            row_header1["Day8"] = "火";
            row_header1["Day9"] = "火";
            row_header1["Day10"] = "火";
            table.Rows.Add(row_header1);

            DataRow row_header2 = table.NewRow();
            row_header2["Class"] = "曜日";
            row_header2["Teacher"] = "行事";
            row_header2["Day1"] = "";
            row_header2["Day2"] = "";
            row_header2["Day3"] = "";
            row_header2["Day4"] = "";
            row_header2["Day5"] = "";
            row_header2["Day6"] = "お誕生会";
            row_header2["Day7"] = "";
            row_header2["Day8"] = "";
            row_header2["Day9"] = "予行演習";
            row_header2["Day10"] = "職員会議";
            table.Rows.Add(row_header2);

             Random a = new Random(9);
            for(int i = 0; i < 10; i++){
                for (int j = 0; j < 4; j++)
                {
                    DataRow row = table.NewRow();
                    row["Class"] = "さくら（0歳" + i.ToString();
                    row["Teacher"] = "斎藤" + a.ToString();
                    row["Day1"] = "早１" + i.ToString();
                    row["Day2"] = "早2" + i.ToString();
                    row["Day3"] = "早3" + i.ToString();
                    row["Day4"] = "早4" + i.ToString();
                    row["Day5"] = "早5" + i.ToString();
                    row["Day6"] = "早6" + i.ToString();
                    row["Day7"] = "早7" + i.ToString();
                    row["Day8"] = "早8" + i.ToString();
                    row["Day9"] = "早9" + i.ToString();
                    row["Day10"] = "早１0" + i.ToString();

                    table.Rows.Add(row);
                }
                
            }


            ReportDataSource rpDataSource = new ReportDataSource("DsPrint", (DataTable) table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rpDataSource);

            reportViewer1.LocalReport.Refresh();
            //reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
