namespace ModernUI
{
    partial class ScreenTopBar
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
            // ScreenTopBar
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Name = "ScreenTopBar";
            this.Size = new System.Drawing.Size(274, 51);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ScreenTopBar_ControlAdded);
            this.ParentChanged += new System.EventHandler(this.ScreenTopBar_ParentChanged);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
