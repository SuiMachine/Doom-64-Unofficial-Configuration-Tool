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
    public partial class BindAdd : Form
    {
        public KeyMouseWrapper returnedKey = new KeyMouseWrapper();

        public BindAdd()
        {
            InitializeComponent();
            this.Select();
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BindEditor_KeyDown(object sender, KeyEventArgs e)
        {
            var keyID = (int)e.KeyCode;
            this.returnedKey = (D64Keys)keyID;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void B_MouseLeft_Click(object sender, EventArgs e)
        {
            this.returnedKey = D64Keys.mouse_left;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void B_MouseMiddle_Click(object sender, EventArgs e)
        {
            this.returnedKey = D64Keys.mouse_middle;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void B_MouseRight_Click(object sender, EventArgs e)
        {
            this.returnedKey = D64Keys.mouse_right;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void B_MouseX1_Click(object sender, EventArgs e)
        {
            this.returnedKey = D64Keys.mouse_misc1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void B_MouseX2_Click(object sender, EventArgs e)
        {
            this.returnedKey = D64Keys.mouse_misc2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
