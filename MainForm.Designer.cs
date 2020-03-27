namespace Doom64_Unofficial_Configuration_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.B_Keybind_ResetToDefault = new System.Windows.Forms.Button();
            this.B_KeybindsEditManually = new System.Windows.Forms.Button();
            this.B_KeybindsEditWithEditor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.warning_DX11Compilation2 = new System.Windows.Forms.PictureBox();
            this.CB_DeveloperMode = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.warning_DX11Compilation1 = new System.Windows.Forms.PictureBox();
            this.CBox_CompileDX11Shaders = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Label_FOVValue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_VerticalFOV = new System.Windows.Forms.TrackBar();
            this.warning_Interpolation = new System.Windows.Forms.PictureBox();
            this.CB_Interpolation = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_Vsync = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ComBox_Renderer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_DisplayMode = new System.Windows.Forms.ComboBox();
            this.num_RefreshRate = new System.Windows.Forms.NumericUpDown();
            this.num_vidHeight = new System.Windows.Forms.NumericUpDown();
            this.num_vidWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CB_SkipIntros = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TB_Language = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.toolTipWarning = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_AdditionalInfo = new System.Windows.Forms.ToolTip(this.components);
            this.linkPCGW = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warning_DX11Compilation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning_DX11Compilation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_VerticalFOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning_Interpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_RefreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vidHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vidWidth)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 341);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.B_Cancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.B_Save, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkPCGW, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 310);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(318, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // B_Cancel
            // 
            this.B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Cancel.Location = new System.Drawing.Point(238, 3);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 22);
            this.B_Cancel.TabIndex = 1;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // B_Save
            // 
            this.B_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Save.Location = new System.Drawing.Point(153, 3);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(75, 22);
            this.B_Save.TabIndex = 0;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(318, 301);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(114, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Other settings:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(115, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Video settings";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(119, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key bindings";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.B_Keybind_ResetToDefault, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.B_KeybindsEditManually, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.B_KeybindsEditWithEditor, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 25);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(310, 34);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // B_Keybind_ResetToDefault
            // 
            this.B_Keybind_ResetToDefault.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Keybind_ResetToDefault.Location = new System.Drawing.Point(209, 5);
            this.B_Keybind_ResetToDefault.Name = "B_Keybind_ResetToDefault";
            this.B_Keybind_ResetToDefault.Size = new System.Drawing.Size(98, 23);
            this.B_Keybind_ResetToDefault.TabIndex = 2;
            this.B_Keybind_ResetToDefault.Text = "Reset to defaults";
            this.B_Keybind_ResetToDefault.UseVisualStyleBackColor = true;
            this.B_Keybind_ResetToDefault.Click += new System.EventHandler(this.B_Keybind_ResetToDefault_Click);
            // 
            // B_KeybindsEditManually
            // 
            this.B_KeybindsEditManually.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_KeybindsEditManually.Location = new System.Drawing.Point(110, 5);
            this.B_KeybindsEditManually.Name = "B_KeybindsEditManually";
            this.B_KeybindsEditManually.Size = new System.Drawing.Size(88, 23);
            this.B_KeybindsEditManually.TabIndex = 1;
            this.B_KeybindsEditManually.Text = "Edit manually";
            this.B_KeybindsEditManually.UseVisualStyleBackColor = true;
            this.B_KeybindsEditManually.Click += new System.EventHandler(this.B_KeybindsEditManually_Click);
            // 
            // B_KeybindsEditWithEditor
            // 
            this.B_KeybindsEditWithEditor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_KeybindsEditWithEditor.Location = new System.Drawing.Point(7, 5);
            this.B_KeybindsEditWithEditor.Name = "B_KeybindsEditWithEditor";
            this.B_KeybindsEditWithEditor.Size = new System.Drawing.Size(88, 23);
            this.B_KeybindsEditWithEditor.TabIndex = 0;
            this.B_KeybindsEditWithEditor.Text = "Edit with editor";
            this.B_KeybindsEditWithEditor.UseVisualStyleBackColor = true;
            this.B_KeybindsEditWithEditor.Click += new System.EventHandler(this.B_KeybindsEditWithEditor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.warning_DX11Compilation2);
            this.panel1.Controls.Add(this.CB_DeveloperMode);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.warning_DX11Compilation1);
            this.panel1.Controls.Add(this.CBox_CompileDX11Shaders);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.Label_FOVValue);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TB_VerticalFOV);
            this.panel1.Controls.Add(this.warning_Interpolation);
            this.panel1.Controls.Add(this.CB_Interpolation);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.CB_Vsync);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ComBox_Renderer);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CB_DisplayMode);
            this.panel1.Controls.Add(this.num_RefreshRate);
            this.panel1.Controls.Add(this.num_vidHeight);
            this.panel1.Controls.Add(this.num_vidWidth);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 152);
            this.panel1.TabIndex = 3;
            // 
            // warning_DX11Compilation2
            // 
            this.warning_DX11Compilation2.Image = global::Doom64_Unofficial_Configuration_Tool.Properties.Resources.warning;
            this.warning_DX11Compilation2.InitialImage = null;
            this.warning_DX11Compilation2.Location = new System.Drawing.Point(286, 131);
            this.warning_DX11Compilation2.Name = "warning_DX11Compilation2";
            this.warning_DX11Compilation2.Size = new System.Drawing.Size(16, 14);
            this.warning_DX11Compilation2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.warning_DX11Compilation2.TabIndex = 27;
            this.warning_DX11Compilation2.TabStop = false;
            this.toolTipWarning.SetToolTip(this.warning_DX11Compilation2, "DirectX 11 shaders are outdated and needs to be recompiled at launch. This option" +
        " is needed for recompilation.");
            // 
            // CB_DeveloperMode
            // 
            this.CB_DeveloperMode.AutoSize = true;
            this.CB_DeveloperMode.Location = new System.Drawing.Point(269, 131);
            this.CB_DeveloperMode.Name = "CB_DeveloperMode";
            this.CB_DeveloperMode.Size = new System.Drawing.Size(15, 14);
            this.CB_DeveloperMode.TabIndex = 26;
            this.CB_DeveloperMode.UseVisualStyleBackColor = true;
            this.CB_DeveloperMode.CheckedChanged += new System.EventHandler(this.CBox_CompileDX11Shaders_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(176, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Developer Mode:";
            // 
            // warning_DX11Compilation1
            // 
            this.warning_DX11Compilation1.Image = global::Doom64_Unofficial_Configuration_Tool.Properties.Resources.warning;
            this.warning_DX11Compilation1.InitialImage = null;
            this.warning_DX11Compilation1.Location = new System.Drawing.Point(148, 131);
            this.warning_DX11Compilation1.Name = "warning_DX11Compilation1";
            this.warning_DX11Compilation1.Size = new System.Drawing.Size(16, 14);
            this.warning_DX11Compilation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.warning_DX11Compilation1.TabIndex = 24;
            this.warning_DX11Compilation1.TabStop = false;
            this.toolTipWarning.SetToolTip(this.warning_DX11Compilation1, "DirectX 11 shaders are outdated and needs to be recompiled at launch. This option" +
        " is needed for recompilation.");
            // 
            // CBox_CompileDX11Shaders
            // 
            this.CBox_CompileDX11Shaders.AutoSize = true;
            this.CBox_CompileDX11Shaders.Location = new System.Drawing.Point(127, 131);
            this.CBox_CompileDX11Shaders.Name = "CBox_CompileDX11Shaders";
            this.CBox_CompileDX11Shaders.Size = new System.Drawing.Size(15, 14);
            this.CBox_CompileDX11Shaders.TabIndex = 23;
            this.CBox_CompileDX11Shaders.UseVisualStyleBackColor = true;
            this.CBox_CompileDX11Shaders.CheckedChanged += new System.EventHandler(this.CBox_CompileDX11Shaders_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Compile DX11 shaders:";
            // 
            // Label_FOVValue
            // 
            this.Label_FOVValue.Location = new System.Drawing.Point(69, 112);
            this.Label_FOVValue.Name = "Label_FOVValue";
            this.Label_FOVValue.Size = new System.Drawing.Size(233, 20);
            this.Label_FOVValue.TabIndex = 21;
            this.Label_FOVValue.Text = "74";
            this.Label_FOVValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 26);
            this.label11.TabIndex = 20;
            this.label11.Text = "Vertical\r\n FOV:";
            // 
            // TB_VerticalFOV
            // 
            this.TB_VerticalFOV.Location = new System.Drawing.Point(66, 77);
            this.TB_VerticalFOV.Maximum = 140;
            this.TB_VerticalFOV.Minimum = 74;
            this.TB_VerticalFOV.Name = "TB_VerticalFOV";
            this.TB_VerticalFOV.Size = new System.Drawing.Size(236, 45);
            this.TB_VerticalFOV.TabIndex = 19;
            this.TB_VerticalFOV.Value = 74;
            this.TB_VerticalFOV.ValueChanged += new System.EventHandler(this.TB_VerticalFOV_ValueChanged);
            // 
            // warning_Interpolation
            // 
            this.warning_Interpolation.Image = global::Doom64_Unofficial_Configuration_Tool.Properties.Resources.warning;
            this.warning_Interpolation.InitialImage = null;
            this.warning_Interpolation.Location = new System.Drawing.Point(286, 56);
            this.warning_Interpolation.Name = "warning_Interpolation";
            this.warning_Interpolation.Size = new System.Drawing.Size(16, 14);
            this.warning_Interpolation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.warning_Interpolation.TabIndex = 18;
            this.warning_Interpolation.TabStop = false;
            this.toolTipWarning.SetToolTip(this.warning_Interpolation, "Interpolation fills in blanks between the original internal FPS - leave this opti" +
        "on enable in playing on FPS higher than 30.");
            // 
            // CB_Interpolation
            // 
            this.CB_Interpolation.AutoSize = true;
            this.CB_Interpolation.Location = new System.Drawing.Point(269, 57);
            this.CB_Interpolation.Name = "CB_Interpolation";
            this.CB_Interpolation.Size = new System.Drawing.Size(15, 14);
            this.CB_Interpolation.TabIndex = 17;
            this.CB_Interpolation.UseVisualStyleBackColor = true;
            this.CB_Interpolation.CheckedChanged += new System.EventHandler(this.CB_Interpolation_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Interpolation:";
            // 
            // CB_Vsync
            // 
            this.CB_Vsync.AutoSize = true;
            this.CB_Vsync.Location = new System.Drawing.Point(269, 5);
            this.CB_Vsync.Name = "CB_Vsync";
            this.CB_Vsync.Size = new System.Drawing.Size(15, 14);
            this.CB_Vsync.TabIndex = 15;
            this.CB_Vsync.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "V-sync:";
            // 
            // ComBox_Renderer
            // 
            this.ComBox_Renderer.FormattingEnabled = true;
            this.ComBox_Renderer.Location = new System.Drawing.Point(72, 3);
            this.ComBox_Renderer.Name = "ComBox_Renderer";
            this.ComBox_Renderer.Size = new System.Drawing.Size(145, 21);
            this.ComBox_Renderer.TabIndex = 13;
            this.ComBox_Renderer.SelectedIndexChanged += new System.EventHandler(this.ComBox_Renderer_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Renderer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Display mode:";
            // 
            // CB_DisplayMode
            // 
            this.CB_DisplayMode.FormattingEnabled = true;
            this.CB_DisplayMode.Items.AddRange(new object[] {
            "Fullscreen",
            "Windowed",
            "Borderless"});
            this.CB_DisplayMode.Location = new System.Drawing.Point(79, 54);
            this.CB_DisplayMode.Name = "CB_DisplayMode";
            this.CB_DisplayMode.Size = new System.Drawing.Size(116, 21);
            this.CB_DisplayMode.TabIndex = 10;
            // 
            // num_RefreshRate
            // 
            this.num_RefreshRate.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.num_RefreshRate.Location = new System.Drawing.Point(240, 28);
            this.num_RefreshRate.Maximum = new decimal(new int[] {
            244,
            0,
            0,
            0});
            this.num_RefreshRate.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_RefreshRate.Name = "num_RefreshRate";
            this.num_RefreshRate.Size = new System.Drawing.Size(45, 20);
            this.num_RefreshRate.TabIndex = 9;
            this.num_RefreshRate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // num_vidHeight
            // 
            this.num_vidHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_vidHeight.Location = new System.Drawing.Point(156, 28);
            this.num_vidHeight.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_vidHeight.Name = "num_vidHeight";
            this.num_vidHeight.Size = new System.Drawing.Size(61, 20);
            this.num_vidHeight.TabIndex = 8;
            this.num_vidHeight.ValueChanged += new System.EventHandler(this.TB_VerticalFOV_ValueChanged);
            // 
            // num_vidWidth
            // 
            this.num_vidWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_vidWidth.Location = new System.Drawing.Point(72, 28);
            this.num_vidWidth.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_vidWidth.Name = "num_vidWidth";
            this.num_vidWidth.Size = new System.Drawing.Size(61, 20);
            this.num_vidWidth.TabIndex = 7;
            this.num_vidWidth.ValueChanged += new System.EventHandler(this.TB_VerticalFOV_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "@";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resolution:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CB_SkipIntros);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.TB_Language);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 30);
            this.panel2.TabIndex = 5;
            // 
            // CB_SkipIntros
            // 
            this.CB_SkipIntros.AutoSize = true;
            this.CB_SkipIntros.Location = new System.Drawing.Point(247, 6);
            this.CB_SkipIntros.Name = "CB_SkipIntros";
            this.CB_SkipIntros.Size = new System.Drawing.Size(15, 14);
            this.CB_SkipIntros.TabIndex = 28;
            this.CB_SkipIntros.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(176, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Show intros:";
            // 
            // TB_Language
            // 
            this.TB_Language.Location = new System.Drawing.Point(70, 4);
            this.TB_Language.Name = "TB_Language";
            this.TB_Language.Size = new System.Drawing.Size(94, 20);
            this.TB_Language.TabIndex = 29;
            this.toolTipWarning.SetToolTip(this.TB_Language, "Careful with ediiting it. If you don\'t know what you\'re doing, better set the lan" +
        "guage in game!");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Language:";
            // 
            // toolTipWarning
            // 
            this.toolTipWarning.AutoPopDelay = 5000;
            this.toolTipWarning.InitialDelay = 500;
            this.toolTipWarning.ReshowDelay = 100;
            this.toolTipWarning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipWarning.ToolTipTitle = "Warning";
            // 
            // toolTip_AdditionalInfo
            // 
            this.toolTip_AdditionalInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_AdditionalInfo.ToolTipTitle = "Additional information";
            // 
            // linkPCGW
            // 
            this.linkPCGW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkPCGW.AutoSize = true;
            this.linkPCGW.Location = new System.Drawing.Point(3, 7);
            this.linkPCGW.Name = "linkPCGW";
            this.linkPCGW.Size = new System.Drawing.Size(110, 13);
            this.linkPCGW.TabIndex = 2;
            this.linkPCGW.TabStop = true;
            this.linkPCGW.Text = "PCGamingWiki Article";
            this.linkPCGW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPCGW_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Doom 64 Unofficial Configuration Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warning_DX11Compilation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning_DX11Compilation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_VerticalFOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning_Interpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_RefreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vidHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vidWidth)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button B_KeybindsEditManually;
        private System.Windows.Forms.Button B_KeybindsEditWithEditor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Keybind_ResetToDefault;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown num_RefreshRate;
        private System.Windows.Forms.NumericUpDown num_vidHeight;
        private System.Windows.Forms.NumericUpDown num_vidWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_DisplayMode;
        private System.Windows.Forms.CheckBox CB_Vsync;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ComBox_Renderer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox warning_Interpolation;
        private System.Windows.Forms.CheckBox CB_Interpolation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTipWarning;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar TB_VerticalFOV;
        private System.Windows.Forms.Label Label_FOVValue;
        private System.Windows.Forms.ToolTip toolTip_AdditionalInfo;
        private System.Windows.Forms.PictureBox warning_DX11Compilation2;
        private System.Windows.Forms.CheckBox CB_DeveloperMode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox warning_DX11Compilation1;
        private System.Windows.Forms.CheckBox CBox_CompileDX11Shaders;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TB_Language;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox CB_SkipIntros;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.LinkLabel linkPCGW;
    }
}

