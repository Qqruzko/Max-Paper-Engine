namespace MaxPaper_1._0
{
    partial class AdditionalSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalSettingsForm));
            this.button1 = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Hotkeys_checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Autoload_checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Настроить сочетание клавиш";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(50, 43);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(134, 38);
            this.Reset_button.TabIndex = 2;
            this.Reset_button.Text = "Сброс всех настроек и полей";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_click);
            // 
            // Hotkeys_checkbox
            // 
            this.Hotkeys_checkbox.AutoSize = true;
            this.Hotkeys_checkbox.Location = new System.Drawing.Point(29, 23);
            this.Hotkeys_checkbox.Name = "Hotkeys_checkbox";
            this.Hotkeys_checkbox.Size = new System.Drawing.Size(115, 17);
            this.Hotkeys_checkbox.TabIndex = 4;
            this.Hotkeys_checkbox.Text = "Включить хоткей ";
            this.Hotkeys_checkbox.UseVisualStyleBackColor = true;
            this.Hotkeys_checkbox.Click += new System.EventHandler(this.Hotkeys_checkbox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Hotkeys_checkbox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(21, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Горячие клавиши";
            // 
            // Autoload_checkbox
            // 
            this.Autoload_checkbox.AutoSize = true;
            this.Autoload_checkbox.Checked = global::MaxPaper_1._0.Properties.Settings.Default.AutoLoad;
            this.Autoload_checkbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaxPaper_1._0.Properties.Settings.Default, "AutoLoad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Autoload_checkbox.Location = new System.Drawing.Point(21, 105);
            this.Autoload_checkbox.Name = "Autoload_checkbox";
            this.Autoload_checkbox.Size = new System.Drawing.Size(202, 17);
            this.Autoload_checkbox.TabIndex = 1;
            this.Autoload_checkbox.Text = "Автозагрузка при старте системы";
            this.Autoload_checkbox.UseVisualStyleBackColor = true;
            this.Autoload_checkbox.CheckedChanged += new System.EventHandler(this.AutoLoadCheck);
            // 
            // AdditionalSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 275);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Autoload_checkbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdditionalSettingsForm";
            this.Text = "AdditionalSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdditionalSettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.AdditionalSettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Autoload_checkbox;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.CheckBox Hotkeys_checkbox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}