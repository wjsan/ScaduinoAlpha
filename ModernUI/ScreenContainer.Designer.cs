namespace ModernUI
{
    partial class ScreenContainer
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
            // ScreenContainer
            // 
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ScreenContainer_ControlAdded);
            this.ParentChanged += new System.EventHandler(this.ScreenContainer_ParentChanged);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
