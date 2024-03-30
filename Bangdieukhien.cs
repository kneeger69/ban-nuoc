using BanNuoc.AllUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanNuoc
{
    public partial class Bangdieukhien : Form
    {
        public Bangdieukhien()
        {
            InitializeComponent();
        }
        public Bangdieukhien(String user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                btnPlaceorder.Hide();
                btnAdditems.Hide();
                btnDeleteitems.Hide();
                btnUpdateitems.Hide();
                btnGuestinfo.Hide();
            }
            else if (user == "Admin")
            {
                btnPlaceorder.Show();
                btnAdditems.Show();
                btnDeleteitems.Show();
                btnUpdateitems.Show();
                btnGuestinfo.Show();
            }
            else if (user == "Staff")
            {
                btnPlaceorder.Show();
                btnGuestinfo.Show();
                btnAdditems.Hide();
                btnDeleteitems.Hide();
                btnUpdateitems.Hide();
            }
        }
        private void Bangdieukhien_Load(object sender, EventArgs e)
        {

            uC_Additem1.Visible = false;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void uC_Welcome1_Load(object sender, EventArgs e)
        {

        }
        private void btnAdditems_Click(object sender, EventArgs e)
        {
            uC_Additem1.Visible = true;
            uC_Additem1.BringToFront();
        }

        private void uC_Welcome1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdditems_Click_1(object sender, EventArgs e)
        {

        }
    }
}
