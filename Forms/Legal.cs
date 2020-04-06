using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doom64_Unofficial_Configuration_Tool.Forms
{
    public partial class Legal : Form
    {
        readonly string ConfigDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Saved Games", "Nightdive Studios", "DOOM 64");

        public Legal()
        {
            InitializeComponent();
        }

        private void licenceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/SuiMachine/Doom-64-Unofficial-Configuration-Tool/blob/master/LICENSE.md");
        }

        private void link_Browse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Directory.Exists(ConfigDir))
                Process.Start(ConfigDir);

        }

        private void B_Yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void B_No_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
