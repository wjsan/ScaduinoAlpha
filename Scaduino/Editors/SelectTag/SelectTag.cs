using Scaduino.Components;
using Scaduino.Protocols;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Scaduino.Editors
{
    public partial class SelectTag : Form
    {
        private CommunicationDriver[] driversSheet;
        private Tag[] Tags { get; set; }
        public Tag SelectedTag { get; set; }

        public SelectTag()
        {
            InitializeComponent();
            driversSheet = GlobalData.SelectedCommunicationChannels.Drivers;
        }

        private void SelectTag_Load(object sender, EventArgs e)
        {
            RenderTreeViewDrivers();
        }

        private void RenderTreeViewDrivers()
        {
            if (driversSheet == null) return;
            treeViewDrivers.Nodes.Clear();
            foreach (var driver in driversSheet)
            {
                treeViewDrivers.Nodes.Add(driver.Name);
            }
        }

        private void treeViewDrivers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RenderTreeViewTags();
        }

        private void RenderTreeViewTags()
        {
            if (driversSheet == null) return;
            if (treeViewDrivers.SelectedNode == null) return;
            int idx = treeViewDrivers.SelectedNode.Index;
            Tags = driversSheet[idx].Tags;
            treeViewTags.Nodes.Clear();
            foreach (var tag in Tags)
            {
                treeViewTags.Nodes.Add(tag.Name);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void treeViewTags_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewTags.SelectedNode!= null)
                SelectedTag = Tags[treeViewTags.SelectedNode.Index];
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (treeViewDrivers.SelectedNode == null) return;
            int idx = treeViewDrivers.SelectedNode.Index;
            var tags = GlobalData.SelectedCommunicationChannels.Drivers[idx].Tags.ToList();
            tags.Add(new Tag()
            {
                Name = textBoxNewTag.Text
            });
            GlobalData.SelectedCommunicationChannels.Drivers[idx].Tags = tags.ToArray();
            RenderTreeViewTags();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
