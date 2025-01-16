namespace AP_2
{
    partial class Form_Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Auth));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBox_idInput = new System.Windows.Forms.TextBox();
            this.txtBox_pswd = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chckBox_ShowPswd = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connexion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base de donnée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AP_2.Properties.Resources.login_picture;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtBox_idInput
            // 
            this.txtBox_idInput.Location = new System.Drawing.Point(106, 206);
            this.txtBox_idInput.Name = "txtBox_idInput";
            this.txtBox_idInput.Size = new System.Drawing.Size(211, 20);
            this.txtBox_idInput.TabIndex = 5;
            // 
            // txtBox_pswd
            // 
            this.txtBox_pswd.Location = new System.Drawing.Point(106, 232);
            this.txtBox_pswd.Name = "txtBox_pswd";
            this.txtBox_pswd.Size = new System.Drawing.Size(211, 20);
            this.txtBox_pswd.TabIndex = 6;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(265, 288);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(90, 23);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "Se connecter";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(32, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Veuillez vous authentifier pour vous connecter et accéder à la\r\nbase de donnée.";
            // 
            // chckBox_ShowPswd
            // 
            this.chckBox_ShowPswd.AutoSize = true;
            this.chckBox_ShowPswd.Location = new System.Drawing.Point(109, 255);
            this.chckBox_ShowPswd.Name = "chckBox_ShowPswd";
            this.chckBox_ShowPswd.Size = new System.Drawing.Size(139, 17);
            this.chckBox_ShowPswd.TabIndex = 9;
            this.chckBox_ShowPswd.Text = "Afficher le mot de passe";
            this.chckBox_ShowPswd.UseVisualStyleBackColor = true;
            this.chckBox_ShowPswd.CheckedChanged += new System.EventHandler(this.chckBox_ShowPswd_CheckedChanged);
            // 
            // Form_Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 321);
            this.Controls.Add(this.chckBox_ShowPswd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txtBox_pswd);
            this.Controls.Add(this.txtBox_idInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Auth";
            this.Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBox_idInput;
        private System.Windows.Forms.TextBox txtBox_pswd;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chckBox_ShowPswd;
    }
}

