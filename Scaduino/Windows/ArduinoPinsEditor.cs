using Scaduino.ArduinoBoard;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Scaduino.Windows
{
    class ArduinoPinsEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if ((provider != null) && (((IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService))) != null))
            {
                var form = new ArduinoPins(value as Pin[]);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    value = form.Pins.ToArray();
                }
            }
            return value;
        }
    }
}
