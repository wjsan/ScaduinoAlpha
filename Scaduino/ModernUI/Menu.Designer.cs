
namespace ModernUI
{
    partial class Menu
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
            // Menu
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Dock = System.Windows.Forms.DockStyle.Left;
            this.Size = new System.Drawing.Size(272, 398);
            this.SizeChanged += new System.EventHandler(this.Menu_SizeChanged);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Menu_ControlAdded);
            this.ParentChanged += new System.EventHandler(this.Menu_ParentChanged);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
