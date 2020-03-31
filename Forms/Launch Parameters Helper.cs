using Microsoft.Win32;
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
    public partial class Launch_Parameters_Helper : Form
    {
        string Doom64SteamLocation = "";
        string Doom64Location { get {
                if (Doom64SteamLocation != "")
                    return Doom64SteamLocation;
                else
                    return null; } }

        public Launch_Parameters_Helper()
        {
            InitializeComponent();
            Doom64SteamLocation = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Steam App 1148590", "InstallLocation", "").ToString();
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


            warning_CheatNoMonsters.Visible = CB_NoMonsters.Checked;
            CB_FastMonsters.Enabled = !CB_NoMonsters.Checked;
            if (CB_NoMonsters.Checked)
            {
                sb.Append("-nomonsters ");
                CB_FastMonsters.Checked = false;
            }
            else if (CB_FastMonsters.Checked)
                sb.Append("-fast ");

            if (TB_BasePath.Text != "")
                sb.Append("-basepath " + string.Format("\"{0}\"", TB_BasePath.Text) + " ");

            foreach(var file in ListBox_FilesToLoad.Items)
            {
                sb.Append("-file " + file.ToString() + " ");
            }

            TB_CMDParameters.Text = sb.ToString();

        }

        private void CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RebuildCmd();
        }

        private void TB_TextChanged(object sender, EventArgs e)
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

        private void B_Browse_BasePath_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog() { SelectedPath = Doom64Location, ShowNewFolderButton = true };
            var result = fbd.ShowDialog();
            if(result == DialogResult.OK)
            {
                if (Directory.Exists(fbd.SelectedPath))
                    TB_BasePath.Text = fbd.SelectedPath;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fbd = new OpenFileDialog() { InitialDirectory = Doom64Location, CheckPathExists = true, CheckFileExists = true, Filter = "*.wad|*.wad", Multiselect = true };
            var result = fbd.ShowDialog();
            if(result == DialogResult.OK)
            {
                foreach(var file in fbd.FileNames)
                {
                    if (Doom64Location != null)
                    {
                        if(file.StartsWith(Doom64Location))
                        {
                            var relativeLocation = file.Remove(0, Doom64Location.Length);
                            relativeLocation = relativeLocation.Trim(new char[] { '\\', '/' });
                            
                            ListBox_FilesToLoad.Items.Add(relativeLocation);
                        }
                        else
                            ListBox_FilesToLoad.Items.Add(string.Format("\"{0}\"", file));
                    }
                    else
                        ListBox_FilesToLoad.Items.Add(string.Format("\"{0}\"", file));
                }
                RebuildCmd();
            }
        }

        private void TB_CMDParameters_Click(object sender, EventArgs e)
        {
            if(TB_CMDParameters.Text != "")
            {
                Clipboard.SetText(TB_CMDParameters.Text);

                //Super junky way of manually setting tooltip
                ToolTip notification = new ToolTip() { ToolTipIcon = ToolTipIcon.Info, ToolTipTitle = "Notification" };
                var position = TB_CMDParameters.PointToScreen(Point.Empty);
                notification.Show("Content of this text box has been copied to clipboard.", this, 0, 0, 3000);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListBox_FilesToLoad.SelectedItem != null)
                ListBox_FilesToLoad.Items.Remove(ListBox_FilesToLoad.SelectedItem);
        }
    }
}
