namespace ModernUI
{
    partial class MenuItem
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMenu.Location = new System.Drawing.Point(10, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(268, 39);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "menuItem";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMenu.Click += new System.EventHandler(this.LabelMenu_Click);
            this.labelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseDown);
            this.labelMenu.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.labelMenu.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // labelSelected
            // 
            this.labelSelected.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSelected.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelSelected.Location = new System.Drawing.Point(0, 7);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(5, 27);
            this.labelSelected.TabIndex = 1;
            // 
            // MenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.labelMenu);
            this.Name = "MenuItem";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Size = new System.Drawing.Size(278, 39);
            this.FontChanged += new System.EventHandler(this.MenuItem_FontChanged);
            this.ForeColorChanged += new System.EventHandler(this.MenuItem_ForeColorChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelSelected;
    }
}
