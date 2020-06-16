using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramConceito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MoveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            ImgSlide.Location = new Point(b.Location.X + 111, b.Location.Y - 72);
            ImgSlide.SendToBack();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            MoveImageBox(sender);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
