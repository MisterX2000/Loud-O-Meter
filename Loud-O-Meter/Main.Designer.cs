namespace Loud_O_Meter
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_volume = new System.Windows.Forms.ProgressBar();
            this.t_volume = new System.Windows.Forms.Timer(this.components);
            this.l_volume = new System.Windows.Forms.Label();
            this.nud_timer = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tb_volume = new System.Windows.Forms.TrackBar();
            this.nud_volume = new System.Windows.Forms.NumericUpDown();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_volume = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_volume)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.gb_volume.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_volume
            // 
            this.pb_volume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_volume.Location = new System.Drawing.Point(12, 27);
            this.pb_volume.Name = "pb_volume";
            this.pb_volume.Size = new System.Drawing.Size(260, 23);
            this.pb_volume.Step = 1;
            this.pb_volume.TabIndex = 0;
            // 
            // t_volume
            // 
            this.t_volume.Enabled = true;
            this.t_volume.Interval = 1;
            this.t_volume.Tick += new System.EventHandler(this.t_volume_Tick);
            // 
            // l_volume
            // 
            this.l_volume.AutoSize = true;
            this.l_volume.Location = new System.Drawing.Point(12, 53);
            this.l_volume.Name = "l_volume";
            this.l_volume.Size = new System.Drawing.Size(21, 13);
            this.l_volume.TabIndex = 1;
            this.l_volume.Text = "0%";
            this.toolTip.SetToolTip(this.l_volume, "Lautstärke");
            // 
            // nud_timer
            // 
            this.nud_timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_timer.Location = new System.Drawing.Point(222, 56);
            this.nud_timer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_timer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_timer.Name = "nud_timer";
            this.nud_timer.Size = new System.Drawing.Size(50, 20);
            this.nud_timer.TabIndex = 2;
            this.toolTip.SetToolTip(this.nud_timer, "Zeitangabe in Millisekunden");
            this.nud_timer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_timer.ValueChanged += new System.EventHandler(this.nud_timer_ValueChanged);
            // 
            // tb_volume
            // 
            this.tb_volume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_volume.LargeChange = 10;
            this.tb_volume.Location = new System.Drawing.Point(6, 19);
            this.tb_volume.Maximum = 100;
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(248, 45);
            this.tb_volume.TabIndex = 3;
            this.tb_volume.TickFrequency = 5;
            this.toolTip.SetToolTip(this.tb_volume, "Lautstärke in Prozent");
            this.tb_volume.Scroll += new System.EventHandler(this.tb_volume_Scroll);
            // 
            // nud_volume
            // 
            this.nud_volume.Location = new System.Drawing.Point(6, 70);
            this.nud_volume.Name = "nud_volume";
            this.nud_volume.Size = new System.Drawing.Size(50, 20);
            this.nud_volume.TabIndex = 4;
            this.toolTip.SetToolTip(this.nud_volume, "Lautstärke in Prozent");
            this.nud_volume.ValueChanged += new System.EventHandler(this.nud_volume_ValueChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem,
            this.überToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(284, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // gb_volume
            // 
            this.gb_volume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_volume.Controls.Add(this.label1);
            this.gb_volume.Controls.Add(this.tb_volume);
            this.gb_volume.Controls.Add(this.nud_volume);
            this.gb_volume.Location = new System.Drawing.Point(12, 82);
            this.gb_volume.Name = "gb_volume";
            this.gb_volume.Size = new System.Drawing.Size(260, 100);
            this.gb_volume.TabIndex = 6;
            this.gb_volume.TabStop = false;
            this.gb_volume.Text = "Warnung";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(216, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "0 = Aus";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aktualisierungsrate:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_volume);
            this.Controls.Add(this.nud_timer);
            this.Controls.Add(this.l_volume);
            this.Controls.Add(this.pb_volume);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(160, 233);
            this.Name = "Main";
            this.Text = "Loud-O-Meter";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_volume)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gb_volume.ResumeLayout(false);
            this.gb_volume.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_volume;
        private System.Windows.Forms.Timer t_volume;
        private System.Windows.Forms.Label l_volume;
        private System.Windows.Forms.NumericUpDown nud_timer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TrackBar tb_volume;
        private System.Windows.Forms.NumericUpDown nud_volume;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

