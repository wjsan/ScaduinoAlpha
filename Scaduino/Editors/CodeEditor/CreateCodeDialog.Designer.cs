namespace Scaduino.Editors
{
    partial class CreateCodeDialog
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonSearchDir = new ModernUI.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancel = new ModernUI.Button();
            this.buttonCreate = new ModernUI.Button();
            this.checkBoxOpen = new System.Windows.Forms.CheckBox();
            this.buttonIntallLibs = new ModernUI.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Scaduino.Properties.Resources.scaduinoIcon;
            this.pictureBox1.Location = new System.Drawing.Point(46, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Directory:";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxName.Location = new System.Drawing.Point(278, 97);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(275, 28);
            this.textBoxName.TabIndex = 2;
            // 
            // TextBoxDirectory
            // 
            this.TextBoxDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxDirectory.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBoxDirectory.Location = new System.Drawing.Point(278, 154);
            this.TextBoxDirectory.Name = "TextBoxDirectory";
            this.TextBoxDirectory.Size = new System.Drawing.Size(275, 28);
            this.TextBoxDirectory.TabIndex = 2;
            // 
            // buttonSearchDir
            // 
            this.buttonSearchDir.BackColor = System.Drawing.Color.LightGray;
            this.buttonSearchDir.ColorMouseEnter = System.Drawing.Color.Gray;
            this.buttonSearchDir.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.buttonSearchDir.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonSearchDir.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchDir.ForeColor = System.Drawing.Color.Black;
            this.buttonSearchDir.ForeColorMouseEnter = System.Drawing.Color.White;
            this.buttonSearchDir.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.buttonSearchDir.ForeColorOnClick = System.Drawing.Color.White;
            this.buttonSearchDir.Location = new System.Drawing.Point(527, 157);
            this.buttonSearchDir.Name = "buttonSearchDir";
            this.buttonSearchDir.Size = new System.Drawing.Size(23, 22);
            this.buttonSearchDir.TabIndex = 3;
            this.buttonSearchDir.Text = "...";
            this.buttonSearchDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSearchDir.Click += new System.EventHandler(this.buttonSearchDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scaduino - Create Device Code";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.LightGray;
            this.buttonCancel.ColorMouseEnter = System.Drawing.Color.Gray;
            this.buttonCancel.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.buttonCancel.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.ForeColorMouseEnter = System.Drawing.Color.White;
            this.buttonCancel.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.buttonCancel.ForeColorOnClick = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(312, 276);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 33);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.BackColor = System.Drawing.Color.LightGray;
            this.buttonCreate.ColorMouseEnter = System.Drawing.Color.Gray;
            this.buttonCreate.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.buttonCreate.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.Black;
            this.buttonCreate.ForeColorMouseEnter = System.Drawing.Color.White;
            this.buttonCreate.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.buttonCreate.ForeColorOnClick = System.Drawing.Color.White;
            this.buttonCreate.Location = new System.Drawing.Point(457, 276);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 33);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "OK";
            this.buttonCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // checkBoxOpen
            // 
            this.checkBoxOpen.AutoSize = true;
            this.checkBoxOpen.Location = new System.Drawing.Point(448, 210);
            this.checkBoxOpen.Name = "checkBoxOpen";
            this.checkBoxOpen.Size = new System.Drawing.Size(107, 25);
            this.checkBoxOpen.TabIndex = 6;
            this.checkBoxOpen.Text = "Open Code";
            this.checkBoxOpen.UseVisualStyleBackColor = true;
            // 
            // buttonIntallLibs
            // 
            this.buttonIntallLibs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIntallLibs.BackColor = System.Drawing.Color.LightGray;
            this.buttonIntallLibs.ColorMouseEnter = System.Drawing.Color.Gray;
            this.buttonIntallLibs.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.buttonIntallLibs.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonIntallLibs.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIntallLibs.ForeColor = System.Drawing.Color.Black;
            this.buttonIntallLibs.ForeColorMouseEnter = System.Drawing.Color.White;
            this.buttonIntallLibs.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.buttonIntallLibs.ForeColorOnClick = System.Drawing.Color.White;
            this.buttonIntallLibs.Location = new System.Drawing.Point(158, 276);
            this.buttonIntallLibs.Name = "buttonIntallLibs";
            this.buttonIntallLibs.Size = new System.Drawing.Size(109, 33);
            this.buttonIntallLibs.TabIndex = 5;
            this.buttonIntallLibs.Text = "Install Libs";
            this.buttonIntallLibs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonIntallLibs.Click += new System.EventHandler(this.buttonIntallLibs_Click);
            // 
            // CreateCodeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(620, 360);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxOpen);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonIntallLibs);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSearchDir);
            this.Controls.Add(this.TextBoxDirectory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateCodeDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create code";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox TextBoxDirectory;
        private ModernUI.Button buttonSearchDir;
        private System.Windows.Forms.Label label3;
        private ModernUI.Button buttonCancel;
        private ModernUI.Button buttonCreate;
        private System.Windows.Forms.CheckBox checkBoxOpen;
        private ModernUI.Button buttonIntallLibs;
    }
}