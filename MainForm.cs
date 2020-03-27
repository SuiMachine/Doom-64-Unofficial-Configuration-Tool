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

namespace Doom64_Unofficial_Configuration_Tool
{
    public partial class MainForm : Form
    {
        readonly string ConfigDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Saved Games", "Nightdive Studios", "DOOM 64");
        readonly string ConfigFile = "kexengine.cfg";
        readonly string ConfigFileBackup = "kexengine.bak";


        //A dumb limitation with bindings is that they have to reference public properties. Sad.
        public KeyboardBindings keyBindings { get; set; }
        public VideoSettings videoSettings { get; set; }
        public OtherSettings otherSettings { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(ConfigDir))
                Directory.CreateDirectory(ConfigDir);

            if (!File.Exists(Path.Combine(ConfigDir, ConfigFile)))
                File.WriteAllText(Path.Combine(ConfigDir, ConfigFile), Properties.Resources._default);

            LoadConfig(Path.Combine(ConfigDir, ConfigFile));
        }

        private void LoadConfig(string fileToLoad)
        {
            keyBindings = new KeyboardBindings();
            videoSettings = new VideoSettings();
            otherSettings = new OtherSettings();

            string[] lines = File.ReadAllLines(fileToLoad);
            foreach(var line in lines)
            {
                if (line.StartsWithExt("bind"))
                {
                    keyBindings.TranslateFromBind(line);
                }
                else if (line.StartsWith("seta"))
                {
                    var strippedLine = line.StripChunk();
                    if(!videoSettings.ParseSetting(line))
                    {
                        otherSettings.ParseSetting(line);
                    }
                }
                else
                    otherSettings.otherSettings.Add(line);
            }

            SetupDataBindings();
        }

        private void SetupDataBindings()
        {
            toolTip_AdditionalInfo.SetToolTip(Label_FOVValue, "The first value is standard vertical FOV, while second is amount of degrees from the left to right side of a screen (horizontal FOV).");

            num_vidWidth.DataBindings.Add("Text", videoSettings, "v_width", false, DataSourceUpdateMode.OnPropertyChanged);
            num_vidHeight.DataBindings.Add("Text", videoSettings, "v_height", false, DataSourceUpdateMode.OnPropertyChanged);
            num_RefreshRate.DataBindings.Add("Text", videoSettings, "v_refresh", false, DataSourceUpdateMode.OnPropertyChanged);

            if (videoSettings.v_borderless)
                CB_DisplayMode.SelectedIndex = 2;
            else if(videoSettings.v_windowed)
                CB_DisplayMode.SelectedIndex = 1;
            else
                CB_DisplayMode.SelectedIndex = 0;

            ComBox_Renderer.DisplayMember = "Description";
            ComBox_Renderer.ValueMember = "value";
            ComBox_Renderer.DataSource = Enum.GetValues(typeof(RenderFamily)).Cast<Enum>().Select(value =>
                new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                     typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                }).OrderBy(item => item.value).ToList();
            ComBox_Renderer.DataBindings.Add("SelectedValue", videoSettings, "r_rhirenderfamily", false, DataSourceUpdateMode.OnPropertyChanged);

