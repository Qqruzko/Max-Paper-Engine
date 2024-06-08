using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using static HotKey;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MaxPaper_1._0
{

    public partial class MainForm : Form
    {
        public int mins=1;
        public bool anime;
        public bool vertical;
        public bool use_hotkeys;

        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;



        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(
    UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;

        public HotKey _hotKey = new HotKey();
        public MainForm()
        {
            use_hotkeys = Properties.Settings.Default.hotkeys_usage;
            vertical = Properties.Settings.Default.VerticalCheck;
            InitializeComponent();

            //_hotKey.KeyModifier = HotKey.KeyModifiers.Alt;
            //_hotKey.Key = Keys.X; //reg key
            //_hotKey.HotKeyPressed += notifyIcon_Click;
            if (textBox1.Text != "")
            {
                load_folders();
            }
            init();



        }
        async void init()
        {
            await PrintAsync();
        }
        void Print()
        {
            Thread.Sleep(mins * 100); //*60 
            
            if (anime == false)
            {
                check_vertical();

            }
            init();
        }

        // определение асинхронного метода
        async Task PrintAsync()
        {
            
            await Task.Run(() => Print());                // выполняется асинхронно
            
        }

        private void notifyIcon_Click(object sender, EventArgs e)//hotkey anime
        {
            if (use_hotkeys == true)
            {
                TouchGrassCheckbox.Checked = true;
                anime = true;
            }
            

            //if (WindowState == FormWindowState.Minimized)
            //{
            //    WindowState = FormWindowState.Normal;


            //}
            //else
            //{
            //    WindowState = FormWindowState.Minimized;


            //}
        }
        public void change_pic()
        {


            
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }
        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;

                load_folders();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.Visible==true)
            this.Hide(); // скрыть форму
            notifyIcon1.Visible = true; // показать иконку 
        }



     
       

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mins = Convert.ToInt32(TimerBox.Value);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            this.Show(); // открыть форму
            
            notifyIcon1.Visible = false; // скрыть иконку
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["CheckAnimeStart"] = anime;
            Properties.Settings.Default["FolderPathDefault"] = textBox1.Text.ToString();
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
        }
        string[] allfolders;
        string[] allfiles;
        private void button1_Click(object sender, EventArgs e)
        {
            check_vertical();
        }
        public void check_vertical()
        {
            string path = textBox1.Text.ToString();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Directory is empty");
            }
            if (System.IO.Directory.Exists(path))
            {
                if (vertical == false)
                {
                    load_image_horizontal();
                }
                else
                      if (vertical == true)
                {
                    load_image();
                }

            }
            else
                MessageBox.Show("Directory doesnt exist");
        }
        public void load_image()
        {

            

            string file_name;
            string folder_path = allfolders[new Random().Next(0, allfolders.Length)];
            //decide if folder or file in root 0-file 1-folder
            Random r = new Random();
            int rInt = r.Next(0, 2);
            if (rInt == 0)
            {
                string current_folder = textBox1.Text.ToString();

                allfiles = Directory.GetFiles(current_folder);

                file_name = allfiles[new Random().Next(0, allfiles.Length)];

                Image result_image = Image.FromFile(file_name);
                Bitmap bmp = new Bitmap(result_image);
                bmp = Convolve(bmp, GaussianBlur(1, 1)); //20 10
                var path1 = System.IO.Path.Combine(
           Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
           "Example.png");
                bmp.Save(path1);

                //Bitmap final =

                //SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, file_name, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
                test(file_name, path1);
            }
            else
            {






                string current_folder = allfolders[new Random().Next(0, allfolders.Length)];

                allfiles = Directory.GetFiles(current_folder);
                file_name = allfiles[new Random().Next(0, allfiles.Length)];

                   

                Image result_image = Image.FromFile(file_name);
                Bitmap bmp = new Bitmap(result_image);
                bmp = Convolve(bmp, GaussianBlur(1,1)); //20 10
                var path1 = System.IO.Path.Combine(
           Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
           "Example.png");
                bmp.Save(path1);

                //Bitmap final =

                //SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, file_name, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
                test(file_name, path1);





            }
        }

        public void load_image_horizontal()
        {
            string file_name;
            string folder_path = allfolders[new Random().Next(0, allfolders.Length)];
            string resultpath="";

            //decide if folder or file in root 0-file 1-folder
            Random r = new Random();
            int rInt = r.Next(0, 2);
            if (rInt == 0)
            {
                string current_folder = textBox1.Text.ToString();

                allfiles = Directory.GetFiles(current_folder);

                file_name = allfiles[new Random().Next(0, allfiles.Length)];
                Image image_checked = Image.FromFile(file_name);



                var bmp = new Bitmap(screenWidth, screenHeight);
                var gr = Graphics.FromImage(bmp);

                gr.FillRectangle(Brushes.Black, new Rectangle(0, 0, 100, 100)); //bmp.Width, bmp.Height

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(image_checked, 0, 0, screenWidth, screenHeight);
                }

                resultpath = System.IO.Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "Example.png");
                bmp.Save(resultpath);
            }
            else
            {






                string current_folder = allfolders[new Random().Next(0, allfolders.Length)];

                allfiles = Directory.GetFiles(current_folder);
                file_name = allfiles[new Random().Next(0, allfiles.Length)];

                Image image_checked = Image.FromFile(file_name);
                
                   

                    var bmp = new Bitmap(screenWidth, screenHeight);
                    var gr = Graphics.FromImage(bmp);

                    gr.FillRectangle(Brushes.Black, new Rectangle(0, 0, 100, 100)); //bmp.Width, bmp.Height

                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.DrawImage(image_checked, 0, 0, screenWidth, screenHeight);
                    }

                    resultpath = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Example.png");
                    bmp.Save(resultpath);
                
            }
           

            
           
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, resultpath, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);


        }
        public void test(string file_name, string path)
        {
            

            Image result_image = Image.FromFile(file_name);
            Bitmap bmp_blur = new Bitmap(result_image);
            bmp_blur = Convolve(bmp_blur, GaussianBlur(20, 10)); //20 10
            var path2 = System.IO.Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "Example.png");
            bmp_blur.Save(path2);


            Image lol = Image.FromFile(file_name);

            double koeff = (double)screenHeight/ lol.Height;
            

            int height_res =Convert.ToInt32(lol.Height * koeff);
            int width_res = Convert.ToInt32(lol.Width * koeff);

            int image_upper_left = screenWidth / 2 - width_res / 2;
            int image_upper_right = width_res;

            

            var bmp = new Bitmap(screenWidth, screenHeight);
            var gr = Graphics.FromImage(bmp);

            gr.FillRectangle(Brushes.Black, new Rectangle(0, 0, 100, 100)); //bmp.Width, bmp.Height

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(bmp_blur, 0, 0, width_res, screenHeight);
            }

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(bmp_blur, screenWidth- width_res, 0, width_res, screenHeight);
            }

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(lol, image_upper_left, 0, image_upper_right, screenHeight);
                
            }

            var path1 = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Example.png");
            bmp.Save(path1);
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path1, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
        public static double[,] GaussianBlur(int lenght, double weight)
        {
            double[,] kernel = new double[lenght, lenght];
            double kernelSum = 0;
            int foff = (lenght - 1) / 2;
            double distance = 0;
            double constant = 1d / (2 * Math.PI * weight * weight);
            for (int y = -foff; y <= foff; y++)
            {
                for (int x = -foff; x <= foff; x++)
                {
                    distance = ((y * y) + (x * x)) / (2 * weight * weight);
                    kernel[y + foff, x + foff] = constant * Math.Exp(-distance);
                    kernelSum += kernel[y + foff, x + foff];
                }
            }
            for (int y = 0; y < lenght; y++)
            {
                for (int x = 0; x < lenght; x++)
                {
                    kernel[y, x] = kernel[y, x] * 1d / kernelSum;
                }
            }
            return kernel;
        }
        public static Bitmap Convolve(Bitmap srcImage, double[,] kernel)
        {
            int width = srcImage.Width;
            int height = srcImage.Height;
            BitmapData srcData = srcImage.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            srcImage.UnlockBits(srcData);
            int colorChannels = 3;
            double[] rgb = new double[colorChannels];
            int foff = (kernel.GetLength(0) - 1) / 2;
            int kcenter = 0;
            int kpixel = 0;
            for (int y = foff; y < height - foff; y++)
            {
                for (int x = foff; x < width - foff; x++)
                {
                    for (int c = 0; c < colorChannels; c++)
                    {
                        rgb[c] = 0.0;
                    }
                    kcenter = y * srcData.Stride + x * 4;
                    for (int fy = -foff; fy <= foff; fy++)
                    {
                        for (int fx = -foff; fx <= foff; fx++)
                        {
                            kpixel = kcenter + fy * srcData.Stride + fx * 4;
                            for (int c = 0; c < colorChannels; c++)
                            {
                                rgb[c] += (double)(buffer[kpixel + c]) * kernel[fy + foff, fx + foff];
                            }
                        }
                    }
                    for (int c = 0; c < colorChannels; c++)
                    {
                        if (rgb[c] > 255)
                        {
                            rgb[c] = 255;
                        }
                        else if (rgb[c] < 0)
                        {
                            rgb[c] = 0;
                        }
                    }
                    for (int c = 0; c < colorChannels; c++)
                    {
                        result[kcenter + c] = (byte)rgb[c];
                    }
                    result[kcenter + 3] = 255;
                }
            }
            Bitmap resultImage = new Bitmap(width, height);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultImage.UnlockBits(resultData);
            return resultImage;
        }


        public void load_folders()
        {
            string path = textBox1.Text.ToString();
            allfolders = Directory.GetDirectories(path);
            allfiles = Directory.GetFiles(path);
        }
        

        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
            vertical = Convert.ToBoolean(checkBox2.CheckState);
            
        }

        private void button3_Click(object sender, EventArgs e) //default wallpaper
        {
            var bmp = new Bitmap(100, 100);
            var gr = Graphics.FromImage(bmp);

            gr.FillRectangle(Brushes.Black, new Rectangle(0, 0, bmp.Width, bmp.Height));
            var path = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Example.png");
            bmp.Save(path);


            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            System.IO.File.Delete(path);




        }
        
        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        public Contacts contacts1 = null;
        private void какМеняНайтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contacts1 == null)
            {
                contacts1 = new Contacts(this);

                contacts1.Show();

            }
        }
        public AdditionalSettingsForm addition = null;
        private void допНастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addition == null)
            {
                addition = new AdditionalSettingsForm(this);

                addition.Show();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TouchGrass(object sender, EventArgs e)
        {
            anime = Convert.ToBoolean(TouchGrassCheckbox.CheckState);
        }

        private void checkBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("При включенном состоянии растягивает изображение до разрешения экрана"+System.Environment.NewLine+"При выключенном - размывает", checkBox2);
        }

        private void checkBox2_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(checkBox2);
        }

        private void TouchGrassCheckbox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("При выключенном состоянии автоматически переключает обои", TouchGrassCheckbox);
        }

        private void TouchGrassCheckbox_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(TouchGrassCheckbox);
        }
    }
}
