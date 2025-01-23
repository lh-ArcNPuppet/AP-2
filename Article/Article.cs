using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article
{
    public partial class Form_Article : Form
    {
        public Form_Article()
        {
            InitializeComponent();
        }

        private void Form_Article_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try { }
            catch { }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try { }
            catch { }
        }
    }
}
