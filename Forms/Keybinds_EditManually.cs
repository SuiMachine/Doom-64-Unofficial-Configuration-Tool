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
    public partial class Keybinds_EditManually : Form
    {
        public string[] bindContentTXT { get; set; }

        public Keybinds_EditManually(string[] bindContentTXT)
        {
            InitializeComponent();
            this.bindContentTXT = bindContentTXT;
        }

        private void Keybinds_EditManually_Load(object sender, EventArgs e)
        {
            this.RB_BindContent.Lines = bindContentTXT;
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            this.bindContentTXT = RB_BindContent.Lines;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RB_BindContent_MultilineChanged(object sender, EventArgs e)
        {

        }
    }
}
