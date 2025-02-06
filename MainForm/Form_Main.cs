using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_2;

namespace MainForm
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Form_Auth auth = new Form_Auth();
            DialogResult rsds = auth.ShowDialog();
            if (rsds == DialogResult.OK)
            {

            }
            else
            {
                Close();
            }
        }
    }
}
