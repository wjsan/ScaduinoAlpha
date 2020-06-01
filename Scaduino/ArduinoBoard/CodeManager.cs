using Scaduino.Windows;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Scaduino.ArduinoBoard
{
    public partial class CodeManager : Component
    {
        private Arduino arduino;
        private readonly string scaduinoDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Scaduino";

        public string CodeDirectory { get; set; }

        public bool CreateCode
        {
            get => false;
            set
            {
                if (value)
                {
                    System.IO.Directory.CreateDirectory(scaduinoDir);
                    CreateCodeDialog createCodeDialog = new CreateCodeDialog()
                    {
                        CodeName = "NewCode",
                        CodeDirectory = scaduinoDir,
                    };
                    if(createCodeDialog.ShowDialog() == DialogResult.OK)
                    {
                        string dir = createCodeDialog.CodeDirectory + "\\" + createCodeDialog.CodeName;
                        string file = dir + "\\" + createCodeDialog.CodeName + ".ino";
                        CodeDirectory = file;
                        System.IO.Directory.CreateDirectory(dir);
                        System.IO.File.WriteAllText(CodeDirectory, arduino.GetCode());
                        if (createCodeDialog.OpenCode)
                            Open = true;
                    }
                }
            }
        }

        public bool Save
        {
            get => false;
            set
            {
                if (value && File.Exists(CodeDirectory))
                {
                    System.IO.File.WriteAllText(CodeDirectory, arduino.GetCode());
                }
                else
                {
                    CreateCode = true;
                }
            }
        }

        public bool Open
        {
            get => false;
            set
            {
                if (value && File.Exists(CodeDirectory))
                {
                    Save = true;
                    System.Diagnostics.Process.Start(CodeDirectory);
                }
            }
        }

        public CodeManager()
        {
            InitializeComponent();
        }

        public CodeManager(Arduino arduino)
        {
            InitializeComponent();
            this.arduino = arduino;
        }

        public CodeManager(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
