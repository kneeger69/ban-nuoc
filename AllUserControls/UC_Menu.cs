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
    public partial class UC_Menu : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_Menu()
        {
            InitializeComponent();
        }

        private void UC_Menu_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }
        private void LoadMenu()
        {
            try
            {
                // Thực hiện truy vấn SQL để lấy thông tin từ bảng NUOC
                query = "SELECT * FROM NUOC";
                DataSet ds = fn.getData(query);
                MenuGridview.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MenuGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = MenuGridview.Rows[e.RowIndex];
                txtDrinkname.Text = row.Cells["TENNUOC"].Value.ToString();
                txtPrice.Text = row.Cells["DONGIA"].Value.ToString();
            }
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các trường nhập liệu
                string tenKhachHang = txtCustomername.Text;
                string tenNuoc = txtDrinkname.Text;
                int soLuong = (int)txtQuantity.Value;
                int donGia = int.Parse(txtPrice.Text); // Chuyển đổi từ string sang int

                // Tạo câu lệnh SQL để chèn dữ liệu vào bảng HOADONGIA
                string query = string.Format("INSERT INTO HOADONGIA (TENKH, TENNUOC, SOLUONG, DONGIA) VALUES ('{0}', '{1}', {2}, {3})", tenKhachHang, tenNuoc, soLuong, donGia);

                // Thực thi câu lệnh SQL
                fn.setData(query);

                // Hiển thị thông báo thành công
                MessageBox.Show("Thêm hóa đơn thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
