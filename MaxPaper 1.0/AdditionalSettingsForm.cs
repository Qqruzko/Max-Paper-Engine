using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MaxPaper_1._0
{
    public partial class AdditionalSettingsForm : Form
    {
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        
        public AdditionalSettingsForm(MainForm mainFormRef)
        {
            bool autoload = Properties.Settings.Default.AutoLoad;
            InitializeComponent();
            mainForm = mainFormRef;
            
        }
        public MainForm mainForm;
        public bool autoload;
        
        private void AutoLoadCheck(object sender, EventArgs e)
        {
            
            if (autoload == true)
            {
                turn_off_autoload();
            }
            else
                turn_on_autoload();
            
               
        }
        public void turn_on_autoload()
        {
            // Add the value in the registry so that the application runs at startup
            rkApp.SetValue("My app's name", Application.ExecutablePath.ToString());
            autoload = true;
        }
        public void turn_off_autoload()
        {

            rkApp.DeleteValue("My app's name", false);
            autoload = false;
            
        }
        private void Reset_button_click(object sender, EventArgs e)
        {
            Properties.Settings.Default["CheckAnimeStart"] = false;
            Properties.Settings.Default["FolderPathDefault"] = "";

            Properties.Settings.Default["AutoLoad"] = false;
            Properties.Settings.Default.Save(); 
        }

        private void AdditionalSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["AutoLoad"] = Convert.ToBoolean(Autoload_checkbox.CheckState);
            Properties.Settings.Default["hotkeys_usage"] = Convert.ToBoolean(Hotkeys_checkbox.CheckState);
            Properties.Settings.Default.Save();
            mainForm.addition = null;
        }

        private void AdditionalSettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HotkeyForm hkform = new HotkeyForm(mainForm);
            hkform.ShowDialog();
        }

        private void Hotkeys_checkbox_Click(object sender, EventArgs e)
        {
            mainForm.use_hotkeys = Convert.ToBoolean(Hotkeys_checkbox.CheckState);
        }
    }
}
