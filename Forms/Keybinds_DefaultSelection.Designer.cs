namespace Doom64_Unofficial_Configuration_Tool.Forms
{
    partial class Keybinds_DefaultSelection
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.B_QWERTY = new System.Windows.Forms.Button();
            this.B_QWERTY_ESDF = new System.Windows.Forms.Button();
            this.B_AZERTY = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.B_QWERTY, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.B_QWERTY_ESDF, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.B_AZERTY, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(173, 149);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select keyboard layout:";
            // 
            // B_QWERTY
            // 
            this.B_QWERTY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_QWERTY.Location = new System.Drawing.Point(26, 37);
            this.B_QWERTY.Name = "B_QWERTY";
            this.B_QWERTY.Size = new System.Drawing.Size(120, 24);
            this.B_QWERTY.TabIndex = 1;
            this.B_QWERTY.Text = "QWERTY (WASD)";
            this.B_QWERTY.UseVisualStyleBackColor = true;
            this.B_QWERTY.Click += new System.EventHandler(this.B_QWERTY_Click);
            // 
            // B_QWERTY_ESDF
            // 
            this.B_QWERTY_ESDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_QWERTY_ESDF.Location = new System.Drawing.Point(26, 76);
            this.B_QWERTY_ESDF.Name = "B_QWERTY_ESDF";
            this.B_QWERTY_ESDF.Size = new System.Drawing.Size(120, 24);
            this.B_QWERTY_ESDF.TabIndex = 3;
            this.B_QWERTY_ESDF.Text = "QWERTY (ESDF)";
            this.B_QWERTY_ESDF.UseVisualStyleBackColor = true;
            this.B_QWERTY_ESDF.Click += new System.EventHandler(this.B_QWERTY_ESDF_Click);
            // 
            // B_AZERTY
            // 
            this.B_AZERTY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_AZERTY.Location = new System.Drawing.Point(26, 116);
            this.B_AZERTY.Name = "B_AZERTY";
            this.B_AZERTY.Size = new System.Drawing.Size(120, 24);
            this.B_AZERTY.TabIndex = 2;
            this.B_AZERTY.Text = "AZERTY";
            this.B_AZERTY.UseVisualStyleBackColor = true;
            this.B_AZERTY.Click += new System.EventHandler(this.B_AZERTY_Click);
            // 
            // Keybinds_DefaultSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 149);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Keybinds_DefaultSelection";
            this.Text = "Select layout";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button B_QWERTY_ESDF;
        private System.Windows.Forms.Button B_AZERTY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_QWERTY;
    }
}