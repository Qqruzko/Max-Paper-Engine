namespace MaxPaper_1._0
{
    partial class HotkeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotkeyForm));
            this.button1 = new System.Windows.Forms.Button();
            this.Reset_hotkey_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Hotkey_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset_hotkey_button
            // 
            this.Reset_hotkey_button.Location = new System.Drawing.Point(174, 98);
            this.Reset_hotkey_button.Name = "Reset_hotkey_button";
            this.Reset_hotkey_button.Size = new System.Drawing.Size(75, 23);
            this.Reset_hotkey_button.TabIndex = 1;
            this.Reset_hotkey_button.Text = "Reset";
            this.Reset_hotkey_button.UseVisualStyleBackColor = true;
            this.Reset_hotkey_button.Click += new System.EventHandler(this.Reset_hotkey_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press two keys";
            // 
            // Hotkey_label
            // 
            this.Hotkey_label.AutoSize = true;
            this.Hotkey_label.Location = new System.Drawing.Point(88, 57);
            this.Hotkey_label.Name = "Hotkey_label";
            this.Hotkey_label.Size = new System.Drawing.Size(118, 13);
            this.Hotkey_label.TabIndex = 3;
            this.Hotkey_label.Text = "Current Hotkey: Shift+X";
            // 
            // HotkeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 141);
            this.Controls.Add(this.Hotkey_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset_hotkey_button);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotkeyForm";
            this.Text = "Hotkeys";
            this.Load += new System.EventHandler(this.HotkeyForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HotkeyForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Reset_hotkey_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Hotkey_label;
    }
}