namespace Loud_O_Meter
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.nud_timer)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_volume
            // 
            this.pb_volume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_volume.Location = new System.Drawing.Point(12, 226);
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
            this.l_volume.Location = new System.Drawing.Point(12, 210);
            this.l_volume.Name = "l_volume";
            this.l_volume.Size = new System.Drawing.Size(21, 13);
            this.l_volume.TabIndex = 1;
            this.l_volume.Text = "0%";
            // 
            // nud_timer
            // 
            this.nud_timer.Location = new System.Drawing.Point(222, 200);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nud_timer);
            this.Controls.Add(this.l_volume);
            this.Controls.Add(this.pb_volume);
            this.Name = "Form1";
            this.Text = "Loud-O-Meter";
            ((System.ComponentModel.ISupportInitialize)(this.nud_timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_volume;
        private System.Windows.Forms.Timer t_volume;
        private System.Windows.Forms.Label l_volume;
        private System.Windows.Forms.NumericUpDown nud_timer;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

