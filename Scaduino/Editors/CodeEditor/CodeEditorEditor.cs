using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Scaduino.Editors
{
    public class CodeEditorEditor : UITypeEditor
    {
        private readonly string scaduinoDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Scaduino";

        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if ((provider != null) && (((IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService))) != null))
            {
                if (GlobalData.CodeDirectory == null || !Directory.Exists(GlobalData.CodeDirectory))
                {
                    System.IO.Directory.CreateDirectory(scaduinoDir);
                    var form1 = new CreateCodeDialog()
                    {
                        CodeName = "NewCode",
                        CodeDirectory = scaduinoDir,
                    };
                    if (form1.ShowDialog() == DialogResult.Cancel)
                    {
                        return value;
                    }
                    else
                    {
                        try
                        {
                            CreateCode(form1.CodeDirectory, form1.CodeName, GlobalData.SelectedArduino.GetCode());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.StackTrace);
                            throw;
                        }
                    }
                }
                var form2 = new CodeEditor();
                form2.DirectoryPath = GlobalData.CodeDirectory;
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    value = form2.DirectoryPath;
                }
            }
            return value;
        }

        private void CreateCode(string directory, string fileName, string content)
        {
            Directory.CreateDirectory(scaduinoDir);
            GlobalData.CodeDirectory = directory + "\\" + fileName;
            string dir = directory + "\\" + fileName;
            string file = dir + "\\" + fileName + ".ino";
            directory = file;
            Directory.CreateDirectory(dir);
            File.WriteAllText(directory, content);
        }
    }
}
