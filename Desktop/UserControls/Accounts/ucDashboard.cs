using DocumentFormat.OpenXml.Office2010.Excel;
using RocketFreight.Classes;
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

namespace RocketFreight.UserControls.Accounts
{
    public partial class ucDashboard : UserControl
    {
        private bool IsSearching;
        public AppInterface appInterface { get; set; }
        List<Patient> results = new List<Patient>();
        private string filterBy = "";

        public ucDashboard()
        {
            InitializeComponent();
        }


        private void LoadPageData()
        {
            tcSearch._TextChanged += TcSearch__TextChanged;

            dgvSearch.Columns.Clear();
            dgvSearch.Columns.Add("Col1", "Id");
            dgvSearch.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.i_user,
                HeaderText = ""
            });
            dgvSearch.Columns.Add("Col3", "Patient");
            dgvSearch.Columns.Add("Col4", "Mobile");
            dgvSearch.Columns.Add("Col5", "Gender");

            dgvSearch.Columns[0].Visible = false;
            //int i = dataGridView1.Columns.Add("Col8", "Edit");
            //dgvSearch.Columns.Add(new DataGridViewImageColumn()
            //{
            //    Image = Properties.Resources.edit,
            //    HeaderText = "Edit"
            //});
            //dataGridView1.Columns.Add("Col9", "Delete");
            dgvSearch.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.i_clear,
                HeaderText = "Delete"
            });
            dgvSearch.CellDoubleClick += DataGridView1_CellDoubleClick;
            dgvSearch.AllowUserToDeleteRows = true;
            dgvSearch.UserDeletingRow += DataGridView1_UserDeletingRow;

            tcSearch.txt.KeyPress += TcSearch_KeyPress;
        }

        private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            DGVClicked(false);
        }

        private void TcSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                SearchItems();
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DGVClicked(true);
            }
        }

        private async void DGVClicked(bool edit)
        {
            var row = dgvSearch.CurrentRow;
            if (row == null) return;
            var item = await appInterface.GetPatient(
                Convert.ToInt32(row.Cells[0].Value));
            if (item == null)
            {
                MessageBox.Show("Item no longer exist in the database!");
                return;
            }
            if (!edit)
            {
                if (MessageBox.Show("Are you sure to delete this item?",
                    "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                if (await appInterface.RemovePatient(item.Id))
                {
                    MessageBox.Show("Item deleted!");
                    dgvSearch.Rows.Remove(row);
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                frmDialogue frm = new frmDialogue();
                frm = new frmDialogue() { UserControl = new ucPatientForm(item.Id) };
                frm.ShowDialog();
            }

        }

        private void TcSearch__TextChanged(object sender, EventArgs e)
        {
            SearchItems();
        }

        private void SearchItems()
        {
            try
            {
                var searchStringOld = tcSearch.GetText().ToLower();
                if (IsSearching) return;
                dgvSearch.Columns.Clear();
                int i = 0; IsSearching = true;
                string searchString = tcSearch.GetText().ToLower();

                DataTable dt = new DataTable();
                dt.Columns.Add().ColumnName = "Id";
                //dt.Columns.Add().ColumnName = "";
                dt.Columns.Add(new DataColumn("View", typeof(Image)));
                dt.Columns.Add().ColumnName = "Patient";
                dt.Columns.Add().ColumnName = "Mobile";
                dt.Columns.Add().ColumnName = "Gender";
                foreach (var item in results)
                {
                    if (!string.IsNullOrEmpty(filterBy) && item.Gender != filterBy) continue;

                    if ((item.Name.ToLower().Contains(searchString) ||
                        //(item.Gender != null ? item.Gender.ToLower().Contains(searchString) : false) ||
                        (item.Mobile != null ? item.Mobile.ToLower().Contains(searchString) : false) ||
                        (item.Address != null ? item.Address.ToLower().Contains(searchString) : false)
                        ) || string.IsNullOrEmpty(searchString))
                    {
                        dt.Rows.Add();
                        dt.Rows[i][0] = item.Id;
                        dt.Rows[i][1] = string.IsNullOrEmpty(item.Image) ? 
                            Properties.Resources.i_user : Image.FromFile(item.Image);
                        dt.Rows[i][2] = item.Name;
                        dt.Rows[i][3] = item.Mobile;
                        dt.Rows[i][4] = item.Gender;
                        //dt.Rows[i][6] = Properties.Resources.increase_24px;
                        if (searchString != searchStringOld) break;
                        i++;
                    }
                }
                IsSearching = false;
                if (searchString != searchStringOld)
                {
                    SearchItems(); return;
                }
                dgvSearch.DataSource = dt;
                dgvSearch.Columns[0].Visible = false;
                dgvSearch.Columns[1].FillWeight = 10;
                dgvSearch.Columns[2].FillWeight = 40;
                dgvSearch.Columns[3].FillWeight = 20;
                dgvSearch.Columns[4].FillWeight = 15;
                //dgvSearch.Columns[5].FillWeight = 15;
                //dgvSearch.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Patients");
            dt.Columns.Add("S/N");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");
            dt.Columns.Add("Balance");
            dt.Columns.Add("CreditAllowanceDays");
            foreach (DataGridViewRow r in dgvSearch.Rows)
            {
                dt.Rows.Add(r.Cells[1].Value, r.Cells[2].Value,
                    r.Cells[3].Value, r.Cells[4].Value,
                    r.Cells[5].Value,
                    r.Cells[7].Value
                );
            }
            if (dt.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx|XML Files (*.xml)|*.xml"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (sfd.FileName.EndsWith(".xml"))
                            dt.WriteXml(sfd.FileName, XmlWriteMode.WriteSchema);
                        else
                            new ExcelHandler().ExportTable(dt, sfd.FileName);
                        MessageBox.Show("List Exported!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Patients");
            dt.Columns.Add("S/N");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");
            dt.Columns.Add("Balance");
            dt.Columns.Add("CreditAllowanceDays");
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx|XML Files (*.xml)|*.xml"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (ofd.FileName.EndsWith(".xml"))
                        dt.ReadXml(ofd.FileName);
                    else
                        new ExcelHandler().ImportTable(dt, ofd.FileName);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            Patient patient = new Patient()
                            {
                                Name = r[1].ToString(),
                                Mobile = r[2].ToString(),
                                Email = r[3].ToString(),
                                Address = r[4].ToString(),
                            };
                            await appInterface.SavePatient(patient);
                        }
                        MessageBox.Show("List Imported!");
                        SearchItems();
                    }
                    else
                    {
                        MessageBox.Show("No List To Import!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ucPatient_Load(object sender, EventArgs e)
        {
            LoadPageData();
            backgroundWorker1.RunWorkerAsync();
            dgvSearch.Focus();
        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Statics.MainForm == null) return;

            appInterface = new AppInterface();
            results = await appInterface.GetPatients();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SearchItems();
            lblFemaleCount.Text = results.Count(x => x.Gender == "Female").ToString();
            lblMaleCount.Text = results.Count(x => x.Gender == "Male").ToString();
            lblTotalCount.Text = results.Count().ToString();
        }

        private void picFemales_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            filterBy = pic.Tag.ToString();
            SearchItems();
        }

        private void picNewPatient_Click(object sender, EventArgs e)
        {
            frmDialogue frm = new frmDialogue();
            frm = new frmDialogue() { UserControl = new ucPatientForm() };
            frm.ShowDialog();
        }

        private void bfbtnLogout_Click(object sender, EventArgs e)
        {
            Statics.MainForm.ConfirmClose();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            SearchItems();
        }
    }
}
