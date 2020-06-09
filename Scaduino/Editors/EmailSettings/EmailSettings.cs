using Scaduino.Components;
using System.Diagnostics;
using System.Windows.Forms;

namespace Scaduino.Editors
{
    public partial class EmailSettings : Form
    {
        private EmailSender emailSettings = new EmailSender();

        public EmailSettings()
        {
            InitializeComponent();
            if (GlobalData.EmailSettings == null) return;
            textBoxHost.Text = GlobalData.EmailSettings.SmtpHost;
            textBoxName.Text = GlobalData.EmailSettings.DestinationName;
            textBoxPass.Text = GlobalData.EmailSettings.SmtpPass;
            textBoxPort.Text = GlobalData.EmailSettings.SmtpPort.ToString();
            textBoxTo.Text = GlobalData.EmailSettings.DestinationMail;
            textBoxUser.Text = GlobalData.EmailSettings.SmtpUser;
        }

        private void textBoxHost_TextChanged(object sender, System.EventArgs e)
        {
            var tb = (TextBox)sender;
            emailSettings.SmtpHost = tb.Text;
        }

        private void textBoxPort_TextChanged(object sender, System.EventArgs e)
        {
            var tb = (TextBox)sender;
            emailSettings.SmtpPort = int.Parse(tb.Text);
        }

        private void textBoxUser_TextChanged(object sender, System.EventArgs e)
        {
            var tb = (TextBox)sender;
            emailSettings.SmtpUser = tb.Text;
        }

        private void textBoxPass_TextChanged(object sender, System.EventArgs e)
        {
            var tb = (TextBox)sender;
            emailSettings.SmtpPass = tb.Text;
        }

        private void textBoxTo_TextChanged(object sender, System.EventArgs e)
        {
            var tb = (TextBox)sender;
            emailSettings.DestinationMail = tb.Text;
        }

        private void textBoxName_TextChanged(object sender, System.EventArgs e)
        {
            var tb = (TextBox)sender;
            emailSettings.DestinationName = tb.Text;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            GlobalData.EmailSettings = emailSettings;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://domar.com/smtp_pop3_server");
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            textBoxHost.Text = "smtp.gmail.com";
            textBoxPort.Text = "587";
            textBoxUser.Text = "yourGmail@gmail.com";
            textBoxPass.Text = "yourPass";
            Process.Start("https://myaccount.google.com/u/0/lesssecureapps?pli=1");
        }
    }
}
