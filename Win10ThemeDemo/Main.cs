using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win10ThemeDemo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            menuBar1.AddMenuItem(Properties.Resources.Searching_magnifying_glass_24, "Trolololol 1", panel1);
            menuBar1.AddMenuItem(Properties.Resources.Searching_magnifying_glass_24, "Trolololol 2", null);
            menuBar1.AddMenuItem(Properties.Resources.Searching_magnifying_glass_24, "Trolololol 3", null);
            menuBar1.AddMenuItem(Properties.Resources.Searching_magnifying_glass_24, "Trolololol 4", null);
            menuBar1.AddMenuItem(Properties.Resources.Searching_magnifying_glass_24, "Trolololol 5", null);



            menuBar1.AddStatusBarItem(new Button() { Dock = DockStyle.Right });
        }
    }
}
