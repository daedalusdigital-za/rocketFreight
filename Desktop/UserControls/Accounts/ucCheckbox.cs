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
    public partial class ucCheckbox : UserControl
    {
        private bool value = true;

        public ucCheckbox()
        {
            InitializeComponent();
        }

        [Category("Chudisoft")]
        public bool Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                if(value)
                {
                    pictureBox1.Image = Properties.Resources.i_checked;
                    pictureBox2.Image = Properties.Resources.i_checked_off;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.i_checked_off;
                    pictureBox2.Image = Properties.Resources.i_checked;
                }
            }
        }

        private void optionYes_Click(object sender, EventArgs e)
        {
            Value = true;
        }

        private void optionNo_Click(object sender, EventArgs e)
        {
            Value = false;
        }
    }
}
