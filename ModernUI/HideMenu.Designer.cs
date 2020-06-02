namespace ModernUI
{
    partial class HideMenu
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
            this.SuspendLayout();
            // 
            // HideMenu
            // 
            this.Dock = System.Windows.Forms.DockStyle.Right;
            this.Size = new System.Drawing.Size(5, 23);
            this.Text = "<";
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HideMenu_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HideMenu_MouseClick);
            this.MouseEnter += new System.EventHandler(this.HideMenu_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.HideMenu_MouseLeave);
            this.ParentChanged += new System.EventHandler(this.HideMenu_ParentChanged);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
