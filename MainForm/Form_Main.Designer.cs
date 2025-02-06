namespace MainForm
{
    partial class Form_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesCatégoriesDarticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesUnitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMulticritèreDeRechercheDunFabricantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMulticritèreDeRechercheDunEnsembleDeDépôtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMulticritèresDesNiveauxDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMulticritèresPourInventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeMulticritèresDesMouvementsDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.donnéesToolStripMenuItem,
            this.paramètresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeMulticritèresDesNiveauxDeStockToolStripMenuItem,
            this.listeMulticritèresPourInventaireToolStripMenuItem,
            this.listeMulticritèresDesMouvementsDeStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // donnéesToolStripMenuItem
            // 
            this.donnéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeMulticritèreDeRechercheDunFabricantToolStripMenuItem,
            this.listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem,
            this.listeMulticritèreDeRechercheDunEnsembleDeDépôtsToolStripMenuItem});
            this.donnéesToolStripMenuItem.Name = "donnéesToolStripMenuItem";
            this.donnéesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.donnéesToolStripMenuItem.Text = "Données";
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesCatégoriesDarticleToolStripMenuItem,
            this.listeDesUnitésToolStripMenuItem});
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // listeDesCatégoriesDarticleToolStripMenuItem
            // 
            this.listeDesCatégoriesDarticleToolStripMenuItem.Name = "listeDesCatégoriesDarticleToolStripMenuItem";
            this.listeDesCatégoriesDarticleToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.listeDesCatégoriesDarticleToolStripMenuItem.Text = "Liste des catégories d’article";
            // 
            // listeDesUnitésToolStripMenuItem
            // 
            this.listeDesUnitésToolStripMenuItem.Name = "listeDesUnitésToolStripMenuItem";
            this.listeDesUnitésToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.listeDesUnitésToolStripMenuItem.Text = "Liste des unités";
            // 
            // listeMulticritèreDeRechercheDunFabricantToolStripMenuItem
            // 
            this.listeMulticritèreDeRechercheDunFabricantToolStripMenuItem.Name = "listeMulticritèreDeRechercheDunFabricantToolStripMenuItem";
            this.listeMulticritèreDeRechercheDunFabricantToolStripMenuItem.Size = new System.Drawing.Size(369, 22);
            this.listeMulticritèreDeRechercheDunFabricantToolStripMenuItem.Text = "Liste multicritère de recherche d’un fabricant";
            // 
            // listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem
            // 
            this.listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem.Name = "listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem";
            this.listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem.Size = new System.Drawing.Size(369, 22);
            this.listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem.Text = "Liste multicritère de recherche d’un ensemble d’articles";
            // 
            // listeMulticritèreDeRechercheDunEnsembleDeDépôtsToolStripMenuItem
            // 
            this.listeMulticritèreDeRechercheDunEnsembleDeDépôtsToolStripMenuItem.Name = "listeMulticritèreDeRechercheDunEnsembleDeDépôtsToolStripMenuItem";
            this.listeMulticritèreDeRechercheDunEnsembleDeDépôtsToolStripMenuItem.Size = new System.Drawing.Size(369, 22);
            this.listeMulticritèreDeRechercheDunEnsembleDeDépôtsToolStripMenuItem.Text = "Liste multicritère de recherche d’un ensemble de dépôts";
            // 
            // listeMulticritèresDesNiveauxDeStockToolStripMenuItem
            // 
            this.listeMulticritèresDesNiveauxDeStockToolStripMenuItem.Name = "listeMulticritèresDesNiveauxDeStockToolStripMenuItem";
            this.listeMulticritèresDesNiveauxDeStockToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.listeMulticritèresDesNiveauxDeStockToolStripMenuItem.Text = "Liste multicritères des niveaux de stock";
            // 
            // listeMulticritèresPourInventaireToolStripMenuItem
            // 
            this.listeMulticritèresPourInventaireToolStripMenuItem.Name = "listeMulticritèresPourInventaireToolStripMenuItem";
            this.listeMulticritèresPourInventaireToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.listeMulticritèresPourInventaireToolStripMenuItem.Text = "Liste multicritères pour inventaire";
            // 
            // listeMulticritèresDesMouvementsDeStockToolStripMenuItem
            // 
            this.listeMulticritèresDesMouvementsDeStockToolStripMenuItem.Name = "listeMulticritèresDesMouvementsDeStockToolStripMenuItem";
            this.listeMulticritèresDesMouvementsDeStockToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.listeMulticritèresDesMouvementsDeStockToolStripMenuItem.Text = "Liste multicritères des mouvements de stock";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMulticritèresDesNiveauxDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMulticritèresPourInventaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMulticritèresDesMouvementsDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMulticritèreDeRechercheDunFabricantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeMulticritèreDeRechercheDunEnsembleDeDépôtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesCatégoriesDarticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesUnitésToolStripMenuItem;
    }
}

