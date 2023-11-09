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
    public partial class ucCheckboxSingle : UserControl
    {
        private bool value = true;

        public ucCheckboxSingle()
        {
            InitializeComponent();
        }

        [Category("Chudisoft")]
        public string TextContent
        {
            get
            {
                return rdbYes.Text;
            }
            set
            {
                rdbYes.Text = value;
            }
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
                    pictureBox1.Image = Properties.Resources.i_checked;
                else
                    pictureBox1.Image = Properties.Resources.i_checked_off;
            }
        }

        private void optionYes_Click(object sender, EventArgs e)
        {
            Value = !Value;
        }
    }
}
