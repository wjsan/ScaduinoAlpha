using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Scaduino.Editors
{
    public partial class CreateCodeDialog : Form
    {
        public string CodeName { get => textBoxName.Text; set => textBoxName.Text = value.Replace(".ino", ""); }
        public string CodeDirectory { get => TextBoxDirectory.Text; set => TextBoxDirectory.Text = value; }
        public bool OpenCode { get => checkBoxOpen.Checked; }

        public CreateCodeDialog()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonSearchDir_Click(object sender, EventArgs e)
        {
            var directoryDialog = new FolderBrowserDialog()
            {
                SelectedPath = TextBoxDirectory.Text
            };
            if(directoryDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxDirectory.Text = TextBoxDirectory.Text;
            }
        }

        private void buttonIntallLibs_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/WesleyJoseSantos/BqBusArduino");
        }
    }
}
