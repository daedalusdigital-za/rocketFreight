using RocketFreight.Models;
using RocketFreight.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;
using System.Security.Cryptography;
using System.Drawing.Imaging;
using RocketFrieght.Report_Forms;

namespace RocketFreight.Classes
{
    public static class Statics
    {
        internal static int maxProgressValue = 100;
        internal static int currentProgressValue;
        internal static int CurrentShift;
        internal static bool cancelProgress;
        public static User user { get; set; }
        public static frmMain MainForm { get; set; }
        public static string AppTitle { get { return "Rocket Freight"; } }


        private static frmDialogue reportDailogue;
        public static frmDialogue ReportDailogue
        {
            get {
                if (reportDailogue == null)
                {
                    reportDailogue = new frmDialogue();
                    reportDailogue.UserControl = new ucReport();
                    reportDailogue.isReporting = true;
                }
                return reportDailogue;
            }
            set { reportDailogue = value; }
        }

        public static int BranchRefLength = 6;
        public static int SalesRefLength = 8;
        public static int PurchaseRefLength = 7;
        internal static bool isMainFormClosing = false;

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn, bool png = false)
        {
            if (imageIn == null) return null;

            using (var ms = new MemoryStream())
            {
                if (png)
                    imageIn.Save(ms, ImageFormat.Png);
                else
                    imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null)
                return null;
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static string GetImageString(Image image)
        {
            var base64 = string.Empty;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                base64 = Convert.ToBase64String(ms.ToArray());
            }
            return base64;
        }

        public static string GetException(Exception ex){
            string message = "Unable to proceed due to:" + Environment.NewLine + ex.Message;
            return ex.InnerException == null ? message : GetException(ex.InnerException);
        }
        public static string GetDatabaseName(){
            if (Properties.Settings.Default.DBType == "MySQL")
            {
                string DBName = "";
                DBName = Properties.Settings.Default.ConStringMySql;
                int dbNameIndex = DBName.IndexOf("database=") + 9;
                DBName = DBName.Substring(dbNameIndex, DBName.Length - dbNameIndex);
                if (DBName.Contains(";"))
                {
                    dbNameIndex = DBName.IndexOf(";");
                    DBName = DBName.Substring(0, dbNameIndex);
                }
                return DBName;
            }
            else
            {
                System.Data.SqlClient.SqlConnectionStringBuilder builder =
                    new System.Data.SqlClient.SqlConnectionStringBuilder(
                        Properties.Settings.Default.ConStringSQLServer
                );

                string server = builder.DataSource;
                string database = builder.InitialCatalog;
                return database;
            }
        }

        public static string Crypt(this string text)
        {
            return Convert.ToBase64String(
                ProtectedData.Protect(
                    Encoding.Unicode.GetBytes(text), null, DataProtectionScope.CurrentUser));
        }

        public static string Decrypt(this string text)
        {
            return Encoding.Unicode.GetString(
                ProtectedData.Unprotect(
                     Convert.FromBase64String(text), null, DataProtectionScope.CurrentUser));
        }

        internal static void SetGridHeight(UserControl userControl, Control tcSearch, DataGridView dgvSearch)
        {
            int tCount = dgvSearch.Rows.Count + 2;
            if (tCount > 2)
            {
                int maxHeight = userControl.Height - tcSearch.Location.Y - tcSearch.Height + 5;
                tCount *= dgvSearch.Rows[0].Height;
                dgvSearch.Height = tCount >= maxHeight ? maxHeight : tCount;
            }
        }

        internal static void CloseNotifier(object sender, EventArgs e)
        {
            var thisIcon = (NotifyIcon)sender;
            thisIcon.Visible = false;
            thisIcon.Dispose();
        }

    }
}
