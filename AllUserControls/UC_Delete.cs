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
    public partial class UC_Delete : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_Delete()
        {
            InitializeComponent();
        }
        public enum DataType
        {
            Drinks,
            Customers
        }
        private DataType currentDataType = DataType.Drinks;

        private void UC_Delete_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            if (currentDataType == DataType.Drinks)
            {
                query = "select * from NUOC";
                DataSet ds = fn.getData(query);
                delGridview.DataSource = ds.Tables[0];
            }
            else if (currentDataType == DataType.Customers)
            {
                query = "select * from KHACHHANG";
                DataSet ds = fn.getCustomerData(query);
                delGridview.DataSource = ds.Tables[0];
            }

        }
        /*       private void label1_Click(object sender, EventArgs e)
               {

               }*/

        private void txtdrinkSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from NUOC where MANUOC like '" + txtdrinkSearch.Text + "%'";
            DataSet ds = fn.getCustomerData(query);
            delGridview.DataSource = ds.Tables[0];

        }

        private void delGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentDataType == DataType.Drinks)
            {
                // Xóa đồ uống
                if (MessageBox.Show("Ban co muon xoa do uong?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int id = int.Parse(delGridview.Rows[e.RowIndex].Cells[0].Value.ToString());
                    query = "delete from NUOC where MANUOC = " + id + "";
                    fn.setData(query);
                    loadData();
                }
            }
            else if (currentDataType == DataType.Customers)
            {
                // Xóa khách hàng
                if (MessageBox.Show("Ban co muon xoa khach hang?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int id = int.Parse(delGridview.Rows[e.RowIndex].Cells[0].Value.ToString());
                    query = "delete from KHACHHANG where MAKH = " + id + "";
                    fn.setData(query);
                    loadData();
                }
            }
        }

        private void txtcustomerSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from KHACHHANG where MAKH like '" + txtcustomerSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            delGridview.DataSource = ds.Tables[0];
        }

        private void btnDrinkinfo_Click(object sender, EventArgs e)
        {
            currentDataType = DataType.Drinks;
            loadData();
        }

        private void btnCustomerinfo_Click(object sender, EventArgs e)
        {
            currentDataType = DataType.Customers;
            loadData();
        }

        private void UC_Delete_Enter(object sender, EventArgs e)
        {
            loadData();
        }

    }
}
