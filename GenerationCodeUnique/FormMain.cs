using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryHelper;

namespace GenerationCodeUnique
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonGenererCodeTiers_Click(object sender, EventArgs e)
        {
            buttonGenererCodeTiers.Enabled = false;
            Application.DoEvents();
            List<string> ListCaracteres = new List<string>();
            ListCaracteres.AddRange(HelperClass.AddNumbers());
            ListCaracteres.AddRange(HelperClass.AddCharacters());
            List<string> forbiddenCaracteres = new List<string>
            {
                "0",
                "1",
                "l",
                "I"
            };

            textBoxCodeTiers.Text =HelperClass.GenerateCode(8, ListCaracteres, forbiddenCaracteres);
            buttonGenererCodeTiers.Enabled = true;
        }

        private void ButtonGenerateSequence_Click(object sender, EventArgs e)
        {
            buttonGenerateSequence.Enabled = false;
            Application.DoEvents();
            listBoxSequence.Items.Add(HelperClass.GenerateSequence());
            buttonGenerateSequence.Enabled = true;
        }

        private void ButtonSequenceSuivie_Click(object sender, EventArgs e)
        {
            buttonSequenceSuivie.Enabled = false;
            Application.DoEvents();
            List<string> ListCaracteres = new List<string>();
            ListCaracteres.AddRange(HelperClass.AddNumbers());
            ListCaracteres.AddRange(HelperClass.AddCharacters());
            List<string> forbiddenCaracteres = new List<string>
            {
                "0",
                "1",
                "l",
                "I"
            };
            string premierElement = HelperClass.GenerateCode(8, ListCaracteres, forbiddenCaracteres);
            listBoxSequenceSuivie.Items.Add(premierElement);
            string deuxiemeElement = HelperClass.GenerateNextItem(premierElement);
            listBoxSequenceSuivie.Items.Add(deuxiemeElement);
            buttonSequenceSuivie.Enabled = true;
        }
    }
}