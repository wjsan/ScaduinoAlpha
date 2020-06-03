using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Scaduino.Controls
{
    public class LabelStyle
    {
        /// <summary>
        /// Text to be displayed on label when style it
        /// </summary>
        [Description("Text to be displayed on label when style it")]
        public string Text { get; set; }

        /// <summary>
        /// Back color of label when style it
        /// </summary>
        [Description("Back color of label when style it")]
        public Color BackColor { get; set; }

        /// <summary>
        /// For color of label when style it
        /// </summary>
        [Description("For color of label when style it")]
        public Color ForeColor { get; set; }

        public void StyleLabel(Label label)
        {
            label.Text = Text;
            label.BackColor = BackColor;
            label.ForeColor = ForeColor;
        }
    }
}
