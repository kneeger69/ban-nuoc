using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanNuoc.AllUserControls
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                lblBanner.Location = new Point(38, 427);
                lblBanner.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 1)
            {
                lblBanner.Location = new Point(58, 427);
                lblBanner.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                lblBanner.Location = new Point(78, 427);
                lblBanner.ForeColor = Color.IndianRed;
                num++;
            }
            else if (num == 3)
            {
                lblBanner.Location = new Point(98, 427);
                lblBanner.ForeColor = Color.DarkCyan;
                num++;
            }
            else if (num == 4)
            {
                lblBanner.Location = new Point(118, 427);
                lblBanner.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 5)
            {
                lblBanner.Location = new Point(138, 427);
                lblBanner.ForeColor = Color.Green;
                num++;
            }
            else if (num == 6)
            {
                lblBanner.Location = new Point(158, 427);
                lblBanner.ForeColor = Color.IndianRed;
                num++;
            }
            else if (num == 7)
            {
                lblBanner.Location = new Point(178, 427);
                lblBanner.ForeColor = Color.DarkCyan;
                num++;
            }
            else if (num == 8)
            {
                lblBanner.Location = new Point(198, 427);
                lblBanner.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 9)
            {
                lblBanner.Location = new Point(218, 427);
                lblBanner.ForeColor = Color.Green;
                num++;
            }
            else if (num == 10)
            {
                lblBanner.Location = new Point(238, 427);
                lblBanner.ForeColor = Color.IndianRed;
                num++;
            }
            else if (num == 11)
            {
                lblBanner.Location = new Point(258, 427);
                lblBanner.ForeColor = Color.DarkCyan;
                num++;
            }
            else if (num == 12)
            {
                lblBanner.Location = new Point(278, 427);
                lblBanner.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 13)
            {
                lblBanner.Location = new Point(298, 427);
                lblBanner.ForeColor = Color.Green;
                num++;
            }
            else if (num == 14)
            {
                lblBanner.Location = new Point(318, 427);
                lblBanner.ForeColor = Color.IndianRed;
                num = 0;
            }
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
