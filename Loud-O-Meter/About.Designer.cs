namespace Loud_O_Meter
{
    partial class About
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
            this.ll_homepage = new System.Windows.Forms.LinkLabel();
            this.ll_github = new System.Windows.Forms.LinkLabel();
            this.ll_project = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ll_homepage
            // 
            this.ll_homepage.AutoSize = true;
            this.ll_homepage.LinkArea = new System.Windows.Forms.LinkArea(10, 21);
            this.ll_homepage.Location = new System.Drawing.Point(12, 9);
            this.ll_homepage.Name = "ll_homepage";
            this.ll_homepage.Size = new System.Drawing.Size(175, 17);
            this.ll_homepage.TabIndex = 3;
            this.ll_homepage.TabStop = true;
            this.ll_homepage.Text = "Homepage: misterx-hp.3server.de";
            this.toolTip.SetToolTip(this.ll_homepage, "http://misterx-hp.3server.de/");
            this.ll_homepage.UseCompatibleTextRendering = true;
            this.ll_homepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_homepage_LinkClicked);
            // 
            // ll_github
            // 
            this.ll_github.AutoSize = true;
            this.ll_github.LinkArea = new System.Windows.Forms.LinkArea(8, 11);
            this.ll_github.Location = new System.Drawing.Point(12, 26);
            this.ll_github.Name = "ll_github";
            this.ll_github.Size = new System.Drawing.Size(109, 17);
            this.ll_github.TabIndex = 4;
            this.ll_github.TabStop = true;
            this.ll_github.Text = "GitHub: MisterX2000";
            this.toolTip.SetToolTip(this.ll_github, "https://github.com/MisterX2000");
            this.ll_github.UseCompatibleTextRendering = true;
            this.ll_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_github_LinkClicked);
            // 
            // ll_project
            // 
            this.ll_project.AutoSize = true;
            this.ll_project.LinkArea = new System.Windows.Forms.LinkArea(9, 12);
            this.ll_project.Location = new System.Drawing.Point(12, 43);
            this.ll_project.Name = "ll_project";
            this.ll_project.Size = new System.Drawing.Size(116, 17);
            this.ll_project.TabIndex = 5;
            this.ll_project.TabStop = true;
            this.ll_project.Text = "Projekt: Loud-O-Meter";
            this.toolTip.SetToolTip(this.ll_project, "https://github.com/MisterX2000/Loud-O-Meter");
            this.ll_project.UseCompatibleTextRendering = true;
            this.ll_project.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_project_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 66);
            this.Controls.Add(this.ll_project);
            this.Controls.Add(this.ll_github);
            this.Controls.Add(this.ll_homepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "Über";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel ll_homepage;
        private System.Windows.Forms.LinkLabel ll_github;
        private System.Windows.Forms.LinkLabel ll_project;
        private System.Windows.Forms.ToolTip toolTip;
    }
}