            CB_Vsync.DataBindings.Add("Checked", videoSettings, "v_vsync", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_Interpolation.DataBindings.Add("Checked", videoSettings, "cl_interpolation", false, DataSourceUpdateMode.OnPropertyChanged);

            TB_VerticalFOV.Value = (int)videoSettings.r_fov;

            CBox_CompileDX11Shaders.DataBindings.Add("Checked", videoSettings, "d3d11_compileShaders", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_DeveloperMode.DataBindings.Add("Checked", videoSettings, "developer", false, DataSourceUpdateMode.OnPropertyChanged);


            CB_Interpolation_CheckedChanged(null, null);
            TB_VerticalFOV_ValueChanged(null, null);

            TB_Language.DataBindings.Add("Text", otherSettings, "g_language", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_SkipIntros.DataBindings.Add("Checked", otherSettings, "g_showintromovie", false, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void UpdateNonBoundProperties()
        {
            videoSettings.r_fov = TB_VerticalFOV.Value;

            if(CB_DisplayMode.SelectedIndex == 2)
            {
                videoSettings.v_borderless = true;
                videoSettings.v_windowed = true;
            }
            else if(CB_DisplayMode.SelectedIndex == 1)
            {
                videoSettings.v_borderless = false;
                videoSettings.v_windowed = true;
            }
            else
            {
                videoSettings.v_borderless = false;
                videoSettings.v_windowed = false;
            }
        }

        #region Keybinds
        private void B_KeybindsEditWithEditor_Click(object sender, EventArgs e)
        {
            Forms.Keybinds_Editor editor = new Forms.Keybinds_Editor(keyBindings);
            var result = editor.ShowDialog();
            if(result == DialogResult.OK)
            {
                keyBindings = editor.keyBinds;
            }
        }

        private void B_KeybindsEditManually_Click(object sender, EventArgs e)
        {
            Forms.Keybinds_EditManually manualEditor = new Forms.Keybinds_EditManually(keyBindings.TranslateToBind());
            var result = manualEditor.ShowDialog();
            if(result == DialogResult.OK)
            {
                var newBinds = new KeyboardBindings();
                foreach(var line in manualEditor.bindContentTXT)
                {
                    newBinds.TranslateFromBind(line);
                }
                keyBindings = newBinds;
            }
        }

        private void B_Keybind_ResetToDefault_Click(object sender, EventArgs e)
        {
            var initialWarning = MessageBox.Show("All of the saved bindings will be lost. Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (initialWarning == DialogResult.No)
                return;

            Forms.Keybinds_DefaultSelection kdf = new Forms.Keybinds_DefaultSelection();
            var result = kdf.ShowDialog();
            if (result == DialogResult.OK)
            {
                switch (kdf.SelectedKeyboardLayout)
                {
                    case KeyboardLayout.QWERTY_WASD:
                        keyBindings.SetPreconfiguredQWERTY();
                        break;
                    case KeyboardLayout.AZERTY:
                        keyBindings.SetPreconfiguredAZERTY();
                        break;
                    case KeyboardLayout.QWERTY_ESDF:
                        keyBindings.SetPreconfiguredQWERTY_ESDF();
                        break;
                }
            }
        }
        #endregion

        private void CB_Interpolation_CheckedChanged(object sender, EventArgs e)
        {
            warning_Interpolation.Visible = !CB_Interpolation.Checked;
        }

        private void TB_VerticalFOV_ValueChanged(object sender, EventArgs e)
        {
            Label_FOVValue.Text = string.Format("{0}° (total horizontal: {1}°)", TB_VerticalFOV.Value, CalculateTotalFOV(videoSettings.v_width, videoSettings.v_height, TB_VerticalFOV.Value));
        }

        private float CalculateTotalFOV(uint v_width, uint v_height, int angle)
        {
            if(v_width >= 0 && v_height >= 0)
            {
                var VerticalRadians = Math.PI * angle / 180.0;
                var HorizontalRadians = 2 * Math.Atan(Math.Tan(VerticalRadians / 2) * (v_width * 1.0 / v_height * 1.0));
                return (float)(HorizontalRadians * (180.0 / Math.PI));
            }
            return angle;
        }

        private void ComBox_Renderer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReCheckDX11Requirements();
        }

        private void ReCheckDX11Requirements()
        {
            if(videoSettings.r_rhirenderfamily == RenderFamily.D3D11)
            {
                warning_DX11Compilation1.Visible = !CBox_CompileDX11Shaders.Checked;
                warning_DX11Compilation2.Visible = !CB_DeveloperMode.Checked;
            }
            else
            {
                warning_DX11Compilation1.Visible = false;
                warning_DX11Compilation2.Visible = false;
            }
        }

        private void CBox_CompileDX11Shaders_CheckedChanged(object sender, EventArgs e)
        {
            ReCheckDX11Requirements();
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, you want to cancel the changes and quit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(0);
            }
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            UpdateNonBoundProperties();

            try
            {
                if (!File.Exists(Path.Combine(ConfigDir, ConfigFileBackup)))
                {
                    if (File.Exists(Path.Combine(ConfigDir, ConfigFile)))
                        File.Copy(Path.Combine(ConfigDir, ConfigFile), Path.Combine(ConfigDir, ConfigFileBackup));
                }

                List<string> configLines = new List<string>();
                configLines.AddRange(keyBindings.TranslateToBind());
                configLines.AddRange(videoSettings.TranslateToConfig());
                configLines.AddRange(otherSettings.TranslateToConfig());
                File.WriteAllLines(Path.Combine(ConfigDir, ConfigFile), configLines);

                MessageBox.Show("Written new config file.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(IOException ex)
            {
                MessageBox.Show("IO exception. The config may be protected or currently in use.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkPCGW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.pcgamingwiki.com/wiki/Doom_64");
        }
    }
}
