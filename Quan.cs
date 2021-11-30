using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyNhanKhau
{
    public partial class Quan : Form
    {
        public Quan()
        {
            InitializeComponent();
        }

        private void phườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phuong p = new Phuong();
            this.Hide();
            p.ShowDialog();
            
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tổDânPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDanPho tdp = new ToDanPho();
            this.Hide();
            tdp.ShowDialog();
        }
        private void Quan_Load_1(object sender, EventArgs e)
        {
            hienQuan();
        }
        private void hienQuan()
        {
            using (DataTable tblQuan = getQuan())
            {
                DataView dvQuan = new DataView(tblQuan);
                dgrQuan.AutoGenerateColumns = false;
                dgrQuan.ReadOnly = true;
                dgrQuan.DataSource = dvQuan;

            }
        }
        string ConnectionString = @"Data Source=DESKTOP-8B7E67O\SQLEXPRESS;Initial Catalog=SqlQuanLyNhanKhau;Integrated Security=True;";
        private DataTable getQuan()
        {
            using (SqlConnection Cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("spQuan_Get", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                    {
                        DataTable t = new DataTable("tblQuan");
                        Da.Fill(t);
                        return t;

                    }//da
                }//cmd

            }// cnn
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            string SqlInsert = "INSERT INTO tblQuan VALUES(@smaquan,@stenq,@isdtq)";
            SqlCommand cmd = new SqlCommand(SqlInsert, cnn);
            cmd.Parameters.AddWithValue("sMaQuan", tbMaQuan.Text);
            cmd.Parameters.AddWithValue("sTenQ", tbTenQ.Text);
            cmd.Parameters.AddWithValue("iSdtQ", tbSdtQ.Text);
            cmd.ExecuteNonQuery();
            hienQuan();
            Reset();
            cnn.Close();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            string SqlDelete = "delete tblQuan WHERE sMaQuan='" + tbMaQuan.Text + "'";
            SqlCommand cmd = new SqlCommand(SqlDelete, cnn);
            cmd.ExecuteNonQuery();
            hienQuan();
            Reset();
            cnn.Close();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            string SqlSua = " UPDATE tblQuan SET sTenQ='" + tbTenQ.Text + "', iSdtQ='" + tbSdtQ.Text + "' Where sMaQuan='" + tbMaQuan.Text + "'";
            SqlCommand cmd = new SqlCommand(SqlSua, cnn);
            cmd.ExecuteNonQuery();
            hienQuan();
            Reset();
            cnn.Close();
        }

        private void dgrQuan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbMaQuan.ReadOnly = true;// Không thể xóa hay sửa cái thông tin Mã  hàng này
            int i;
            i = dgrQuan.CurrentRow.Index;
            tbMaQuan.Text = dgrQuan.Rows[i].Cells[0].Value.ToString();
            tbTenQ.Text = dgrQuan.Rows[i].Cells[1].Value.ToString();
            tbSdtQ.Text = dgrQuan.Rows[i].Cells[2].Value.ToString();

        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            string SqlTimkiem = "Select*From tblQuan Where sMaQuan= '" + tbMaQuan.Text + "'"; // tìm theo mã quận
            SqlCommand cmd = new SqlCommand(SqlTimkiem, cnn);
            cmd.Parameters.AddWithValue("sMaQuan", btnTimKiem.Text);//Mã quận cần tìm chính là cái mình vừa nhập tìm kiếm
            cmd.Parameters.AddWithValue("sTenQ", tbTenQ.Text);
            cmd.Parameters.AddWithValue("iSdtQ", tbSdtQ.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            dgrQuan.DataSource = tb;
            Reset();
            cnn.Close();
        }
        public void Reset()
        {
            tbMaQuan.Text = "";
            tbTenQ.Text = "";
            tbSdtQ.Text = "";
        }
    }
}


