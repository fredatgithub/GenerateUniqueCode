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
        }

        private void ButtonGenerateSequence_Click(object sender, EventArgs e)
        {
            listBoxSequence.Items.Add(HelperClass.GenerateSequence());
        }

        private void ButtonSequenceSuivie_Click(object sender, EventArgs e)
        {
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
        }
    }
}