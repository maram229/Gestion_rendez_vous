namespace GestionRendezVous
{
    partial class FormDashboard
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
            lblBienvenue = new Label();
            btnVoirRdv = new Button();
            btnAjouterRdv = new Button();
            btnDeconnexion = new Button();
            SuspendLayout();
            // 
            // lblBienvenue
            // 
            lblBienvenue.AutoSize = true;
            lblBienvenue.Location = new Point(348, 75);
            lblBienvenue.Name = "lblBienvenue";
            lblBienvenue.Size = new Size(127, 20);
            lblBienvenue.TabIndex = 0;
            lblBienvenue.Text = "Bienvenue, [Nom]";
            // 
            // btnVoirRdv
            // 
            btnVoirRdv.Location = new Point(12, 235);
            btnVoirRdv.Name = "btnVoirRdv";
            btnVoirRdv.Size = new Size(208, 62);
            btnVoirRdv.TabIndex = 1;
            btnVoirRdv.Text = "Voir Les Rendez-Vous";
            btnVoirRdv.UseVisualStyleBackColor = true;
            btnVoirRdv.Click += btnVoirRdv_Click;
            // 
            // btnAjouterRdv
            // 
            btnAjouterRdv.Location = new Point(287, 237);
            btnAjouterRdv.Name = "btnAjouterRdv";
            btnAjouterRdv.Size = new Size(208, 61);
            btnAjouterRdv.TabIndex = 2;
            btnAjouterRdv.Text = "Ajouter Un Rendez-Vous";
            btnAjouterRdv.UseVisualStyleBackColor = true;
            btnAjouterRdv.Click += btnAjouterRdv_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Location = new Point(556, 237);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(208, 60);
            btnDeconnexion.TabIndex = 3;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeconnexion);
            Controls.Add(btnAjouterRdv);
            Controls.Add(btnVoirRdv);
            Controls.Add(lblBienvenue);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenue;
        private Button btnVoirRdv;
        private Button btnAjouterRdv;
        private Button btnDeconnexion;
    }
}