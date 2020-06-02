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
            this.screenContainer1 = new ModernUI.ScreenContainer();
            this.SuspendLayout();
            // 
            // screenContainer1
            // 
            this.screenContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenContainer1.Location = new System.Drawing.Point(0, 0);
            this.screenContainer1.Name = "screenContainer1";
            this.screenContainer1.Screens = null;
            this.screenContainer1.SelectedScreen = null;
            this.screenContainer1.Size = new System.Drawing.Size(406, 271);
            this.screenContainer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 271);
            this.Controls.Add(this.screenContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ModernUI.ScreenContainer screenContainer1;
    }
}