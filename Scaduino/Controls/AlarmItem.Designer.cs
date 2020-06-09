namespace Scaduino.Controls
{
    partial class AlarmItem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTagName = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStatus.TabIndex = 0;
            this.pictureBoxStatus.TabStop = false;
            this.pictureBoxStatus.DoubleClick += new System.EventHandler(this.AlarmItem_DoubleClick);
            // 
            // labelDate
            // 
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Red;
            this.labelDate.Location = new System.Drawing.Point(40, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Padding = new System.Windows.Forms.Padding(10);
            this.labelDate.Size = new System.Drawing.Size(181, 40);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "00/00/0000 00:00:00";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDate.DoubleClick += new System.EventHandler(this.AlarmItem_DoubleClick);
            // 
            // labelTagName
            // 
            this.labelTagName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTagName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagName.ForeColor = System.Drawing.Color.Red;
            this.labelTagName.Location = new System.Drawing.Point(221, 0);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Padding = new System.Windows.Forms.Padding(10);
            this.labelTagName.Size = new System.Drawing.Size(136, 40);
            this.labelTagName.TabIndex = 2;
            this.labelTagName.Text = "TagName";
            this.labelTagName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTagName.DoubleClick += new System.EventHandler(this.AlarmItem_DoubleClick);
            // 
            // labelMessage
            // 
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(357, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Padding = new System.Windows.Forms.Padding(10);
            this.labelMessage.Size = new System.Drawing.Size(600, 40);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMessage.DoubleClick += new System.EventHandler(this.AlarmItem_DoubleClick);
            // 
            // AlarmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelTagName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBoxStatus);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AlarmItem";
            this.Size = new System.Drawing.Size(957, 40);
            this.ForeColorChanged += new System.EventHandler(this.AlarmItem_ForeColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTagName;
        private System.Windows.Forms.Label labelMessage;
    }
}
