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
            this.gb_tone = new System.Windows.Forms.GroupBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.bt_color = new System.Windows.Forms.Button();
            this.gb_color.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_color
            // 
            this.gb_color.Controls.Add(this.bt_color);
            this.gb_color.Location = new System.Drawing.Point(12, 12);
            this.gb_color.Name = "gb_color";
            this.gb_color.Size = new System.Drawing.Size(260, 100);
            this.gb_color.TabIndex = 0;
            this.gb_color.TabStop = false;
            this.gb_color.Text = "Hintergrundfarbe";
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
            // bt_color
            // 
            this.bt_color.Location = new System.Drawing.Point(6, 19);
            this.bt_color.Name = "bt_color";
            this.bt_color.Size = new System.Drawing.Size(75, 23);
            this.bt_color.TabIndex = 2;
            this.bt_color.Text = "Farbe";
            this.bt_color.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gb_tone);
            this.Controls.Add(this.gb_color);
            this.Name = "Settings";
            this.Text = "Einstellungen";
            this.gb_color.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_color;
        private System.Windows.Forms.GroupBox gb_tone;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button bt_color;
    }
}