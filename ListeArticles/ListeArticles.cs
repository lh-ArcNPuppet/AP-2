using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Article;
using LIB_DAL;
using LIB_BLL;

namespace ListeArticles
{
    public partial class Form_LstArticles : Form
    {
        public Form_LstArticles()
        {
            InitializeComponent();
        }

        private void Form_LstArticles_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_NewArticle_Click(object sender, EventArgs e)
        {
            Form_Article form_Article = new Form_Article();
            form_Article.ShowDialog();
        }
        public void refreshDGV()
        {
            try
            {
                
            }
        }
    }
}
