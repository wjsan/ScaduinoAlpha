namespace Tester
{
    partial class Form1
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
            Scaduino.Protocols.BqBusSerialDriver bqBusSerialDriver2 = new Scaduino.Protocols.BqBusSerialDriver();
            Scaduino.Components.Tag tag2 = new Scaduino.Components.Tag();
            Scaduino.ArduinoBoard.Pin pin2 = new Scaduino.ArduinoBoard.Pin();
            this.scaduinoButton1 = new Scaduino.Controls.ScaduinoButton();
            this.communicationChannels1 = new Scaduino.Protocols.CommunicationChannels(this.components);
            this.arduino1 = new Scaduino.ArduinoBoard.Arduino(this.components);
            this.SuspendLayout();
            // 
            // scaduinoButton1
            // 
            this.scaduinoButton1.BackColor = System.Drawing.Color.LightGray;
            this.scaduinoButton1.ColorMouseEnter = System.Drawing.Color.Gray;
            this.scaduinoButton1.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.scaduinoButton1.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.scaduinoButton1.CommunicationSource = this.communicationChannels1;
            this.scaduinoButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaduinoButton1.ForeColor = System.Drawing.Color.Black;
            this.scaduinoButton1.ForeColorMouseEnter = System.Drawing.Color.White;
            this.scaduinoButton1.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.scaduinoButton1.ForeColorOnClick = System.Drawing.Color.White;
            this.scaduinoButton1.Location = new System.Drawing.Point(51, 36);
            this.scaduinoButton1.Mode = Scaduino.Controls.ScaduinoButton.ButtonMode.Pulse;
            this.scaduinoButton1.Name = "scaduinoButton1";
            this.scaduinoButton1.Size = new System.Drawing.Size(120, 20);
            this.scaduinoButton1.TabIndex = 0;
            this.scaduinoButton1.Tag = tag2;
            this.scaduinoButton1.Text = "scaduinoButton1";
            this.scaduinoButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // communicationChannels1
            // 
            bqBusSerialDriver2.AutoConnect = false;
            bqBusSerialDriver2.BaudRate = 9600;
            bqBusSerialDriver2.Name = "BqBusSerial";
            bqBusSerialDriver2.PortName = "COM4";
            tag2.Name = "BUTTON";
            tag2.Value = 0;
            bqBusSerialDriver2.Tags = new Scaduino.Components.Tag[] {
        tag2};
            this.communicationChannels1.Drivers = new Scaduino.Protocols.CommunicationDriver[] {
        ((Scaduino.Protocols.CommunicationDriver)(bqBusSerialDriver2))};
            // 
            // arduino1
            // 
            this.arduino1.CommunicationChannel = bqBusSerialDriver2;
            this.arduino1.CommunicationSource = this.communicationChannels1;
            pin2.Mode = Scaduino.ArduinoBoard.Pin.PinType.Output;
            pin2.Name = "pinLed";
            pin2.Number = 13;
            pin2.Tag = tag2;
            this.arduino1.Pins = new Scaduino.ArduinoBoard.Pin[] {
        pin2};
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scaduinoButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Scaduino.Protocols.CommunicationChannels communicationChannels1;
        private Scaduino.Controls.ScaduinoButton scaduinoButton1;
        private Scaduino.ArduinoBoard.Arduino arduino1;
    }
}