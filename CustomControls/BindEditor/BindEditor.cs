using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doom64_Unofficial_Configuration_Tool.CustomControls.BindEditor
{
    public partial class BindEditor : Form
    {
        public List<KeyMouseWrapper> keysBound { get; set; }

        public BindEditor(List<KeyMouseWrapper> keysBound)
        {
            InitializeComponent();
            this.keysBound = keysBound;
        }

        private void BindEditor_Load(object sender, EventArgs e)
        {
            RefreshKeys();
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            var bAddForm = new BindAdd();
            var result = bAddForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                keysBound.Add(bAddForm.returnedKey);
            }
            RefreshKeys();
        }

        private void B_Remove_Click(object sender, EventArgs e)
        {
            var id = ListBox_Keys.SelectedIndex;
            if(id >= 0 && id < keysBound.Count)
            {
                keysBound.RemoveAt(id);
            }
            RefreshKeys();
        }

        private void RefreshKeys()
        {
            ListBox_Keys.Items.Clear();
            foreach(var key in keysBound)
            {
                ListBox_Keys.Items.Add(key.ToDescriptionString());
            }
        }
    }
}
