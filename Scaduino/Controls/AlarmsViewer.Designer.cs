namespace Scaduino.Controls
{
    partial class AlarmsViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmsViewer));
            this.imageListAlarmStatus = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageListAlarmStatus
            // 
            this.imageListAlarmStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAlarmStatus.ImageStream")));
            this.imageListAlarmStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAlarmStatus.Images.SetKeyName(0, "AlarmOk.png");
            this.imageListAlarmStatus.Images.SetKeyName(1, "alarmActive.png");
            this.imageListAlarmStatus.Images.SetKeyName(2, "AlarmAck.png");
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListAlarmStatus;
    }
}
