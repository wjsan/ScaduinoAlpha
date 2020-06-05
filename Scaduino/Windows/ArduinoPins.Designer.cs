namespace Scaduino.Windows
{
    partial class ArduinoPins
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPins = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pinProperties = new System.Windows.Forms.PropertyGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new ModernUI.Button();
            this.buttonRemove = new ModernUI.Button();
            this.buttonSearch = new ModernUI.Button();
            this.buttonOk = new ModernUI.Button();
            this.buttonCancel = new ModernUI.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scaduino - Arduino Pins";
            // 
            // listBoxPins
            // 
            this.listBoxPins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxPins.ForeColor = System.Drawing.Color.White;
            this.listBoxPins.FormattingEnabled = true;
            this.listBoxPins.ItemHeight = 21;
            this.listBoxPins.Location = new System.Drawing.Point(53, 89);
            this.listBoxPins.Name = "listBoxPins";
            this.listBoxPins.Size = new System.Drawing.Size(229, 214);
            this.listBoxPins.TabIndex = 7;
            this.listBoxPins.SelectedIndexChanged += new System.EventHandler(this.listBoxPins_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pins";
            // 
            // pinProperties
            // 
            this.pinProperties.CategoryForeColor = System.Drawing.Color.White;
            this.pinProperties.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pinProperties.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinProperties.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pinProperties.HelpForeColor = System.Drawing.Color.White;
            this.pinProperties.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pinProperties.Location = new System.Drawing.Point(332, 89);
            this.pinProperties.Name = "pinProperties";
            this.pinProperties.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.pinProperties.Size = new System.Drawing.Size(248, 214);
            this.pinProperties.TabIndex = 8;
            this.pinProperties.ToolbarVisible = false;
            this.pinProperties.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pinProperties.ViewForeColor = System.Drawing.Color.White;
            this.pinProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pinProperties_PropertyValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pin Properties";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightGray;
            this.buttonAdd.ColorMouseEnter = System.Drawing.Color.Gray;
            this.buttonAdd.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.buttonAdd.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.ForeColorMouseEnter = System.Drawing.Color.White;
            this.buttonAdd.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.buttonAdd.ForeColorOnClick = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(174, 318);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.LightGray;
            this.buttonRemove.ColorMouseEnter = System.Drawing.Color.Gray;
            this.buttonRemove.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.buttonRemove.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.Black;
            this.buttonRemove.ForeColorMouseEnter = System.Drawing.Color.White;
            this.buttonRemove.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.buttonRemove.ForeColorOnClick = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(52, 318);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(106, 23);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightGray;
            this.buttonSearch.ColorMouseEnter = System.Drawing.Color.Gray;
            this.buttonSearch.ColorMouseLeave = System.Drawing.Color.LightGray;
            this.buttonSearch.ColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.ForeColorMouseEnter = System.Drawing.Color.White;
            this.buttonSearch.ForeColorMouseLeave = System.Drawing.Color.Black;
            this.buttonSearch.ForeColorOnClick = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(480, 318);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search Tag";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            this.buttonOk.Location = new System.Drawing.Point(480, 382);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "OK";
            this.buttonOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
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
            this.buttonCancel.Location = new System.Drawing.Point(374, 382);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ArduinoPins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(637, 452);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pinProperties);
            this.Controls.Add(this.listBoxPins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArduinoPins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArduinoPins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PropertyGrid pinProperties;
        private System.Windows.Forms.Label label3;
        private ModernUI.Button buttonAdd;
        private ModernUI.Button buttonRemove;
        private ModernUI.Button buttonSearch;
        private ModernUI.Button buttonOk;
        private ModernUI.Button buttonCancel;
    }
}