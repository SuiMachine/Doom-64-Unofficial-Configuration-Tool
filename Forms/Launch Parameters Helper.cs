using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doom64_Unofficial_Configuration_Tool.Forms
{
    public partial class Launch_Parameters_Helper : Form
    {
        public Launch_Parameters_Helper()
        {
            InitializeComponent();
        }

        private void link_CMDGuide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.pcgamingwiki.com/wiki/Glossary:Command_line_arguments");
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Launch_Parameters_Helper_Load(object sender, EventArgs e)
        {
            CBox_DisplayMode.SelectedIndex = 0;
            Cbox_Difficulty.SelectedIndex = 0;
            TB_ForceWidth.Text = "0";
            TB_ForceHeight.Text = "0";
        }

        private void RebuildCmd()
        {
            StringBuilder sb = new StringBuilder();
            if(uint.TryParse(TB_ForceWidth.Text, out uint ResolutionX) && uint.TryParse(TB_ForceHeight.Text, out uint ResolutionY))
            {
                if (ResolutionX >= 640 && ResolutionY >= 480)
                {
                    sb.Append(string.Format("-width {0} ", ResolutionX));
                    sb.Append(string.Format("-height {0} ", ResolutionY));

                }
            }

            if (CBox_DisplayMode.SelectedIndex == 1)
                sb.Append("-window ");
            else if (CBox_DisplayMode.SelectedIndex == 2)
                sb.Append("-fullscreen ");

            if (CB_SkipIntro.Checked)
                sb.Append("-skipmovies ");

            if (numValue_LevelID.Value > 0)
                sb.Append(string.Format("-warp {0} -skill {1} ", numValue_LevelID.Value, Cbox_Difficulty.SelectedIndex+1));

            if(CB_NoMonsters.Checked)
                sb.Append("-nomonsters ");
            else if (CB_FastMonsters.Checked)
                sb.Append("-fast ");

            TB_CMDParameters.Text = sb.ToString();

        }

        private void CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RebuildCmd();
        }

        private void TB_ForceRes_TextChanged(object sender, EventArgs e)
        {
            RebuildCmd();
        }

        private void CB_CheckedChanged(object sender, EventArgs e)
        {
            RebuildCmd();
        }

        private void numValue_LevelID_ValueChanged(object sender, EventArgs e)
        {
            RebuildCmd();
        }
    }
}
