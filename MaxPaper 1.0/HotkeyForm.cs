using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MaxPaper_1._0
{
    public partial class HotkeyForm : Form
    {
        public HotkeyForm(MainForm mainformref)
        {
            InitializeComponent();
            mainForm = mainformref;
            KeyPreview = true;


        }
        bool can_type = false;
        public MainForm mainForm;
        int milliseconds = 2000;
        private void HotkeyForm_Load(object sender, EventArgs e)
        {
            refresh_form();


        }
        void refresh_form()
        {
            string hotkey_label = string.Format("Current Hotkey: ");

            if (mainForm._hotKey.Key != Keys.None & mainForm._hotKey.KeyModifier != HotKey.KeyModifiers.None)
            {
                hotkey_label = string.Format("Current Hotkey: " + mainForm._hotKey.KeyModifier.ToString() + "+" + mainForm._hotKey.Key.ToString());

            }
            else
            if (mainForm._hotKey.KeyModifier != HotKey.KeyModifiers.None)
            {
                hotkey_label = string.Format("Current Hotkey: ");
                hotkey_label = hotkey_label + mainForm._hotKey.KeyModifier.ToString();
            }
            else
            if (mainForm._hotKey.Key != Keys.None)
            {
                hotkey_label = string.Format("Current Hotkey: ");
                hotkey_label = hotkey_label + mainForm._hotKey.Key.ToString();
            }
            else
                if (mainForm._hotKey.Key == Keys.None & mainForm._hotKey.KeyModifier == HotKey.KeyModifiers.None)
            {
                hotkey_label = string.Format("No hotkey set");

            }



            Hotkey_label.Text = hotkey_label;
        }

        private void Reset_hotkey_button_Click(object sender, EventArgs e)
        {
            reset_keys();
        }
        public void reset_keys()
        {
            mainForm._hotKey.KeyModifier = HotKey.KeyModifiers.None;
            mainForm._hotKey.Key = Keys.None;
            refresh_form();
        }
        private async void button1_Click(object sender, EventArgs e)
        {


            MessageBox.Show("If you need key modificator you can use Alt,Ctrl,Shift,WIN");
            reset_keys();
            can_type = true;
            
           await Timer_Tick();
            
        }
        bool timer_on = false;
        async Task Timer_Tick()
        {

            //pizdatina


            

            var tokenSource = new CancellationTokenSource();
            if (timer_on == true)
            {
                timer_on = false;
                tokenSource.Cancel();
                
            }
            
                

            try
            {
                
                timer_on = true;
               
                await Task.Delay(5000, tokenSource.Token);
                if (mainForm._hotKey.KeyModifier == HotKey.KeyModifiers.None & mainForm._hotKey.Key == Keys.None)
                {
                    if (timer_on == true)
                    {
                        MessageBox.Show("Input locked");
                        can_type = false;
                        timer_on = false;
                    }
                  
                }
                
            }
            catch (TaskCanceledException ex)
            {
                timer_on = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tokenSource.Dispose();
                tokenSource = null;
            }

          
               
               
            

            

        }




        private void HotkeyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (can_type != false)
            {
                if (mainForm._hotKey.KeyModifier == HotKey.KeyModifiers.None)
                {

                    switch (e.KeyCode)
                    {
                        case Keys.Menu:
                            mainForm._hotKey.KeyModifier = HotKey.KeyModifiers.Alt;

                            refresh_form();
                            break;
                        case Keys.ControlKey:
                            mainForm._hotKey.KeyModifier = HotKey.KeyModifiers.Control;

                            refresh_form();
                            break;
                        case Keys.ShiftKey:
                            mainForm._hotKey.KeyModifier = HotKey.KeyModifiers.Shift;

                            refresh_form();
                            break;
                        case Keys.LWin:
                            mainForm._hotKey.KeyModifier = HotKey.KeyModifiers.Windows;

                            refresh_form();
                            break;

                    }


                }
                if (mainForm._hotKey.Key == Keys.None & e.KeyCode != Keys.Menu & e.KeyCode != Keys.ControlKey & e.KeyCode != Keys.ShiftKey & e.KeyCode != Keys.LWin)
                {
                    mainForm._hotKey.Key = e.KeyCode;

                    refresh_form();
                }
            }
           

        }

        private void HotkeyForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void HotkeyForm_KeyUp(object sender, KeyEventArgs e)
        {
            
          
            
            
        }
    }
}
