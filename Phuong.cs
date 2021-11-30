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
    public partial class Phuong : Form
    {
        public Phuong()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phuong_Load(object sender, EventArgs e)
        {
            hienPhuong();
        }

        private void quậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quan q = new Quan();
            this.Hide();
            q.ShowDialog();
        }

        private void tổDânPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDanPho tdp = new ToDanPho();
            this.Hide();
            tdp.ShowDialog();
        }
        private void hienPhuong()
        {
            using (DataTable tblPhuong = getPhuong())
            {
                DataView dvPhuong = new DataView(tblPhuong);
                dgrPhuong.AutoGenerateColumns = false;
                dgrPhuong.ReadOnly = true;
                dgrPhuong.DataSource = dvPhuong;

            }
        }
        string ConnectionString = @"Data Source=DESKTOP-8B7E67O\SQLEXPRESS;Initial Catalog=SqlQuanLyNhanKhau;Integrated Security=True;";
        private DataTable getPhuong()
        {
            using (SqlConnection Cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("spPhuong_Get", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                    {
                        DataTable t = new DataTable("tblPhuong");
                        Da.Fill(t);
                        return t;

                    }//da
                }//cmd

            }// cnn
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            string SqlSua = " UPDATE tblPhuong SET sMaQuan='" + tbMaQuan.Text + "', sTenP='" + tbTenP.Text + "', iSdtP='" + tbSdtP.Text + "'  Where sMaP='" + tbMaP.Text + "'";
            SqlCommand cmd = new SqlCommand(SqlSua, cnn);
            cmd.ExecuteNonQuery();
            hienPhuong();
            Reset();
            cnn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            string SqlInsert = "INSERT INTO tblPhuong VALUES(@smap,@smaquan,@stenp,@isdtp)";
            SqlCommand cmd = new SqlCommand(SqlInsert, cnn);
            cmd.Parameters.AddWithValue("sMaP", tbMaP.Text);
            cmd.Parameters.AddWithValue("sMaQuan", tbMaQuan.Text);
            cmd.Parameters.AddWithValue("sTenP", tbTenP.Text);
            cmd.Parameters.AddWithValue("iSdtP", tbSdtP.Text);
            cmd.ExecuteNonQuery();
            hienPhuong();
            Reset();
            cnn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            string SqlDelete = "delete tblPhuong WHERE sMaP='" + tbMaP.Text + "'";
            SqlCommand cmd = new SqlCommand(SqlDelete, cnn);
            cmd.ExecuteNonQuery();
            hienPhuong();
            Reset();
            cnn.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            string SqlTimkiem = "Select*From tblPhuong Where sMaP= '" + tbMaP.Text + "'"; // tìm theo mã quận
            SqlCommand cmd = new SqlCommand(SqlTimkiem, cnn);
            cmd.Parameters.AddWithValue("sMaP", btnTimKiem.Text);//Mã quận cần tìm chính là cái mình vừa nhập tìm kiếm
            cmd.Parameters.AddWithValue("sMaQuan", tbMaQuan.Text);
            cmd.Parameters.AddWithValue("sTenP", tbTenP.Text);
            cmd.Parameters.AddWithValue("iSdtP", tbSdtP.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            dgrPhuong.DataSource = tb;
            Reset();
            cnn.Close();
        }

        private void dgrPhuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaP.ReadOnly = true;// Không thể xóa hay sửa cái thông tin Mã  hàng này
            int i;
            i = dgrPhuong.CurrentRow.Index;
            tbMaP.Text = dgrPhuong.Rows[i].Cells[0].Value.ToString();
            tbMaQuan.Text = dgrPhuong.Rows[i].Cells[1].Value.ToString();
            tbTenP.Text = dgrPhuong.Rows[i].Cells[2].Value.ToString();
            tbSdtP.Text = dgrPhuong.Rows[i].Cells[3].Value.ToString();
        }
        public void Reset()
        {
            tbMaP.Text = "";
            tbMaQuan.Text = "";
            tbTenP.Text = "";
            tbSdtP.Text = "";
        }
    }
}



