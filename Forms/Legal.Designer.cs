namespace Doom64_Unofficial_Configuration_Tool.Forms
{
    partial class Legal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Legal));
            this.label1 = new System.Windows.Forms.Label();
            this.licenceLink = new System.Windows.Forms.LinkLabel();
            this.link_Browse = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Yes = new System.Windows.Forms.Button();
            this.B_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(946, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // licenceLink
            // 
            this.licenceLink.AutoSize = true;
            this.licenceLink.LinkArea = new System.Windows.Forms.LinkArea(100, 112);
            this.licenceLink.Location = new System.Drawing.Point(12, 9);
            this.licenceLink.Name = "licenceLink";
            this.licenceLink.Size = new System.Drawing.Size(571, 17);
            this.licenceLink.TabIndex = 1;
            this.licenceLink.TabStop = true;
            this.licenceLink.Text = "This software is distributed and written under MIT Licence. For exact licence agr" +
    "eement, please see Github page.";
            this.licenceLink.UseCompatibleTextRendering = true;
            this.licenceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.licenceLink_LinkClicked);
            // 
            // link_Browse
            // 
            this.link_Browse.AutoSize = true;
            this.link_Browse.LinkArea = new System.Windows.Forms.LinkArea(116, 50);
            this.link_Browse.Location = new System.Drawing.Point(15, 112);
            this.link_Browse.Name = "link_Browse";
            this.link_Browse.Size = new System.Drawing.Size(889, 17);
            this.link_Browse.TabIndex = 3;
            this.link_Browse.TabStop = true;
            this.link_Browse.Text = "This program may save additional information to provide better end user experienc" +
    "e. Files stored will be located in %USEPROFILE%\\Saved Games\\Nightdive Studios\\DO" +
    "OM 64";
            this.link_Browse.UseCompatibleTextRendering = true;
            this.link_Browse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Browse_LinkClicked);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(946, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do you confirm you\'ve read the following terms of use and want to continue?";
            // 
            // B_Yes
            // 
            this.B_Yes.Location = new System.Drawing.Point(414, 156);
            this.B_Yes.Name = "B_Yes";
            this.B_Yes.Size = new System.Drawing.Size(75, 23);
            this.B_Yes.TabIndex = 5;
            this.B_Yes.Text = "Yes";
            this.B_Yes.UseVisualStyleBackColor = true;
            this.B_Yes.Click += new System.EventHandler(this.B_Yes_Click);
            // 
            // B_No
            // 
            this.B_No.Location = new System.Drawing.Point(495, 156);
            this.B_No.Name = "B_No";
            this.B_No.Size = new System.Drawing.Size(75, 23);
            this.B_No.TabIndex = 6;
            this.B_No.Text = "No";
            this.B_No.UseVisualStyleBackColor = true;
            this.B_No.Click += new System.EventHandler(this.B_No_Click);
            // 
            // Legal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 189);
            this.Controls.Add(this.B_No);
            this.Controls.Add(this.B_Yes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.link_Browse);
            this.Controls.Add(this.licenceLink);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Legal";
            this.Text = "Legal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel licenceLink;
        private System.Windows.Forms.LinkLabel link_Browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Yes;
        private System.Windows.Forms.Button B_No;
    }
}