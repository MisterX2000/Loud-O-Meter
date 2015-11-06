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
            this.gb_color = new System.Windows.Forms.GroupBox();
            this.bt_color = new System.Windows.Forms.Button();
            this.gb_tone = new System.Windows.Forms.GroupBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.bt_reset = new System.Windows.Forms.Button();
            this.pb_color = new System.Windows.Forms.PictureBox();
            this.gb_color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_color
            // 
            this.gb_color.Controls.Add(this.pb_color);
            this.gb_color.Controls.Add(this.bt_color);
            this.gb_color.Location = new System.Drawing.Point(12, 12);
            this.gb_color.Name = "gb_color";
            this.gb_color.Size = new System.Drawing.Size(260, 100);
            this.gb_color.TabIndex = 0;
            this.gb_color.TabStop = false;
            this.gb_color.Text = "Hintergrundfarbe";
            // 
            // bt_color
            // 
            this.bt_color.Location = new System.Drawing.Point(35, 19);
            this.bt_color.Name = "bt_color";
            this.bt_color.Size = new System.Drawing.Size(75, 23);
            this.bt_color.TabIndex = 2;
            this.bt_color.Text = "Farbe";
            this.bt_color.UseVisualStyleBackColor = true;
            this.bt_color.Click += new System.EventHandler(this.bt_color_Click);
            // 
            // gb_tone
            // 
            this.gb_tone.Location = new System.Drawing.Point(12, 118);
            this.gb_tone.Name = "gb_tone";
            this.gb_tone.Size = new System.Drawing.Size(260, 100);
            this.gb_tone.TabIndex = 1;
            this.gb_tone.TabStop = false;
            this.gb_tone.Text = "Ton";
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(12, 226);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(75, 23);
            this.bt_reset.TabIndex = 2;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // pb_color
            // 
            this.pb_color.BackColor = System.Drawing.Color.Transparent;
            this.pb_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_color.Location = new System.Drawing.Point(6, 19);
            this.pb_color.Name = "pb_color";
            this.pb_color.Size = new System.Drawing.Size(23, 23);
            this.pb_color.TabIndex = 3;
            this.pb_color.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.gb_tone);
            this.Controls.Add(this.gb_color);
            this.Name = "Settings";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gb_color.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_color;
        private System.Windows.Forms.GroupBox gb_tone;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button bt_color;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.PictureBox pb_color;
    }
}