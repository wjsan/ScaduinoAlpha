using Scaduino.Windows;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Scaduino.ArduinoBoard
{
   [DesignTimeVisible(false)]
   public partial class CodeManager : Component
    {
        private Arduino arduino;
        private readonly string scaduinoDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Scaduino";

        /// <summary>
        /// Directory path of source code file
        /// </summary>
        [Description("Directory path of source code file")]
        [Editor(typeof(FileNameEditor), typeof(UITypeEditor))]
        public string CodeDirectory { get; set; }

        /// <summary>
        /// Generate source code for scaduino communication
        /// </summary>
        [Description("Generate source code for scaduino communication")]
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

        /// <summary>
        /// Save scaduino modifications to source code file
        /// </summary>
        [Description("Save scaduino modifications to source code file")]
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

        /// <summary>
        /// Open source code on external editor
        /// </summary>
        [Description("Open source code on external editor")]
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
