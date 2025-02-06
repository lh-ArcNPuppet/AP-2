using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIB_BLL;
using LIB_DAL;

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
            string valueId = txtBox_ref.Text;
            int res = DB_Connect.supprimer(valueId);
            if (res == 1)
            {
                MessageBox.Show(
                        "Valeur supprimé avec succès.",
                        "Suppession de valeur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                        "Problème rencontré lors de l'exécution de la requête SQL.",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}
