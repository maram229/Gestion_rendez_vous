namespace GestionRendezVous
{
    partial class FormListeRendezVous
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
            dataGridRdv = new DataGridView();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridRdv).BeginInit();
            SuspendLayout();
            // 
            // dataGridRdv
            // 
            dataGridRdv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRdv.Location = new Point(230, 36);
            dataGridRdv.Name = "dataGridRdv";
            dataGridRdv.RowHeadersWidth = 51;
            dataGridRdv.Size = new Size(332, 188);
            dataGridRdv.TabIndex = 0;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(30, 279);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(210, 60);
            btnSupprimer.TabIndex = 1;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(292, 279);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(219, 70);
            btnModifier.TabIndex = 2;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += button2_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(573, 279);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(199, 70);
            btnRetour.TabIndex = 3;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // FormListeRendezVous
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetour);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
            Controls.Add(dataGridRdv);
            Name = "FormListeRendezVous";
            Text = "FormListeRendezVous";
            Load += FormListeRendezVous_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridRdv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridRdv;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnRetour;
    }
}