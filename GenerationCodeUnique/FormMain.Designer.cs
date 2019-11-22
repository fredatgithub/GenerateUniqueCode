namespace GenerationCodeUnique
{
    partial class FormMain
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
            this.buttonGenererCodeTiers = new System.Windows.Forms.Button();
            this.textBoxCodeTiers = new System.Windows.Forms.TextBox();
            this.labelCodeTiers = new System.Windows.Forms.Label();
            this.buttonGenerateSequence = new System.Windows.Forms.Button();
            this.listBoxSequence = new System.Windows.Forms.ListBox();
            this.buttonSequenceSuivie = new System.Windows.Forms.Button();
            this.listBoxSequenceSuivie = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonGenererCodeTiers
            // 
            this.buttonGenererCodeTiers.Location = new System.Drawing.Point(230, 52);
            this.buttonGenererCodeTiers.Name = "buttonGenererCodeTiers";
            this.buttonGenererCodeTiers.Size = new System.Drawing.Size(151, 23);
            this.buttonGenererCodeTiers.TabIndex = 0;
            this.buttonGenererCodeTiers.Text = "Génerer aléatoirement";
            this.buttonGenererCodeTiers.UseVisualStyleBackColor = true;
            this.buttonGenererCodeTiers.Click += new System.EventHandler(this.ButtonGenererCodeTiers_Click);
            // 
            // textBoxCodeTiers
            // 
            this.textBoxCodeTiers.Location = new System.Drawing.Point(43, 52);
            this.textBoxCodeTiers.Name = "textBoxCodeTiers";
            this.textBoxCodeTiers.Size = new System.Drawing.Size(154, 20);
            this.textBoxCodeTiers.TabIndex = 1;
            // 
            // labelCodeTiers
            // 
            this.labelCodeTiers.AutoSize = true;
            this.labelCodeTiers.Location = new System.Drawing.Point(43, 13);
            this.labelCodeTiers.Name = "labelCodeTiers";
            this.labelCodeTiers.Size = new System.Drawing.Size(58, 13);
            this.labelCodeTiers.TabIndex = 2;
            this.labelCodeTiers.Text = "Code Tiers";
            // 
            // buttonGenerateSequence
            // 
            this.buttonGenerateSequence.Location = new System.Drawing.Point(230, 106);
            this.buttonGenerateSequence.Name = "buttonGenerateSequence";
            this.buttonGenerateSequence.Size = new System.Drawing.Size(151, 23);
            this.buttonGenerateSequence.TabIndex = 3;
            this.buttonGenerateSequence.Text = "Génerer par séquence";
            this.buttonGenerateSequence.UseVisualStyleBackColor = true;
            this.buttonGenerateSequence.Click += new System.EventHandler(this.ButtonGenerateSequence_Click);
            // 
            // listBoxSequence
            // 
            this.listBoxSequence.FormattingEnabled = true;
            this.listBoxSequence.Location = new System.Drawing.Point(46, 106);
            this.listBoxSequence.Name = "listBoxSequence";
            this.listBoxSequence.Size = new System.Drawing.Size(151, 225);
            this.listBoxSequence.TabIndex = 4;
            // 
            // buttonSequenceSuivie
            // 
            this.buttonSequenceSuivie.Location = new System.Drawing.Point(387, 52);
            this.buttonSequenceSuivie.Name = "buttonSequenceSuivie";
            this.buttonSequenceSuivie.Size = new System.Drawing.Size(151, 23);
            this.buttonSequenceSuivie.TabIndex = 5;
            this.buttonSequenceSuivie.Text = "séquence suivie";
            this.buttonSequenceSuivie.UseVisualStyleBackColor = true;
            this.buttonSequenceSuivie.Click += new System.EventHandler(this.ButtonSequenceSuivie_Click);
            // 
            // listBoxSequenceSuivie
            // 
            this.listBoxSequenceSuivie.FormattingEnabled = true;
            this.listBoxSequenceSuivie.Location = new System.Drawing.Point(544, 52);
            this.listBoxSequenceSuivie.Name = "listBoxSequenceSuivie";
            this.listBoxSequenceSuivie.Size = new System.Drawing.Size(151, 277);
            this.listBoxSequenceSuivie.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 558);
            this.Controls.Add(this.listBoxSequenceSuivie);
            this.Controls.Add(this.buttonSequenceSuivie);
            this.Controls.Add(this.listBoxSequence);
            this.Controls.Add(this.buttonGenerateSequence);
            this.Controls.Add(this.labelCodeTiers);
            this.Controls.Add(this.textBoxCodeTiers);
            this.Controls.Add(this.buttonGenererCodeTiers);
            this.Name = "FormMain";
            this.Text = "Génération d\'un code unique sur 8 caractères";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenererCodeTiers;
        private System.Windows.Forms.TextBox textBoxCodeTiers;
        private System.Windows.Forms.Label labelCodeTiers;
        private System.Windows.Forms.Button buttonGenerateSequence;
        private System.Windows.Forms.ListBox listBoxSequence;
        private System.Windows.Forms.Button buttonSequenceSuivie;
        private System.Windows.Forms.ListBox listBoxSequenceSuivie;
    }
}

