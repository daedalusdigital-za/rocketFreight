namespace RocketFreight
{
    partial class frmDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDialog));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new CircularProgressBar.CircularProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::RocketFreight.Properties.Resources.i_rectangle_blue;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::RocketFreight.Properties.Resources.back;
            this.btnCancel.Location = new System.Drawing.Point(325, 111);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.Enter += new System.EventHandler(this.btnConfirm_Enter);
            this.btnCancel.Leave += new System.EventHandler(this.btnConfirm_Leave);
            this.btnCancel.MouseEnter += new System.EventHandler(this.frmDialog_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.frmDialog_MouseLeave);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Image = global::RocketFreight.Properties.Resources.correct_24;
            this.btnConfirm.Location = new System.Drawing.Point(207, 111);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 34);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "&Accept";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnConfirm.Enter += new System.EventHandler(this.btnConfirm_Enter);
            this.btnConfirm.Leave += new System.EventHandler(this.btnConfirm_Leave);
            this.btnConfirm.MouseEnter += new System.EventHandler(this.frmDialog_MouseEnter);
            this.btnConfirm.MouseLeave += new System.EventHandler(this.frmDialog_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(11, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(352, 32);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.MouseEnter += new System.EventHandler(this.frmDialog_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.frmDialog_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar1.AnimationSpeed = 500;
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressBar1.InnerMargin = 2;
            this.progressBar1.InnerWidth = -1;
            this.progressBar1.Location = new System.Drawing.Point(368, 3);
            this.progressBar1.MarqueeAnimationSpeed = 2000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.OuterColor = System.Drawing.Color.Gray;
            this.progressBar1.OuterMargin = -5;
            this.progressBar1.OuterWidth = 5;
            this.progressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.ProgressWidth = 5;
            this.progressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBar1.Size = new System.Drawing.Size(57, 56);
            this.progressBar1.StartAngle = 270;
            this.progressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar1.SubscriptText = ".23";
            this.progressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar1.SuperscriptText = "°C";
            this.progressBar1.TabIndex = 18;
            this.progressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBar1.Value = 68;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMessage.Location = new System.Drawing.Point(11, 51);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(360, 58);
            this.lblMessage.TabIndex = 19;
            this.lblMessage.MouseEnter += new System.EventHandler(this.frmDialog_MouseEnter);
            this.lblMessage.MouseLeave += new System.EventHandler(this.frmDialog_MouseLeave);
            // 
            // frmDialog
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(436, 150);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDialog";
            this.MouseEnter += new System.EventHandler(this.frmDialog_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.frmDialog_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar progressBar1;
        private System.Windows.Forms.Label lblMessage;
    }
}