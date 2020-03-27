namespace Doom64_Unofficial_Configuration_Tool.CustomControls.BindEditor
{
    partial class BindAdd
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
            this.B_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_MouseX2 = new System.Windows.Forms.Button();
            this.B_MouseX1 = new System.Windows.Forms.Button();
            this.B_MouseRight = new System.Windows.Forms.Button();
            this.B_MouseMiddle = new System.Windows.Forms.Button();
            this.B_MouseLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.B_Cancel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // B_Cancel
            // 
            this.B_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.B_Cancel.Location = new System.Drawing.Point(722, 421);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 23);
            this.B_Cancel.TabIndex = 0;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 348);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(400, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 310);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(555, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gamepad";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(170, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mouse";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_MouseX2);
            this.panel1.Controls.Add(this.B_MouseX1);
            this.panel1.Controls.Add(this.B_MouseRight);
            this.panel1.Controls.Add(this.B_MouseMiddle);
            this.panel1.Controls.Add(this.B_MouseLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 310);
            this.panel1.TabIndex = 2;
            // 
            // B_MouseX2
            // 
            this.B_MouseX2.Location = new System.Drawing.Point(196, 142);
            this.B_MouseX2.Name = "B_MouseX2";
            this.B_MouseX2.Size = new System.Drawing.Size(68, 85);
            this.B_MouseX2.TabIndex = 4;
            this.B_MouseX2.Text = "Mouse Button 5";
            this.B_MouseX2.UseVisualStyleBackColor = true;
            this.B_MouseX2.Click += new System.EventHandler(this.B_MouseX2_Click);
            // 
            // B_MouseX1
            // 
            this.B_MouseX1.Location = new System.Drawing.Point(122, 142);
            this.B_MouseX1.Name = "B_MouseX1";
            this.B_MouseX1.Size = new System.Drawing.Size(68, 85);
            this.B_MouseX1.TabIndex = 3;
            this.B_MouseX1.Text = "Mouse Button 4";
            this.B_MouseX1.UseVisualStyleBackColor = true;
            this.B_MouseX1.Click += new System.EventHandler(this.B_MouseX1_Click);
            // 
            // B_MouseRight
            // 
            this.B_MouseRight.Location = new System.Drawing.Point(235, 51);
            this.B_MouseRight.Name = "B_MouseRight";
            this.B_MouseRight.Size = new System.Drawing.Size(68, 85);
            this.B_MouseRight.TabIndex = 2;
            this.B_MouseRight.Text = "Right Mouse Button";
            this.B_MouseRight.UseVisualStyleBackColor = true;
            this.B_MouseRight.Click += new System.EventHandler(this.B_MouseRight_Click);
            // 
            // B_MouseMiddle
            // 
            this.B_MouseMiddle.Location = new System.Drawing.Point(161, 51);
            this.B_MouseMiddle.Name = "B_MouseMiddle";
            this.B_MouseMiddle.Size = new System.Drawing.Size(68, 85);
            this.B_MouseMiddle.TabIndex = 1;
            this.B_MouseMiddle.Text = "Middle Mouse Button";
            this.B_MouseMiddle.UseVisualStyleBackColor = true;
            this.B_MouseMiddle.Click += new System.EventHandler(this.B_MouseMiddle_Click);
            // 
            // B_MouseLeft
            // 
            this.B_MouseLeft.Location = new System.Drawing.Point(87, 51);
            this.B_MouseLeft.Name = "B_MouseLeft";
            this.B_MouseLeft.Size = new System.Drawing.Size(68, 85);
            this.B_MouseLeft.TabIndex = 0;
            this.B_MouseLeft.Text = "Left Mouse Button";
            this.B_MouseLeft.UseVisualStyleBackColor = true;
            this.B_MouseLeft.Click += new System.EventHandler(this.B_MouseLeft_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press any keyboard key or select mouse or gamepad key below";
            // 
            // BindAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BindAdd";
            this.Text = "Bind Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BindEditor_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_MouseRight;
        private System.Windows.Forms.Button B_MouseMiddle;
        private System.Windows.Forms.Button B_MouseLeft;
        private System.Windows.Forms.Button B_MouseX2;
        private System.Windows.Forms.Button B_MouseX1;
    }
}