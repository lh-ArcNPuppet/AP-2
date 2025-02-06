using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB_DAL;
using System.Windows.Forms;

namespace AP_2
{
    public partial class Form_Auth : Form
    {
        int failConnection = 0;

        public Form_Auth()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            string idInput = txtBox_id.Text;
            string pswdInput = txtBox_pass.Text;

            if((idInput != "") && (pswdInput != ""))
            {
                if (DB_Connect.openConnection())
                {
                    if (Authentification.checkUser(idInput, pswdInput))
                    {

                    }
                    
                    
                    
                    
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Impossible de se connecter à la base de données", "Erreur connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtBox_bddName.Clear();
                    //txtBox_bddCat.Clear();
                    failConnection++;
                }
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe non renseigné", "Formulaire incomplet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(failConnection == 5)
            {
                MessageBox.Show("Vous avez échouée 5 fois à vous connecter au serveur BDD.\nL'application va automatiquement se refermer par mesure de sécurité.", "Trop de tentatives erronées", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void chk_ShowPswd_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowPswd.Checked)
            {
                txtBox_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txtBox_pass.UseSystemPasswordChar = true;
            }
        }
    }
}
