namespace Scaduino.Windows
{
    partial class SelectTag
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
            this.comboBoxTags = new System.Windows.Forms.ComboBox();
            this.buttonOk = new ModernUI.Button();
            this.SuspendLayout();
            // 
            // comboBoxTags
            // 
            this.comboBoxTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTags.FormattingEnabled = true;
            this.comboBoxTags.Location = new System.Drawing.Point(39, 39);
            this.comboBoxTags.Name = "comboBoxTags";
            this.comboBoxTags.Size = new System.Drawing.Size(181, 21);
            this.comboBoxTags.TabIndex = 0;
            this.comboBoxTags.SelectedIndexChanged += new System.EventHandler(this.comboBoxTags_SelectedIndexChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.LightGray;
            this.buttonOk.ColorMouseEnter = System.Drawing.Color.Gray;
            this.buttonOk.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.buttonOk.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.Color.Black;
            this.buttonOk.ForeColorMouseEnter = System.Drawing.Color.White;
            this.buttonOk.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.buttonOk.ForeColorOnClick = System.Drawing.Color.White;
            this.buttonOk.Location = new System.Drawing.Point(141, 89);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(79, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // SelectTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 141);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxTags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectTag";
            this.Text = "Select Tag";
            this.Load += new System.EventHandler(this.SelectTag_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTags;
        private ModernUI.Button buttonOk;
    }
}