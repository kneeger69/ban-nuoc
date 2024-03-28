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
            if(user == "Guest")
        }
        private void Bangdieukhien_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
