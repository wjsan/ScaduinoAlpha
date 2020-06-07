namespace Tester
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            Scaduino.Protocols.BqBus.BqBusSerialDriver bqBusSerialDriver1 = new Scaduino.Protocols.BqBus.BqBusSerialDriver();
            this.communicationChannels1 = new Scaduino.Protocols.CommunicationChannels(this.components);
            this.SuspendLayout();
            // 
            // communicationChannels1
            // 
            bqBusSerialDriver1.AutoConnect = false;
            bqBusSerialDriver1.BaudRate = 9600;
            bqBusSerialDriver1.Name = "BqBusSerial";
            bqBusSerialDriver1.PortName = "COM1";
            bqBusSerialDriver1.Tags = null;
            this.communicationChannels1.Drivers = new Scaduino.Protocols.CommunicationDriver[] {
        ((Scaduino.Protocols.CommunicationDriver)(bqBusSerialDriver1))};
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Scaduino.Protocols.CommunicationChannels communicationChannels1;
    }
}