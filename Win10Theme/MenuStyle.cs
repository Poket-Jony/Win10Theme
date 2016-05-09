using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win10Theme
{
    public partial class MenuStyle: UserControl
    {
        private bool pnlLeftStatus = false;

        public MenuStyle()
        {
            InitializeComponent();
        }

        private void picBoxMenuButton_Click(object sender, EventArgs e)
        {
            if(pnlLeftStatus)
            {
                pnlLeft.Width = pnlLeft.MinimumSize.Width;
            }
            else
            {
                pnlLeft.Width = 200;
            }
            pnlLeftStatus = !pnlLeftStatus;
        }

        public void AddStatusBarItem(Control content)
        {
            pnlStatusBar.Controls.Add(content);
        }

        public void AddMenuItem(Image icon, string name, Control content)
        {
            MenuItem item = new MenuItem(icon, name, content);
            item.Dock = DockStyle.Top;
            item.Click += Item_Click;
            flowPnlMenuItems.Controls.Add(item);
        }

        private void Item_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            for(int i = 0; i < flowPnlMenuItems.Controls.Count; i++)
            {
                MenuItem citem = (MenuItem)flowPnlMenuItems.Controls[i];
                citem.IsSelected = false;
            }
            MenuItem item = (MenuItem)sender;
            if (item.Content != null)
            {
                item.Content.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(item.Content);
            }
            item.IsSelected = true;
        }

        private void picBoxMenuButton_MouseDown(object sender, MouseEventArgs e)
        {
            picBoxMenuButton.Image = Properties.Resources.fa_bars_64_0_bbbbbb_none;
        }

        private void picBoxMenuButton_MouseUp(object sender, MouseEventArgs e)
        {
            picBoxMenuButton.Image = Properties.Resources.fa_bars_64_0_ffffff_none;
        }

        private void picBoxMenuButton_MouseEnter(object sender, EventArgs e)
        {
            picBoxMenuButton.Image = Properties.Resources.fa_bars_64_0_dedede_none;
        }

        private void picBoxMenuButton_MouseLeave(object sender, EventArgs e)
        {
            picBoxMenuButton.Image = Properties.Resources.fa_bars_64_0_ffffff_none;
        }
    }
}
