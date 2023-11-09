using RocketFreight.Classes;
using RocketFreight.Interface;
using RocketFreight.Models;
using RocketFreight.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketFreight.UserControls
{
    public partial class ucUser : UserControl
    {
        private bool IsSearching;
        public int ID { get; set; }
        List<User> results { get; set; } = new List<User>();
        public AppInterface appInterface { get; set; }

        public ucUser()
        {
            InitializeComponent();
            appInterface = new AppInterface();
            tcSearch._TextChanged += TcSearch__TextChanged;

            dgvSearch.Columns.Clear();
            dgvSearch.Columns.Add("Col1", "Id");
            dgvSearch.Columns.Add("Col2", "S/N");
            dgvSearch.Columns.Add("Col3", "Names");
            dgvSearch.Columns.Add("Col4", "Type");
            dgvSearch.Columns.Add("Col5", "Phone");
            dgvSearch.Columns.Add("Col6", "Email");
            dgvSearch.Columns.Add("Col7", "Username");

            dgvSearch.Columns[0].Visible = false;
            //int i = dataGridView1.Columns.Add("Col8", "Edit");
            dgvSearch.Columns.Add(new DataGridViewImageColumn()
            {
                Image = RocketFreight.Properties.Resources.i_pen,
                HeaderText = "Edit"
            });
            //dataGridView1.Columns.Add("Col9", "Delete");
            dgvSearch.Columns.Add(new DataGridViewImageColumn()
            {
                Image = RocketFreight.Properties.Resources.i_clear,
                HeaderText = "Delete"
            });
            dgvSearch.CellDoubleClick += DataGridView1_CellDoubleClick;
            dgvSearch.AllowUserToDeleteRows = true;
            dgvSearch.UserDeletingRow += DataGridView1_UserDeletingRow;

            tcFirstName.txt.KeyPress += Txt_KeyPress;
            tcLastName.txt.KeyPress += Txt_KeyPress;
            tcPhone.txt.KeyPress += Txt_KeyPress;
            tcEmail.txt.KeyPress += Txt_KeyPress;
            tcAddress.txt.KeyPress += Txt_KeyPress;
            tcUsername.txt.KeyPress += Txt_KeyPress;
            tcPassword.txt.KeyPress += Txt_KeyPress;
            tcSearch.txt.KeyPress += TcSearch_KeyPress;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (string.IsNullOrEmpty(tcFirstName.Texts))
                    btnCancel.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
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

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                btnAdd.PerformClick();
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
            var item = await appInterface.GetUser(Convert.ToInt32(row.Cells[0].Value));
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
                if (await appInterface.RemoveUser(item.Id))
                {
                    MessageBox.Show("Item deleted!");
                    dgvSearch.Rows.Remove(row);
                    ID = 0;
                    results = await appInterface.GetUsers();
                }
            }
            else
            {
                ID = item.Id;
                tcFirstName.SetText(item.FirstName);
                tcLastName.SetText(item.LastName);
                tcPhone.SetText(item.Phone);
                tcEmail.SetText(item.Email);
                tcAddress.SetText(item.Address);
                tcPassword.SetText(item.Password);
                tcUsername.SetText(item.Username);
                drpcType.SelectedItem = item.userType;
                //picImage.Image = Statics.ByteArrayToImage(item.ProfileImage);
                tcFirstName.Focus();
                btnAdd.Text = "Update";
            }
        }

        private void TcSearch__TextChanged(object sender, EventArgs e)
        {
            SearchItems();
        }

        private void SearchItems()
        {
            if (ID > 0)
                btnClear.PerformClick();

            try
            {
                var searchStringOld = tcSearch.GetText().ToLower();
                if (IsSearching) return;
                dgvSearch.Columns.Clear();
                int i = 0; IsSearching = true;
                string searchString = tcSearch.GetText().ToLower();

                DataTable dt = new DataTable();
                dt.Columns.Add().ColumnName = "Id";
                dt.Columns.Add().ColumnName = "S/N";
                dt.Columns.Add().ColumnName = "Name";
                dt.Columns.Add().ColumnName = "Type";
                dt.Columns.Add().ColumnName = "Phone";
                dt.Columns.Add().ColumnName = "Email";
                dt.Columns.Add().ColumnName = "Address";
                dt.Columns.Add().ColumnName = "Username";
                //dt.Columns.Add(new DataColumn("View", typeof(Image)));
                foreach (var item in results)
                {
                    if ((item.Username.ToLower().Contains(searchString) ||
                        item.userType.ToString().ToLower().Contains(searchString) ||
                        (item.FirstName != null ? item.FirstName.ToLower().Contains(searchString) : false) ||
                        (item.LastName != null ? item.LastName.ToLower().Contains(searchString) : false) ||
                        (item.Email != null ? item.Email.ToLower().Contains(searchString) : false) ||
                        (item.Phone != null ? item.Phone.ToLower().Contains(searchString) : false) ||
                        (item.Address != null ? item.Address.ToLower().Contains(searchString) : false)
                        ) || string.IsNullOrEmpty(searchString))
                    {
                        dt.Rows.Add();
                        dt.Rows[i][0] = item.Id;
                        dt.Rows[i][1] = i + 1;
                        dt.Rows[i][2] = item.FirstName + " " + item.LastName;
                        dt.Rows[i][3] = item.userType.ToString();
                        dt.Rows[i][4] = item.Phone;
                        dt.Rows[i][5] = item.Email;
                        dt.Rows[i][6] = item.Address;
                        dt.Rows[i][7] = item.Username;
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
                dgvSearch.Columns[0].FillWeight = 10;
                dgvSearch.Columns[0].Visible = false;
                dgvSearch.Columns[1].FillWeight = 7;
                dgvSearch.Columns[2].FillWeight = 40;
                dgvSearch.Columns[3].FillWeight = 15;
                dgvSearch.Columns[4].FillWeight = 35;
                dgvSearch.Columns[5].FillWeight = 20;
                dgvSearch.Columns[6].FillWeight = 20;
                dgvSearch.Columns[7].FillWeight = 20;
                //dgvSearch.Columns[6].FillWeight = 7;
                dgvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tcAddress.Clear();
            tcEmail.Clear();
            tcPhone.Clear();
            tcFirstName.Clear();
            tcLastName.Clear();
            tcUsername.Clear();
            tcPassword.Clear();
            tcFirstName.Focus();
            btnAdd.Text = "&Save";
            picImage.Image = null;
            picImage.ImageLocation = "";
            ID = 0;

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(drpcType.GetText()))
            {
                MessageBox.Show("User's Type must be selected!");
                return;
            }
            if (string.IsNullOrEmpty(tcFirstName.GetText()) || 
                string.IsNullOrEmpty(tcLastName.GetText()) || 
                string.IsNullOrEmpty(tcUsername.GetText()))
            {
                MessageBox.Show("Firstname and Lastname are required!");
                return;
            }
            try
            {
                User user;
                if (ID == 0)
                    user = new User()
                    {
                        Address = tcAddress.GetText(),
                        Email = tcEmail.GetText(),
                        Phone = tcPhone.GetText(),
                        FirstName = tcFirstName.GetText(),
                        LastName = tcLastName.GetText(),
                        Username = tcUsername.GetText(),
                        Password = tcPassword.GetText(),
                        Type = (int)((UserType)drpcType.cmbList.SelectedItem)
                    };
                else
                {
                    user = await appInterface.GetUser(ID);
                    if (user == null) throw new Exception("User not found!");

                    user.Address = tcAddress.GetText();
                    user.Email = tcEmail.GetText();
                    user.Phone = tcPhone.GetText();
                    user.FirstName = tcFirstName.GetText();
                    user.LastName = tcLastName.GetText();
                    user.Username = tcUsername.GetText();
                    user.Password = tcPassword.GetText();
                    user.Type = (int)((UserType)drpcType.cmbList.SelectedItem);
                }
                //if (!string.IsNullOrEmpty(picImage.ImageLocation))
                //    user.ProfileImage =
                //        Statics.ImageToByteArray(Image.FromFile(picImage.ImageLocation));
                if (ID > 0)
                {
                    if (MessageBox.Show("Are you sure to update this item?",
                        "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                    if (await appInterface.UpdateUser(user, ID))
                    {
                        MessageBox.Show("User Updated Successfully!");
                        btnClear.PerformClick();
                    }
                    else
                        MessageBox.Show("Unable to Update User!");
                }
                else
                {
                    if (await appInterface.SaveUser(user))
                    {
                        MessageBox.Show("User Added Successfully!");
                        btnClear.PerformClick();
                    }
                    else
                        MessageBox.Show("Unable to Add User!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Users");
            dt.Columns.Add("S/N");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Type");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");
            dt.Columns.Add("Username");
            //dt.Columns.Add("Password");
            int i = 0;
            foreach (User user in results)
            {
                dt.Rows.Add(i++, user.FirstName, user.LastName,
                    ((UserType)user.userType).ToString(),
                    user.Phone, user.Email, user.Address,
                    user.Username);
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
            DataTable dt = new DataTable("Users");
            dt.Columns.Add("S/N");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Type");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");
            dt.Columns.Add("Username");
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
                            User User = new User()
                            {
                                FirstName = r[1].ToString(),
                                LastName = r[2].ToString(),
                                Type = (int)((UserType)Enum.Parse(typeof(UserType), r[3].ToString())),
                                Phone = r[4].ToString(),
                                Email = r[5].ToString(),
                                Address = r[6].ToString(),
                                Username = r[7].ToString(),
                                //Password = r[6].ToString(),
                            };
                            await appInterface.SaveUser(User);
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

        private void ucUser_Load(object sender, EventArgs e)
        {
            drpcType.Clear();
            drpcType.cmbList.Items.Add(UserType.Staff);
            drpcType.cmbList.Items.Add(UserType.Admin);
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image Files |*.png;*.bmp;*.jpg"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
                picImage.ImageLocation = ofd.FileName;
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            if (picImage.Image != null || !string.IsNullOrEmpty(picImage.ImageLocation))
            {
                Image image = picImage.Image;
                if (image != null)
                    image = Image.FromFile(picImage.ImageLocation);

                ucImage ucImage = new ucImage(image);
                frmDialogue frmDailogue = new frmDialogue();
                frmDailogue.UserControl = ucImage;
                frmDailogue.ShowDialog(this);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            appInterface = new AppInterface();
            results = await appInterface.GetUsers();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SearchItems();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DGVClicked(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DGVClicked(false);
        }
    }
}
