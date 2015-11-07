namespace Loud_O_Meter
{
    partial class Settings
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
            this.gb_color = new System.Windows.Forms.GroupBox();
            this.pb_color = new System.Windows.Forms.PictureBox();
            this.bt_color = new System.Windows.Forms.Button();
            this.gb_tone = new System.Windows.Forms.GroupBox();
            this.bt_path = new System.Windows.Forms.Button();
            this.lb_path = new System.Windows.Forms.Label();
            this.cb_custom = new System.Windows.Forms.CheckBox();
            this.cb_tone = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.bt_reset = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gb_color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).BeginInit();
            this.gb_tone.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_color
            // 
            this.gb_color.Controls.Add(this.pb_color);
            this.gb_color.Controls.Add(this.bt_color);
            this.gb_color.Location = new System.Drawing.Point(12, 12);
            this.gb_color.Name = "gb_color";
            this.gb_color.Size = new System.Drawing.Size(160, 50);
            this.gb_color.TabIndex = 0;
            this.gb_color.TabStop = false;
            this.gb_color.Text = "Hintergrundfarbe";
            // 
            // pb_color
            // 
            this.pb_color.BackColor = System.Drawing.Color.Transparent;
            this.pb_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_color.Location = new System.Drawing.Point(6, 19);
            this.pb_color.Name = "pb_color";
            this.pb_color.Size = new System.Drawing.Size(67, 23);
            this.pb_color.TabIndex = 3;
            this.pb_color.TabStop = false;
            // 
            // bt_color
            // 
            this.bt_color.Location = new System.Drawing.Point(79, 19);
            this.bt_color.Name = "bt_color";
            this.bt_color.Size = new System.Drawing.Size(75, 23);
            this.bt_color.TabIndex = 2;
            this.bt_color.Text = "Auswählen";
            this.bt_color.UseVisualStyleBackColor = true;
            this.bt_color.Click += new System.EventHandler(this.bt_color_Click);
            // 
            // gb_tone
            // 
            this.gb_tone.Controls.Add(this.bt_path);
            this.gb_tone.Controls.Add(this.lb_path);
            this.gb_tone.Controls.Add(this.cb_custom);
            this.gb_tone.Controls.Add(this.cb_tone);
            this.gb_tone.Location = new System.Drawing.Point(12, 68);
            this.gb_tone.Name = "gb_tone";
            this.gb_tone.Size = new System.Drawing.Size(160, 115);
            this.gb_tone.TabIndex = 1;
            this.gb_tone.TabStop = false;
            this.gb_tone.Text = "Ton";
            // 
            // bt_path
            // 
            this.bt_path.Enabled = false;
            this.bt_path.Location = new System.Drawing.Point(6, 69);
            this.bt_path.Name = "bt_path";
            this.bt_path.Size = new System.Drawing.Size(75, 23);
            this.bt_path.TabIndex = 3;
            this.bt_path.Text = "Auswählen";
            this.bt_path.UseVisualStyleBackColor = true;
            this.bt_path.Click += new System.EventHandler(this.bt_path_Click);
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Enabled = false;
            this.lb_path.Location = new System.Drawing.Point(6, 95);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(10, 13);
            this.lb_path.TabIndex = 2;
            this.lb_path.Text = "-";
            // 
            // cb_custom
            // 
            this.cb_custom.AutoSize = true;
            this.cb_custom.Location = new System.Drawing.Point(6, 46);
            this.cb_custom.Name = "cb_custom";
            this.cb_custom.Size = new System.Drawing.Size(62, 17);
            this.cb_custom.TabIndex = 1;
            this.cb_custom.Text = "Eigener";
            this.cb_custom.UseVisualStyleBackColor = true;
            this.cb_custom.CheckedChanged += new System.EventHandler(this.cb_custom_CheckedChanged);
            // 
            // cb_tone
            // 
            this.cb_tone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_tone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_tone.Items.AddRange(new object[] {
            "Asterisk",
            "Beep",
            "Exclamation",
            "Hand",
            "Question"});
            this.cb_tone.Location = new System.Drawing.Point(6, 19);
            this.cb_tone.Name = "cb_tone";
            this.cb_tone.Size = new System.Drawing.Size(148, 21);
            this.cb_tone.TabIndex = 0;
            this.cb_tone.SelectedIndexChanged += new System.EventHandler(this.cb_tone_SelectedIndexChanged);
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(12, 189);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(160, 23);
            this.bt_reset.TabIndex = 2;
            this.bt_reset.Text = "Reset";
            this.toolTip.SetToolTip(this.bt_reset, "Setzt alle Einstellungen zurück");
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 223);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.gb_tone);
            this.Controls.Add(this.gb_color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gb_color.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).EndInit();
            this.gb_tone.ResumeLayout(false);
            this.gb_tone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_color;
        private System.Windows.Forms.GroupBox gb_tone;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button bt_color;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.PictureBox pb_color;
        private System.Windows.Forms.ComboBox cb_tone;
        private System.Windows.Forms.CheckBox cb_custom;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.Button bt_path;
        private System.Windows.Forms.ToolTip toolTip;
    }
}