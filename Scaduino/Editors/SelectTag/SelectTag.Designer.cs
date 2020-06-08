namespace Scaduino.Editors
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
            this.label3 = new System.Windows.Forms.Label();
            this.treeViewDrivers = new System.Windows.Forms.TreeView();
            this.treeViewTags = new System.Windows.Forms.TreeView();
            this.textBoxNewTag = new System.Windows.Forms.TextBox();
            this.buttonCancel = new ModernUI.Button();
            this.buttonAdd = new ModernUI.Button();
            this.buttonOk = new ModernUI.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scaduino - Select Tag";
            // 
            // treeViewDrivers
            // 
            this.treeViewDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeViewDrivers.ForeColor = System.Drawing.Color.White;
            this.treeViewDrivers.Location = new System.Drawing.Point(33, 94);
            this.treeViewDrivers.Name = "treeViewDrivers";
            this.treeViewDrivers.Size = new System.Drawing.Size(163, 222);
            this.treeViewDrivers.TabIndex = 6;
            this.treeViewDrivers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDrivers_AfterSelect);
            // 
            // treeViewTags
            // 
            this.treeViewTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeViewTags.ForeColor = System.Drawing.Color.White;
            this.treeViewTags.Location = new System.Drawing.Point(202, 94);
            this.treeViewTags.Name = "treeViewTags";
            this.treeViewTags.Size = new System.Drawing.Size(159, 222);
            this.treeViewTags.TabIndex = 6;
            this.treeViewTags.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTags_AfterSelect);
            // 
            // textBoxNewTag
            // 
            this.textBoxNewTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNewTag.ForeColor = System.Drawing.Color.White;
            this.textBoxNewTag.Location = new System.Drawing.Point(33, 60);
            this.textBoxNewTag.Name = "textBoxNewTag";
            this.textBoxNewTag.Size = new System.Drawing.Size(241, 28);
            this.textBoxNewTag.TabIndex = 7;
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
            this.buttonCancel.Location = new System.Drawing.Point(376, 135);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 33);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.LightGray;
            this.buttonAdd.ColorMouseEnter = System.Drawing.Color.Gray;
            this.buttonAdd.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.buttonAdd.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.ForeColorMouseEnter = System.Drawing.Color.White;
            this.buttonAdd.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.buttonAdd.ForeColorOnClick = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(281, 60);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 28);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.BackColor = System.Drawing.Color.LightGray;
            this.buttonOk.ColorMouseEnter = System.Drawing.Color.Gray;
            this.buttonOk.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.buttonOk.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.Color.Black;
            this.buttonOk.ForeColorMouseEnter = System.Drawing.Color.White;
            this.buttonOk.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.buttonOk.ForeColorOnClick = System.Drawing.Color.White;
            this.buttonOk.Location = new System.Drawing.Point(376, 94);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(84, 33);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // SelectTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(473, 354);
            this.Controls.Add(this.textBoxNewTag);
            this.Controls.Add(this.treeViewTags);
            this.Controls.Add(this.treeViewDrivers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonOk);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectTag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Tag";
            this.Load += new System.EventHandler(this.SelectTag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ModernUI.Button buttonOk;
        private System.Windows.Forms.Label label3;
        private ModernUI.Button buttonCancel;
        private System.Windows.Forms.TreeView treeViewDrivers;
        private System.Windows.Forms.TreeView treeViewTags;
        private System.Windows.Forms.TextBox textBoxNewTag;
        private ModernUI.Button buttonAdd;
    }
}