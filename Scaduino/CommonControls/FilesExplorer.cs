using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace CommonControls
{
    public partial class FilesExplorer : TreeView
    {
        private readonly List<string> filesList = new List<string>();

        private List<string> paths = new List<string>();
        private List<string> pathsNames = new List<String>();

        private bool hideEmptyFolders;

        /// <summary>
        /// List of Paths to be explored
        /// </summary>
        [
            Category("Explorer"),
            Description("List of Paths to be explored")]
        public string[] Paths { get => paths.ToArray(); set => paths = value.ToList(); }

        /// <summary>
        /// Path to be watched. Any directories or files alterations will be auto detected.
        /// </summary>
        [
            Category("Explorer"),
            Description("Path to be watched. Any directories or files alterations will be auto detected.")]
        public string WatchedPath { get => fileSystemWatcher.Path; set => fileSystemWatcher.Path = value; }

        /// <summary>
        /// Optional alternative names to Paths
        /// </summary>
        [
            Category("Explorer"),
            Description("Optional alternative names to Paths")]
        public string[] PathsNames { get => pathsNames.ToArray(); set => pathsNames = value.ToList(); }

        /// <summary>
        /// Hide empty folders
        /// </summary>
        [
            Category("Explorer"),
            Description("Hide empty folders")]
        public bool HideEmptyFolders { get => hideEmptyFolders; set => hideEmptyFolders = value; }

        /// <summary>
        /// Get selected file
        /// </summary>
        [
            Category("Explorer"),
            Description("Get selected file")]
        public string SelectedFile { get => SelectedNode.Tag?.ToString(); }

        /// <summary>
        /// Return a list of files
        /// </summary>
        public List<string> FilesList { get => filesList; }

        /// <summary>
        /// Refresh explorer
        /// </summary>
        public void UpdateExplorer()
        {
            string bkp = "";
            if (this.SelectedNode != null)
                bkp = this.SelectedNode.FullPath;
            this.Nodes.Clear();
            foreach (string path in paths)
            {
                if (Directory.Exists(path))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(path);
                    TreeNode node = this.Nodes.Add(dirInfo.Name);
                    if (pathsNames.Count > paths.IndexOf(path))
                        node.Text = pathsNames[paths.IndexOf(path)];
                    LoadFiles(path, node);
                    LoadSubDirectories(path, node);
                    if (bkp != "" & bkp != null)
                        this.SelectedNode = GetNode(bkp, this.Nodes);
                }
            }
            if (HideEmptyFolders)
                FilterEmptyNodes(Nodes);
        }

        private void UpdatePath(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            TreeNode node = Nodes.Add(dirInfo.Name);
            if (paths.Count > 0 && pathsNames.Count > paths.IndexOf(path))
                node.Text = pathsNames[paths.IndexOf(path)];
            LoadFiles(path, node);
            LoadSubDirectories(path, node);
        }

        private void FilterEmptyNodes(TreeNodeCollection nodes)
        {
            var list = nodes;
            Int32 i = 0;
            while (i <= list.Count - 1)
            {
                TreeNode node = (TreeNode)list[i];
                if (!File.Exists(node.Tag.ToString()))
                {
                    FilterEmptyNodes(node.Nodes);
                    if (node.Nodes.Count == 0)
                    {
                        nodes.Remove(node);
                        i -= 1;
                    }
                }
                i += 1;
            }
        }

        /// <summary>
        ///     ''' Search a node in explorer using fullPath key
        ///     ''' </summary>
        ///     ''' <param name="path">Path to be seek</param>
        ///     ''' <returns>Finded treeNode</returns>
        public TreeNode GetNode(string path, TreeNodeCollection parentCollection)
        {
            TreeNode ret = null;
            foreach (TreeNode child in parentCollection) // step through the parentcollection
            {
                if (child.FullPath == path.Replace("/", @"\"))
                    ret = child;
                else if (child.GetNodeCount(true) > 0)
                    ret = GetNode(path.Replace("/", @"\"), child.Nodes);
                if (ret != null)
                    break; // if something was found, exit out of the for loop
            }
            return ret;
        }

        public FilesExplorer()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private bool exitSearch = false;
        private TreeNode SearchByName(string name, TreeNodeCollection nodes, string continueMessage)
        {
            TreeNode ret = null;
            exitSearch = false;
            foreach (TreeNode child in nodes)
            {
                var childNodes = child.Nodes;
                continueSearch:               
                if (child.Text.ToLower().Contains(name.ToLower()))
                    return child;
                else if (child.GetNodeCount(true) > 0)
                {
                    ret = SearchByName(name, childNodes, continueMessage);
                    if (exitSearch)
                        break;
                }
                if (ret != null & this.SelectedNode != ret)
                {
                    this.SelectedNode = ret;
                    if (continueMessage == "") break;
                    var d = MessageBox.Show(continueMessage, "Explorer", MessageBoxButtons.YesNo);
                    if (d == DialogResult.No)
                    {
                        exitSearch = true;
                        break;
                    }
                    else
                    {
                        childNodes = ret.Nodes;
                        goto continueSearch;
                    }
                }
            }
            return ret;
        }

        private void LoadFiles(string path, TreeNode node)
        {
            string[] arquivos = Directory.GetFiles(path, "*.*");
            foreach (var file in arquivos)
            {
                FileInfo filInf = new FileInfo(file);
                TreeNode newNode = new TreeNode(filInf.Name);
                int imgIdx = -1;
                if (ImageList.Images.Keys.Contains(filInf.Extension))
                    imgIdx = ImageList.Images.IndexOfKey(filInf.Extension);
                if (ImageList.Images.Keys.Contains(filInf.Name))
                    imgIdx = ImageList.Images.IndexOfKey(filInf.Name);
                if(imgIdx >= 0)
                {
                    newNode.Tag = filInf.FullName;
                    newNode.SelectedImageIndex = imgIdx;
                    newNode.ImageIndex = imgIdx;
                    node.Nodes.Add(newNode);
                    FilesList.Add(filInf.FullName);
                }
            }
        }

        private void LoadSubDirectories(string path, TreeNode node)
        {
            string[] subDir = Directory.GetDirectories(path);
            foreach (var directory in subDir)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(directory);
                TreeNode newNode = node.Nodes.Add(dirInfo.Name);
                newNode.Tag = dirInfo.Name;
                int imgIdx = 0;
                if (ImageList.Images.Keys.Contains(dirInfo.Name))
                    imgIdx = ImageList.Images.IndexOfKey(dirInfo.Name);
                newNode.SelectedImageIndex = imgIdx;
                newNode.ImageIndex = imgIdx;
                newNode.Tag = dirInfo.FullName;
                LoadFiles(directory, newNode);
                LoadSubDirectories(directory, newNode);
            }
        }

        private void FileSystemWatcher_Modified(object sender, FileSystemEventArgs e)
        {
            UpdateExplorer();
            SelectedNode = SearchByName(e.Name, this.Nodes, "");
            SelectedNode.Expand();
        }

    }
}
