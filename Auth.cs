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
            string BDD_Name = txtBox_bddName.Text;
            string BDD_Catalogue = txtBox_bddCat.Text;

            if((BDD_Name != "") && (BDD_Catalogue != ""))
            {
                if (DB_Connect.openConnection(BDD_Name, BDD_Catalogue))
                {
                    MessageBox.Show(DB_Connect.afficherConnection(), "Connection réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Echec de la connection au serveur", "Erreur connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtBox_bddName.Clear();
                    //txtBox_bddCat.Clear();
                    failConnection++;
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir le formulaire en entier", "Formulaire incomplet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(failConnection == 5)
            {
                MessageBox.Show("Vous avez échouée à vous connecteur au serveur 5 fois.\nL'application va automatiquement se refermer par mesure de sécurité.", "Trop de tentatives échouées", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        
    }
}
