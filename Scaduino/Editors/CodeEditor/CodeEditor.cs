using Scaduino.ArduinoBoard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Scaduino.Editors
{
    public partial class CodeEditor : Form
    {
        public string DirectoryPath
        {
            get => filesExplorer.WatchedPath;
            set
            {
                var dir = new List<string>();
                dir.Add(value);
                filesExplorer.Paths = dir.ToArray();
                filesExplorer.WatchedPath = value;
            }
        }

        public CodeEditor()
        {
            InitializeComponent();
        }

        private void filesExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (filesExplorer.SelectedNode == null || filesExplorer.SelectedFile == null) return;
                if (File.Exists(filesExplorer.SelectedFile))
                {
                    var file = new FileInfo(filesExplorer.SelectedFile);
                    fastColoredTextBox.OpenFile(file.FullName);
                    screenHeaderFileName.Text = file.Name;
                    fastColoredTextBox.Visible = true;
                    codeStyle.SetStyles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                throw;
            }
            
        }

        private void CodeEditor_Load(object sender, EventArgs e)
        {
            try
            {
                filesExplorer.UpdateExplorer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                throw;
            }
        }
    }
}
