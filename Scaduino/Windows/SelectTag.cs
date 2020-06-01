using Scaduino.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scaduino.Windows
{
    public partial class SelectTag : Form
    {
        public Tag[] Tags { get; set; }
        public Tag SelectedTag { get; set; }

        public SelectTag()
        {
            InitializeComponent();
        }

        private void SelectTag_Load(object sender, EventArgs e)
        {
            comboBoxTags.SelectedItem = null;
            if (Tags == null)
            {
                return;
            }
            comboBoxTags.Items.Clear();
            foreach (var tag in Tags)
            {
                comboBoxTags.Items.Add(tag.Name);
                if(SelectedTag == tag)
                {
                    comboBoxTags.SelectedItem = tag.Name;
                }
            }
        }

        private void comboBoxTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTags.SelectedItem != null)
                SelectedTag = Tags[comboBoxTags.SelectedIndex];
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
