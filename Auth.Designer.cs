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
            this.txtBox_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBox_pass = new System.Windows.Forms.TextBox();
            this.chk_ShowPswd = new System.Windows.Forms.CheckBox();
            this.lbl_ForgotPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connexion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base de donnée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identifiant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe :";
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(117, 179);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(211, 20);
            this.txtBox_id.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(35, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Veuillez vous authentifier pour vous connecter et accéder à la\r\nbase de donnée.";
            // 
            // btn_connect
            // 
            this.btn_connect.Image = global::AP_2.Properties.Resources.log_in;
            this.btn_connect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_connect.Location = new System.Drawing.Point(261, 263);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(94, 23);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "Se connecter";
            this.btn_connect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AP_2.Properties.Resources.login_picture;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtBox_pass
            // 
            this.txtBox_pass.Location = new System.Drawing.Point(117, 205);
            this.txtBox_pass.Name = "txtBox_pass";
            this.txtBox_pass.Size = new System.Drawing.Size(211, 20);
            this.txtBox_pass.TabIndex = 10;
            this.txtBox_pass.UseSystemPasswordChar = true;
            // 
            // chk_ShowPswd
            // 
            this.chk_ShowPswd.AutoSize = true;
            this.chk_ShowPswd.Location = new System.Drawing.Point(117, 228);
            this.chk_ShowPswd.Name = "chk_ShowPswd";
            this.chk_ShowPswd.Size = new System.Drawing.Size(128, 17);
            this.chk_ShowPswd.TabIndex = 11;
            this.chk_ShowPswd.Text = "Afficher mot de passe";
            this.chk_ShowPswd.UseVisualStyleBackColor = true;
            this.chk_ShowPswd.CheckedChanged += new System.EventHandler(this.chk_ShowPswd_CheckedChanged);
            // 
            // lbl_ForgotPassword
            // 
            this.lbl_ForgotPassword.AutoSize = true;
            this.lbl_ForgotPassword.Location = new System.Drawing.Point(114, 248);
            this.lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            this.lbl_ForgotPassword.Size = new System.Drawing.Size(102, 13);
            this.lbl_ForgotPassword.TabIndex = 12;
            this.lbl_ForgotPassword.Text = "Mot de passe oublié";
            // 
            // Form_Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 298);
            this.Controls.Add(this.lbl_ForgotPassword);
            this.Controls.Add(this.chk_ShowPswd);
            this.Controls.Add(this.txtBox_pass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txtBox_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txtBox_id;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_pass;
        private System.Windows.Forms.CheckBox chk_ShowPswd;
        private System.Windows.Forms.Label lbl_ForgotPassword;
    }
}

