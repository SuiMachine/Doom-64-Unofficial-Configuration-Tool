namespace Doom64_Unofficial_Configuration_Tool.CustomControls
{
    partial class KeyControlForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.B_EditKeys = new System.Windows.Forms.Button();
            this.labelActionName = new System.Windows.Forms.Label();
            this.TB_MenuActivate = new System.Windows.Forms.TextBox();
            this.B_AddKey = new System.Windows.Forms.Button();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.95699F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.04301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel4.Controls.Add(this.B_EditKeys, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelActionName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.TB_MenuActivate, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.B_AddKey, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(407, 124);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // B_EditKeys
            // 
            this.B_EditKeys.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_EditKeys.Location = new System.Drawing.Point(363, 50);
            this.B_EditKeys.Name = "B_EditKeys";
            this.B_EditKeys.Size = new System.Drawing.Size(33, 23);
            this.B_EditKeys.TabIndex = 3;
            this.B_EditKeys.Text = "Edit";
            this.B_EditKeys.UseVisualStyleBackColor = true;
            this.B_EditKeys.Click += new System.EventHandler(this.B_EditKeys_Click);
            this.B_EditKeys.Paint += new System.Windows.Forms.PaintEventHandler(this.B_EditKeys_Paint);
            // 
            // labelActionName
            // 
            this.labelActionName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelActionName.AutoSize = true;
            this.labelActionName.Location = new System.Drawing.Point(3, 55);
            this.labelActionName.Name = "labelActionName";
            this.labelActionName.Size = new System.Drawing.Size(78, 13);
            this.labelActionName.TabIndex = 0;
            this.labelActionName.Text = "B_ActionName";
            // 
            // TB_MenuActivate
            // 
            this.TB_MenuActivate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_MenuActivate.Location = new System.Drawing.Point(99, 52);
            this.TB_MenuActivate.Name = "TB_MenuActivate";
            this.TB_MenuActivate.ReadOnly = true;
            this.TB_MenuActivate.Size = new System.Drawing.Size(209, 20);
            this.TB_MenuActivate.TabIndex = 1;
            this.TB_MenuActivate.Text = "B_KeysHere";
            // 
            // B_AddKey
            // 
            this.B_AddKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_AddKey.Location = new System.Drawing.Point(323, 50);
            this.B_AddKey.Name = "B_AddKey";
            this.B_AddKey.Size = new System.Drawing.Size(24, 23);
            this.B_AddKey.TabIndex = 2;
            this.B_AddKey.Text = "+";
            this.B_AddKey.UseVisualStyleBackColor = true;
            this.B_AddKey.Click += new System.EventHandler(this.B_AddKey_Click);
            // 
            // KeyControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "KeyControlForm";
            this.Size = new System.Drawing.Size(407, 124);
            this.Load += new System.EventHandler(this.KeyControlForm_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button B_EditKeys;
        private System.Windows.Forms.Label labelActionName;
        private System.Windows.Forms.TextBox TB_MenuActivate;
        private System.Windows.Forms.Button B_AddKey;
    }
}
