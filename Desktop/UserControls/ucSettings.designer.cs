namespace RocketFreight.UserControls
{
    partial class ucSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropDownControl1 = new RocketFreight.InputControls.DropDownControl();
            this.btnRestoreBackup = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tcConString = new RocketFreight.InputControls.TextBoxControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(193, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patients Record Database Settings";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::RocketFreight.Properties.Resources.dashboard_rec;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dropDownControl1);
            this.panel1.Controls.Add(this.btnRestoreBackup);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tcConString);
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 300);
            this.panel1.TabIndex = 5;
            // 
            // dropDownControl1
            // 
            this.dropDownControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropDownControl1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dropDownControl1.BorderSize = 1;
            this.dropDownControl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dropDownControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dropDownControl1.ForeColor = System.Drawing.Color.DimGray;
            this.dropDownControl1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.dropDownControl1.Items.AddRange(new object[] {
            "SQLite",
            "MySQL",
            "SQL Server"});
            this.dropDownControl1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dropDownControl1.ListTextColor = System.Drawing.Color.Black;
            this.dropDownControl1.Location = new System.Drawing.Point(33, 75);
            this.dropDownControl1.Margin = new System.Windows.Forms.Padding(1);
            this.dropDownControl1.MinimumSize = new System.Drawing.Size(200, 20);
            this.dropDownControl1.Name = "dropDownControl1";
            this.dropDownControl1.Padding = new System.Windows.Forms.Padding(2);
            this.dropDownControl1.Size = new System.Drawing.Size(200, 24);
            this.dropDownControl1.TabIndex = 0;
            this.dropDownControl1.Texts = "";
            this.dropDownControl1.OnSelectedIndexChanged += new System.EventHandler(this.dropDownControl1_OnSelectedIndexChanged);
            // 
            // btnRestoreBackup
            // 
            this.btnRestoreBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestoreBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnRestoreBackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestoreBackup.BackgroundImage")));
            this.btnRestoreBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestoreBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRestoreBackup.FlatAppearance.BorderSize = 0;
            this.btnRestoreBackup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRestoreBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreBackup.ForeColor = System.Drawing.Color.White;
            this.btnRestoreBackup.Image = global::RocketFreight.Properties.Resources.database_administrator_24px;
            this.btnRestoreBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoreBackup.Location = new System.Drawing.Point(400, 73);
            this.btnRestoreBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestoreBackup.Name = "btnRestoreBackup";
            this.btnRestoreBackup.Size = new System.Drawing.Size(153, 33);
            this.btnRestoreBackup.TabIndex = 4;
            this.btnRestoreBackup.Text = "&Restore Backup";
            this.btnRestoreBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestoreBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRestoreBackup.UseVisualStyleBackColor = false;
            this.btnRestoreBackup.Click += new System.EventHandler(this.btnRestoreBackup_Click);
            this.btnRestoreBackup.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnRestoreBackup.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::RocketFreight.Properties.Resources.restart_16px;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(559, 73);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(153, 33);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset To Default";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::RocketFreight.Properties.Resources.i_close;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::RocketFreight.Properties.Resources.i_close;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(395, 245);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Connection String:";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::RocketFreight.Properties.Resources.export_24px;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(243, 245);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(138, 38);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "&Save && Retry";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // tcConString
            // 
            this.tcConString.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tcConString.BackColor = System.Drawing.SystemColors.Window;
            this.tcConString.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tcConString.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tcConString.BorderRadius = 0;
            this.tcConString.BorderSize = 2;
            this.tcConString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcConString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcConString.Location = new System.Drawing.Point(33, 147);
            this.tcConString.Margin = new System.Windows.Forms.Padding(1);
            this.tcConString.Multiline = true;
            this.tcConString.Name = "tcConString";
            this.tcConString.Padding = new System.Windows.Forms.Padding(3);
            this.tcConString.PasswordChar = false;
            this.tcConString.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tcConString.PlaceholderText = "";
            this.tcConString.Size = new System.Drawing.Size(679, 92);
            this.tcConString.TabIndex = 1;
            this.tcConString.Texts = "";
            this.tcConString.UnderlinedStyle = false;
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(771, 319);
            this.Load += new System.EventHandler(this.ucLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private InputControls.TextBoxControl tcConString;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private InputControls.DropDownControl dropDownControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestoreBackup;
    }
}
