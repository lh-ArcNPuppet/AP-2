namespace ListeArticles
{
    partial class Form_LstArticles
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LstArticles));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_NewArticle = new System.Windows.Forms.Button();
            this.chckBox_orderDesc = new System.Windows.Forms.CheckBox();
            this.cmbBox_searchCat = new System.Windows.Forms.ComboBox();
            this.cmbBox_searchLib = new System.Windows.Forms.ComboBox();
            this.cmbBox_searchDep = new System.Windows.Forms.ComboBox();
            this.cmbBox_searchFab = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche par catégorie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(37, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recherche par fabricant :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(37, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recherche par dépôt :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(37, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recherche par libellé :";
            // 
            // btn_NewArticle
            // 
            this.btn_NewArticle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_NewArticle.Image = ((System.Drawing.Image)(resources.GetObject("btn_NewArticle.Image")));
            this.btn_NewArticle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NewArticle.Location = new System.Drawing.Point(447, 82);
            this.btn_NewArticle.Name = "btn_NewArticle";
            this.btn_NewArticle.Size = new System.Drawing.Size(96, 23);
            this.btn_NewArticle.TabIndex = 4;
            this.btn_NewArticle.Text = "Nouvel article";
            this.btn_NewArticle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NewArticle.UseVisualStyleBackColor = false;
            this.btn_NewArticle.Click += new System.EventHandler(this.btn_NewArticle_Click);
            // 
            // chckBox_orderDesc
            // 
            this.chckBox_orderDesc.AutoSize = true;
            this.chckBox_orderDesc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chckBox_orderDesc.Location = new System.Drawing.Point(449, 10);
            this.chckBox_orderDesc.Name = "chckBox_orderDesc";
            this.chckBox_orderDesc.Size = new System.Drawing.Size(137, 17);
            this.chckBox_orderDesc.TabIndex = 5;
            this.chckBox_orderDesc.Text = "Classement décroissant";
            this.chckBox_orderDesc.UseVisualStyleBackColor = false;
            // 
            // cmbBox_searchCat
            // 
            this.cmbBox_searchCat.FormattingEnabled = true;
            this.cmbBox_searchCat.Location = new System.Drawing.Point(174, 6);
            this.cmbBox_searchCat.Name = "cmbBox_searchCat";
            this.cmbBox_searchCat.Size = new System.Drawing.Size(167, 21);
            this.cmbBox_searchCat.TabIndex = 6;
            // 
            // cmbBox_searchLib
            // 
            this.cmbBox_searchLib.FormattingEnabled = true;
            this.cmbBox_searchLib.Location = new System.Drawing.Point(174, 84);
            this.cmbBox_searchLib.Name = "cmbBox_searchLib";
            this.cmbBox_searchLib.Size = new System.Drawing.Size(248, 21);
            this.cmbBox_searchLib.TabIndex = 7;
            // 
            // cmbBox_searchDep
            // 
            this.cmbBox_searchDep.FormattingEnabled = true;
            this.cmbBox_searchDep.Location = new System.Drawing.Point(174, 57);
            this.cmbBox_searchDep.Name = "cmbBox_searchDep";
            this.cmbBox_searchDep.Size = new System.Drawing.Size(248, 21);
            this.cmbBox_searchDep.TabIndex = 8;
            // 
            // cmbBox_searchFab
            // 
            this.cmbBox_searchFab.FormattingEnabled = true;
            this.cmbBox_searchFab.Location = new System.Drawing.Point(174, 31);
            this.cmbBox_searchFab.Name = "cmbBox_searchFab";
            this.cmbBox_searchFab.Size = new System.Drawing.Size(248, 21);
            this.cmbBox_searchFab.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 297);
            this.dataGridView1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 116);
            this.panel1.TabIndex = 11;
            // 
            // Form_LstArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbBox_searchFab);
            this.Controls.Add(this.cmbBox_searchDep);
            this.Controls.Add(this.cmbBox_searchLib);
            this.Controls.Add(this.cmbBox_searchCat);
            this.Controls.Add(this.chckBox_orderDesc);
            this.Controls.Add(this.btn_NewArticle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_LstArticles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des articles";
            this.Load += new System.EventHandler(this.Form_LstArticles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_NewArticle;
        private System.Windows.Forms.CheckBox chckBox_orderDesc;
        private System.Windows.Forms.ComboBox cmbBox_searchCat;
        private System.Windows.Forms.ComboBox cmbBox_searchLib;
        private System.Windows.Forms.ComboBox cmbBox_searchDep;
        private System.Windows.Forms.ComboBox cmbBox_searchFab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}

