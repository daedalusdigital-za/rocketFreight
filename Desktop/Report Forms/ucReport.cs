using Microsoft.Reporting.WinForms;
using RocketFreight.Data;
using RocketFreight.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketFrieght.Report_Forms
{
    public partial class ucReport : UserControl
    {
        public AppInterface appInterface { get; set; }

        public ucReport()
        {
            appInterface = new AppInterface();
            InitializeComponent();
        }

        private void ucReport_Load(object sender, EventArgs e)
        {
        }

        public void PrintReportBarcode(string code, int count)
        {
            try
            {
                ReportDataSet ds = new ReportDataSet();
                DataTable dt = ds.DataTable1;


                BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
                //Image image = barcode.Encode(BarcodeLib.TYPE.UPCA,
                //    product.BarCode, Color.Black, Color.White, 100, 30);
                //
                //for(int i = 0; i < count; i++)
                //    dt.Rows.Add( i + 1, product.BarCode,
                //        Statics.ImageToByteArray(image)
                //    );

                this.rV.Reset();
                rV.ProcessingMode = ProcessingMode.Local;
                this.rV.LocalReport.ReportEmbeddedResource = 
                    "RocketFrieght.Report_Files.BarcodeReport.rdlc";
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                this.rV.LocalReport.DataSources.Clear();
                this.rV.LocalReport.DataSources.Add(rds);

                //this.rV.LocalReport.SetParameters(new List<ReportParameter>(){
                //    new ReportParameter("pName", product.Name)
                //});
                this.rV.LocalReport.Refresh();
                this.rV.RefreshReport();
                if(this.ParentForm != null)
                    this.ParentForm.Activate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
