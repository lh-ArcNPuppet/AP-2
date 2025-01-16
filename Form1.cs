using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_2
{
    public partial class Form_Auth : Form
    {
        public Form_Auth()
        {
            InitializeComponent();
            txtBox_pswd.UseSystemPasswordChar = true;
        }

        private void chckBox_ShowPswd_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBox_ShowPswd.Checked)
            {
                txtBox_pswd.UseSystemPasswordChar = false;
            }
            else
            {
                txtBox_pswd.UseSystemPasswordChar = true;
            }
        }
    }
}
