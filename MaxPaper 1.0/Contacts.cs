using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxPaper_1._0
{
    public partial class Contacts : Form
    {
        public Contacts(MainForm mainref)
        {
            InitializeComponent();
            main = mainref;
        }
        MainForm main = null;
        private void Contacts_Load(object sender, EventArgs e)
        {

        }

        private void Contacts_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.contacts1 = null;
        }
    }
}
