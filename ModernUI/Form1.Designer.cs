namespace ModernUI
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
            this.screenContainer1 = new ModernUI.ScreenContainer();
            this.screen1 = new ModernUI.Screen();
            this.screen2 = new ModernUI.Screen();
            this.screen3 = new ModernUI.Screen();
            this.screen4 = new ModernUI.Screen();
            this.screenContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenContainer1
            // 
            this.screenContainer1.Controls.Add(this.screen4);
            this.screenContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenContainer1.Location = new System.Drawing.Point(0, 0);
            this.screenContainer1.Name = "screenContainer1";
            this.screenContainer1.Screens = new ModernUI.Screen[] {
        this.screen1,
        this.screen2,
        this.screen3,
        this.screen4};
            this.screenContainer1.SelectedScreen = this.screen4;
            this.screenContainer1.Size = new System.Drawing.Size(364, 290);
            this.screenContainer1.TabIndex = 0;
            // 
            // screen1
            // 
            this.screen1.BackColor = System.Drawing.Color.White;
            this.screen1.Location = new System.Drawing.Point(0, 0);
            this.screen1.Name = "screen1";
            this.screen1.Size = new System.Drawing.Size(200, 100);
            this.screen1.TabIndex = 0;
            // 
            // screen2
            // 
            this.screen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.screen2.Location = new System.Drawing.Point(0, 0);
            this.screen2.Name = "screen2";
            this.screen2.Size = new System.Drawing.Size(200, 100);
            this.screen2.TabIndex = 0;
            // 
            // screen3
            // 
            this.screen3.BackColor = System.Drawing.Color.Silver;
            this.screen3.Location = new System.Drawing.Point(0, 0);
            this.screen3.Name = "screen3";
            this.screen3.Size = new System.Drawing.Size(200, 100);
            this.screen3.TabIndex = 0;
            // 
            // screen4
            // 
            this.screen4.BackColor = System.Drawing.Color.Gray;
            this.screen4.Location = new System.Drawing.Point(0, 0);
            this.screen4.Name = "screen4";
            this.screen4.Size = new System.Drawing.Size(200, 100);
            this.screen4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 290);
            this.Controls.Add(this.screenContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.screenContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ScreenContainer screenContainer1;
        private Screen screen4;
        private Screen screen1;
        private Screen screen2;
        private Screen screen3;
    }
}