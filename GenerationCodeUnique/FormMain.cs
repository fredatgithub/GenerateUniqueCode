using System;
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
            textBoxCodeTiers.Text =HelperClass.GenerateCode();
        }

        

        private void ButtonGenerateSequence_Click(object sender, EventArgs e)
        {
            listBoxSequence.Items.Add(HelperClass.GenerateSequence());
        }

        

        private void ButtonSequenceSuivie_Click(object sender, EventArgs e)
        {
            string premierElement = HelperClass.GenerateCode();
            listBoxSequenceSuivie.Items.Add(premierElement);
            string deuxiemeElement = HelperClass.GenerateNextItem(premierElement);
            listBoxSequenceSuivie.Items.Add(deuxiemeElement);

        }

        
    }
}