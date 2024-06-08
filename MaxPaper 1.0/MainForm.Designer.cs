
namespace MaxPaper_1._0
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.допНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какМеняНайтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.image_name_label = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Manual_wallpaper_set_bbt = new System.Windows.Forms.Button();
            this.Failed_images_counter_label = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TouchGrassCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.допНастройкиToolStripMenuItem,
            this.какМеняНайтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.toolStripMenuItem1.Text = "Выбрать папку";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // допНастройкиToolStripMenuItem
            // 
            this.допНастройкиToolStripMenuItem.Name = "допНастройкиToolStripMenuItem";
            this.допНастройкиToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.допНастройкиToolStripMenuItem.Text = "Доп.Настройки";
            this.допНастройкиToolStripMenuItem.Click += new System.EventHandler(this.допНастройкиToolStripMenuItem_Click);
            // 
            // какМеняНайтиToolStripMenuItem
            // 
            this.какМеняНайтиToolStripMenuItem.Name = "какМеняНайтиToolStripMenuItem";
            this.какМеняНайтиToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.какМеняНайтиToolStripMenuItem.Text = "Как меня найти";
            this.какМеняНайтиToolStripMenuItem.Click += new System.EventHandler(this.какМеняНайтиToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current folder:";
            // 
            // TimerBox
            // 
            this.TimerBox.Location = new System.Drawing.Point(9, 126);
            this.TimerBox.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.TimerBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(120, 20);
            this.TimerBox.TabIndex = 5;
            this.TimerBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimerBox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minutes to change";
            // 
            // image_name_label
            // 
            this.image_name_label.AutoSize = true;
            this.image_name_label.Location = new System.Drawing.Point(326, 56);
            this.image_name_label.Name = "image_name_label";
            this.image_name_label.Size = new System.Drawing.Size(35, 13);
            this.image_name_label.TabIndex = 7;
            this.image_name_label.Text = "label3";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Manual_wallpaper_set_bbt
            // 
            this.Manual_wallpaper_set_bbt.Location = new System.Drawing.Point(28, 290);
            this.Manual_wallpaper_set_bbt.Name = "Manual_wallpaper_set_bbt";
            this.Manual_wallpaper_set_bbt.Size = new System.Drawing.Size(92, 34);
            this.Manual_wallpaper_set_bbt.TabIndex = 8;
            this.Manual_wallpaper_set_bbt.Text = "Set image manually";
            this.Manual_wallpaper_set_bbt.UseVisualStyleBackColor = true;
            this.Manual_wallpaper_set_bbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Failed_images_counter_label
            // 
            this.Failed_images_counter_label.AutoSize = true;
            this.Failed_images_counter_label.Location = new System.Drawing.Point(176, 133);
            this.Failed_images_counter_label.Name = "Failed_images_counter_label";
            this.Failed_images_counter_label.Size = new System.Drawing.Size(35, 13);
            this.Failed_images_counter_label.TabIndex = 11;
            this.Failed_images_counter_label.Text = "label3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "Set Default Wallpaper Manually";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::MaxPaper_1._0.Properties.Settings.Default.VerticalCheck;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaxPaper_1._0.Properties.Settings.Default, "VerticalCheck", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(179, 83);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Vertical images ok?";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox2_MouseClick);
            this.checkBox2.MouseLeave += new System.EventHandler(this.checkBox2_MouseLeave);
            this.checkBox2.MouseHover += new System.EventHandler(this.checkBox2_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MaxPaper_1._0.Properties.Settings.Default, "FolderPathDefault", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(6, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = global::MaxPaper_1._0.Properties.Settings.Default.FolderPathDefault;
            // 
            // TouchGrassCheckbox
            // 
            this.TouchGrassCheckbox.AutoSize = true;
            this.TouchGrassCheckbox.Checked = global::MaxPaper_1._0.Properties.Settings.Default.CheckAnimeStart;
            this.TouchGrassCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaxPaper_1._0.Properties.Settings.Default, "CheckAnimeStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TouchGrassCheckbox.Location = new System.Drawing.Point(6, 83);
            this.TouchGrassCheckbox.Name = "TouchGrassCheckbox";
            this.TouchGrassCheckbox.Size = new System.Drawing.Size(90, 17);
            this.TouchGrassCheckbox.TabIndex = 0;
            this.TouchGrassCheckbox.Text = "Touch Grass &";
            this.TouchGrassCheckbox.UseVisualStyleBackColor = true;
            this.TouchGrassCheckbox.CheckedChanged += new System.EventHandler(this.TouchGrass);
            this.TouchGrassCheckbox.MouseLeave += new System.EventHandler(this.TouchGrassCheckbox_MouseLeave);
            this.TouchGrassCheckbox.MouseHover += new System.EventHandler(this.TouchGrassCheckbox_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.Failed_images_counter_label);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TimerBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.TouchGrassCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 218);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Manual_wallpaper_set_bbt);
            this.Controls.Add(this.image_name_label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaxPaperEngine 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TouchGrassCheckbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TimerBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label image_name_label;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button Manual_wallpaper_set_bbt;
        private System.Windows.Forms.Label Failed_images_counter_label;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem допНастройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какМеняНайтиToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

