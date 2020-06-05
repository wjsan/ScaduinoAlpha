namespace Scaduino.Windows
{
    partial class CommunicationChannelsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxCommunicationLinks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDriveType = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new ModernUI.Button();
            this.buttonOk = new ModernUI.Button();
            this.buttonAddLink = new ModernUI.Button();
            this.commProperties = new System.Windows.Forms.PropertyGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scaduino - Communication Channels";
            // 
            // listBoxCommunicationLinks
            // 
            this.listBoxCommunicationLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxCommunicationLinks.ForeColor = System.Drawing.Color.White;
            this.listBoxCommunicationLinks.FormattingEnabled = true;
            this.listBoxCommunicationLinks.ItemHeight = 21;
            this.listBoxCommunicationLinks.Location = new System.Drawing.Point(42, 140);
            this.listBoxCommunicationLinks.Name = "listBoxCommunicationLinks";
            this.listBoxCommunicationLinks.Size = new System.Drawing.Size(211, 256);
            this.listBoxCommunicationLinks.TabIndex = 6;
            this.listBoxCommunicationLinks.SelectedIndexChanged += new System.EventHandler(this.listBoxCommunicationLinks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Communication Channels";
            // 
            // comboBoxDriveType
            // 
            this.comboBoxDriveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDriveType.FormattingEnabled = true;
            this.comboBoxDriveType.Items.AddRange(new object[] {
            "BqBusSerial"});
            this.comboBoxDriveType.Location = new System.Drawing.Point(42, 103);
            this.comboBoxDriveType.Name = "comboBoxDriveType";
            this.comboBoxDriveType.Size = new System.Drawing.Size(145, 29);
            this.comboBoxDriveType.TabIndex = 9;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightGray;
            this.buttonCancel.ColorMouseEnter = System.Drawing.Color.Gray;
            this.buttonCancel.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.buttonCancel.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.ForeColorMouseEnter = System.Drawing.Color.White;
            this.buttonCancel.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.buttonCancel.ForeColorOnClick = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(301, 429);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            this.buttonOk.Location = new System.Drawing.Point(438, 429);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(117, 23);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "OK";
            this.buttonOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAddLink
            // 
            this.buttonAddLink.BackColor = System.Drawing.Color.LightGray;
            this.buttonAddLink.ColorMouseEnter = System.Drawing.Color.Gray;
            this.buttonAddLink.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.buttonAddLink.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonAddLink.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddLink.ForeColor = System.Drawing.Color.Black;
            this.buttonAddLink.ForeColorMouseEnter = System.Drawing.Color.White;
            this.buttonAddLink.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.buttonAddLink.ForeColorOnClick = System.Drawing.Color.White;
            this.buttonAddLink.Location = new System.Drawing.Point(193, 103);
            this.buttonAddLink.Name = "buttonAddLink";
            this.buttonAddLink.Size = new System.Drawing.Size(60, 29);
            this.buttonAddLink.TabIndex = 8;
            this.buttonAddLink.Text = "Add";
            this.buttonAddLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAddLink.Click += new System.EventHandler(this.buttonAddLink_Click);
            // 
            // commProperties
            // 
            this.commProperties.CategoryForeColor = System.Drawing.Color.White;
            this.commProperties.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.commProperties.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commProperties.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.commProperties.HelpForeColor = System.Drawing.Color.White;
            this.commProperties.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.commProperties.Location = new System.Drawing.Point(301, 105);
            this.commProperties.Name = "commProperties";
            this.commProperties.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.commProperties.Size = new System.Drawing.Size(256, 289);
            this.commProperties.TabIndex = 10;
            this.commProperties.ToolbarVisible = false;
            this.commProperties.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.commProperties.ViewForeColor = System.Drawing.Color.White;
            this.commProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.commProperties_PropertyValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Channel Settings";
            // 
            // CommunicationChannelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(609, 493);
            this.Controls.Add(this.commProperties);
            this.Controls.Add(this.comboBoxDriveType);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonAddLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCommunicationLinks);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CommunicationChannelsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommunicationLinks";
            this.Load += new System.EventHandler(this.CommunicationLinksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCommunicationLinks;
        private System.Windows.Forms.Label label1;
        private ModernUI.Button buttonAddLink;
        private ModernUI.Button buttonOk;
        private ModernUI.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxDriveType;
        private System.Windows.Forms.PropertyGrid commProperties;
        private System.Windows.Forms.Label label2;
    }
}