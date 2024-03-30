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
    public partial class UC_Additem : UserControl

    {
        Function fn = new Function();
        string query;

        public UC_Additem()
        {
            InitializeComponent();
        }
        private void UC_Additem_Load(object sender, EventArgs e)
        {

        }

 /*       private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/

        private void btnThem_Click(object sender, EventArgs e)
        {
            query = "insert into NUOC(MANUOC, TENNUOC, LOAINUOC, DONGIA) values ('" +txtManuoc.Text+"','"+txtTenuoc.Text+"','" +txtLoainuoc.Text+"','"+txtGia.Text+"')";
            fn.setData(query);
            clearALL();
        }
        public void clearALL()
        {
            txtManuoc.Clear();
            txtLoainuoc.SelectedIndex = -1;
            txtTenuoc.Clear();
            txtGia.Clear();
        }
    }
}
