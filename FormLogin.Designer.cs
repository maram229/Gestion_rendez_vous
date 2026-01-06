namespace GestionRendezVous
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUtilisateur = new TextBox();
            txtMotDePasse = new TextBox();
            btnConnexion = new Button();
            SuspendLayout();
            // 
            // txtUtilisateur
            // 
            txtUtilisateur.Location = new Point(306, 65);
            txtUtilisateur.Name = "txtUtilisateur";
            txtUtilisateur.Size = new Size(172, 27);
            txtUtilisateur.TabIndex = 0;
            txtUtilisateur.TextChanged += txtUtilisateur_TextChanged_1;
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(314, 151);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(164, 27);
            txtMotDePasse.TabIndex = 1;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(314, 248);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(155, 47);
            btnConnexion.TabIndex = 2;
            btnConnexion.Text = "Se connecter";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click_1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConnexion);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtUtilisateur);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUtilisateur;
        private TextBox txtMotDePasse;
        private Button btnConnexion;
    }
}