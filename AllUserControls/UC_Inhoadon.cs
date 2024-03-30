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
    public partial class UC_Inhoadon : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_Inhoadon()
        {
            InitializeComponent();
            LoadTotalData();
        }

        private void btnThemHoadon_Click(object sender, EventArgs e)
        {
            try
            {
                string tenKhachHang = guna2TextBox1.Text.Trim();
                query = "SELECT TENKH, TENNUOC, SOLUONG, DONGIA FROM HOADONGIA WHERE TENKH LIKE '%" + tenKhachHang + "%'";
                DataSet ds = fn.getData(query);

                // Tính toán THANHTIEN
                DataColumn thanhTienColumn = new DataColumn("THANHTIEN", typeof(int));
                ds.Tables[0].Columns.Add(thanhTienColumn);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int soLuong = Convert.ToInt32(row["SOLUONG"]);
                    int donGia = Convert.ToInt32(row["DONGIA"]);
                    int thanhTien = soLuong * donGia;
                    row["THANHTIEN"] = thanhTien;
                }

                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTotalData()
        {
            string query = "SELECT TENKH, TENNUOC, SOLUONG, DONGIA FROM HOADONGIA";
            DataSet ds = fn.getTotalData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            DataColumn thanhTienColumn = new DataColumn("THANHTIEN", typeof(int));
            ds.Tables[0].Columns.Add(thanhTienColumn);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int soLuong = Convert.ToInt32(row["SOLUONG"]);
                int donGia = Convert.ToInt32(row["DONGIA"]);
                int thanhTien = soLuong * donGia;
                row["THANHTIEN"] = thanhTien;
            }

            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
