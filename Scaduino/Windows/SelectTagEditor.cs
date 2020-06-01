using Scaduino.Components;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Scaduino.Windows
{
    class SelectTagEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if ((provider != null) && (((IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService))) != null))
            {
                if (Editors.SelectTag.ShowDialog() == DialogResult.OK)
                {
                    value = Editors.SelectTag.SelectedTag;
                }
            }
            return value;
        }
    }
}
