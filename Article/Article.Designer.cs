namespace Article
{
    partial class Form_Article
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
            this.grpBox_searchArticle = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBox_categorie = new System.Windows.Forms.ComboBox();
            this.cmbBox_fabricant = new System.Windows.Forms.ComboBox();
            this.txtBox_ref = new System.Windows.Forms.TextBox();
            this.txtBox_libelle = new System.Windows.Forms.TextBox();
            this.dgv_article = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numUD_unite = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_dateValid = new System.Windows.Forms.DateTimePicker();
            this.grpBox_searchArticle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_article)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_unite)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_searchArticle
            // 
            this.grpBox_searchArticle.BackColor = System.Drawing.Color.Gold;
            this.grpBox_searchArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpBox_searchArticle.Controls.Add(this.comboBox2);
            this.grpBox_searchArticle.Controls.Add(this.comboBox1);
            this.grpBox_searchArticle.Controls.Add(this.label2);
            this.grpBox_searchArticle.Controls.Add(this.label1);
            this.grpBox_searchArticle.Location = new System.Drawing.Point(0, 0);
            this.grpBox_searchArticle.Name = "grpBox_searchArticle";
            this.grpBox_searchArticle.Size = new System.Drawing.Size(708, 92);
            this.grpBox_searchArticle.TabIndex = 0;
            this.grpBox_searchArticle.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(150, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(230, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recherche par libellé :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche par référence :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Référence :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Unité :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fabricant :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Catégorie :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Libellé :";
            // 
            // cmbBox_categorie
            // 
            this.cmbBox_categorie.FormattingEnabled = true;
            this.cmbBox_categorie.Location = new System.Drawing.Point(103, 168);
            this.cmbBox_categorie.Name = "cmbBox_categorie";
            this.cmbBox_categorie.Size = new System.Drawing.Size(183, 21);
            this.cmbBox_categorie.TabIndex = 6;
            // 
            // cmbBox_fabricant
            // 
            this.cmbBox_fabricant.FormattingEnabled = true;
            this.cmbBox_fabricant.Location = new System.Drawing.Point(103, 200);
            this.cmbBox_fabricant.Name = "cmbBox_fabricant";
            this.cmbBox_fabricant.Size = new System.Drawing.Size(183, 21);
            this.cmbBox_fabricant.TabIndex = 7;
            // 
            // txtBox_ref
            // 
            this.txtBox_ref.Location = new System.Drawing.Point(103, 107);
            this.txtBox_ref.Name = "txtBox_ref";
            this.txtBox_ref.Size = new System.Drawing.Size(147, 20);
            this.txtBox_ref.TabIndex = 9;
            // 
            // txtBox_libelle
            // 
            this.txtBox_libelle.Location = new System.Drawing.Point(103, 136);
            this.txtBox_libelle.Name = "txtBox_libelle";
            this.txtBox_libelle.Size = new System.Drawing.Size(277, 20);
            this.txtBox_libelle.TabIndex = 10;
            // 
            // dgv_article
            // 
            this.dgv_article.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_article.Location = new System.Drawing.Point(394, 107);
            this.dgv_article.Name = "dgv_article";
            this.dgv_article.Size = new System.Drawing.Size(302, 228);
            this.dgv_article.TabIndex = 11;
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::Article.Properties.Resources.trash_2;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(259, 312);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(78, 23);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Image = global::Article.Properties.Resources.save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(152, 312);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 23);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Enregistrer";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::Article.Properties.Resources.x;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(59, 312);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(66, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Article.Properties.Resources.ellipsis;
            this.button1.Location = new System.Drawing.Point(256, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numUD_unite
            // 
            this.numUD_unite.Location = new System.Drawing.Point(103, 232);
            this.numUD_unite.Name = "numUD_unite";
            this.numUD_unite.Size = new System.Drawing.Size(77, 20);
            this.numUD_unite.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Date validité :";
            // 
            // dtp_dateValid
            // 
            this.dtp_dateValid.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateValid.Location = new System.Drawing.Point(103, 262);
            this.dtp_dateValid.Name = "dtp_dateValid";
            this.dtp_dateValid.Size = new System.Drawing.Size(95, 20);
            this.dtp_dateValid.TabIndex = 18;
            // 
            // Form_Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 347);
            this.Controls.Add(this.dtp_dateValid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numUD_unite);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_article);
            this.Controls.Add(this.txtBox_libelle);
            this.Controls.Add(this.txtBox_ref);
            this.Controls.Add(this.cmbBox_fabricant);
            this.Controls.Add(this.cmbBox_categorie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpBox_searchArticle);
            this.Name = "Form_Article";
            this.Text = "Article";
            this.grpBox_searchArticle.ResumeLayout(false);
            this.grpBox_searchArticle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_article)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_unite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_searchArticle;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBox_categorie;
        private System.Windows.Forms.ComboBox cmbBox_fabricant;
        private System.Windows.Forms.TextBox txtBox_ref;
        private System.Windows.Forms.TextBox txtBox_libelle;
        private System.Windows.Forms.DataGridView dgv_article;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.NumericUpDown numUD_unite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_dateValid;
    }
}

