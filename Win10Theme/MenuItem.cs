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
    public partial class MenuItem : UserControl
    {
        private static Color ColorHover = Color.FromArgb(50, Color.Black);
        private static Color ColorClick = Color.FromArgb(100, Color.Black);

        private bool isSelected = false;
        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                isSelected = value;
                if (IsSelected)
                    this.BackColor = ColorHover;
                else
                    this.BackColor = Color.Transparent;
            }
        }

        public Control Content { get; set; }

        public MenuItem(Image icon, string label, Control content)
        {
            InitializeComponent();
            picBoxIcon.Image = icon;
            lblLabel.Text = label;
            Content = content;

            foreach(Control c in GetAllControls())
            {
                c.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Color_MouseDown);
                c.MouseEnter += new System.EventHandler(this.Color_MouseEnter);
                c.MouseLeave += new System.EventHandler(this.Color_MouseLeave);
                c.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Color_MouseUp);
            }

            this.BackColorChanged += MenuItem_BackColorChanged;
        }

        private void MenuItem_BackColorChanged(object sender, EventArgs e)
        {
            if (IsSelected && this.BackColor != ColorHover)
                this.BackColor = ColorHover;
        }

        private List<Control> GetAllControls()
        {
            List<Control> controlList = new List<Control>();
            controlList.Add(this);
            for (int ci = 0; ci < controlList.Count; ci++)
            {
                ControlCollection curControls = controlList[ci].Controls;
                for (int i = 0; i < curControls.Count; i++)
                {
                    Control c = curControls[i];
                    controlList.Add(c);
                }
            }
            return controlList;
        }

        private void picBoxIcon_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblLabel_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void pnlIconPlacer_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void pnlLabelPlacer_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void Color_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorHover;
        }

        private void Color_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void Color_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = ColorClick;
        }

        private void Color_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
