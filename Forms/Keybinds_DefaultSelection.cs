using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doom64_Unofficial_Configuration_Tool.Forms
{
    public partial class Keybinds_DefaultSelection : Form
    {
        public KeyboardLayout SelectedKeyboardLayout { get; set; }

        public Keybinds_DefaultSelection()
        {
            SelectedKeyboardLayout = KeyboardLayout.QWERTY_WASD;
            InitializeComponent();
        }

        private void B_QWERTY_Click(object sender, EventArgs e)
        {
            this.SelectedKeyboardLayout = KeyboardLayout.QWERTY_WASD;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void B_AZERTY_Click(object sender, EventArgs e)
        {
            this.SelectedKeyboardLayout = KeyboardLayout.AZERTY;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void B_QWERTY_ESDF_Click(object sender, EventArgs e)
        {
            this.SelectedKeyboardLayout = KeyboardLayout.QWERTY_ESDF;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
