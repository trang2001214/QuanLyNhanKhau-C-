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
    public partial class ToDanPho : Form
    {
        public ToDanPho()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ToDanPho_Load(object sender, EventArgs e)
        {
            hienTDP();
        }

        private void quậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quan q = new Quan();
            this.Hide();
            q.ShowDialog();
        }

        private void phườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phuong p = new Phuong();
            this.Hide();
            p.ShowDialog();
        }
        private void hienTDP()
        {
            using (DataTable tblToDanPho = getTDP())
            {
                DataView dvToDanPho = new DataView(tblToDanPho);
                dgrTDP.AutoGenerateColumns = false;
                dgrTDP.ReadOnly = true;
                dgrTDP.DataSource = dvToDanPho;

            }
        }
        string ConnectionString = @"Data Source=DESKTOP-8B7E67O\SQLEXPRESS;Initial Catalog=SqlQuanLyNhanKhau;Integrated Security=True;";
        private DataTable getTDP()
        {
            using (SqlConnection Cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("spTDP_Get", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                    {
                        DataTable t = new DataTable("tblToDanPho");
                        Da.Fill(t);
                        return t;

                    }//da
                }//cmd

            }// cnn
        }
        private void dgrTDP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaTDP.ReadOnly = true;// Không thể xóa hay sửa cái thông tin Mã  hàng này
            int i;
            i = dgrTDP.CurrentRow.Index;
            tbMaTDP.Text = dgrTDP.Rows[i].Cells[0].Value.ToString();
            tbMaP.Text = dgrTDP.Rows[i].Cells[1].Value.ToString();
            tbMaTK.Text = dgrTDP.Rows[i].Cells[2].Value.ToString();
            tbTenTDP.Text = dgrTDP.Rows[i].Cells[3].Value.ToString();
            tbCSKV.Text = dgrTDP.Rows[i].Cells[4].Value.ToString();
            tbToTruong.Text = dgrTDP.Rows[i].Cells[5].Value.ToString();
            tbSdtTDP.Text = dgrTDP.Rows[i].Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            string SqlInsert = "INSERT INTO tblToDanPho VALUES(@smatdp,@smap,@imatk,@stentdp,@scskv,@stotruong,@isdttdp)";
            SqlCommand cmd = new SqlCommand(SqlInsert, cnn);
            cmd.Parameters.AddWithValue("sMaTDP", tbMaTDP.Text);
            cmd.Parameters.AddWithValue("sMaP", tbMaP.Text);
            cmd.Parameters.AddWithValue("iMaTK", tbMaTK.Text);
            cmd.Parameters.AddWithValue("sTenTDP", tbTenTDP.Text);
            cmd.Parameters.AddWithValue("sCSKV", tbCSKV.Text);
            cmd.Parameters.AddWithValue("sToTruong", tbToTruong.Text);
            cmd.Parameters.AddWithValue("iSdtTDP", tbSdtTDP.Text);
            cmd.ExecuteNonQuery();
            hienTDP();
            Reset();
            cnn.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            string SqlSua = " UPDATE tblToDanPho SET sMaP='" + tbMaP.Text + "', iMaTK='" + tbMaTK.Text + "', sTenTDP='" + tbTenTDP.Text + "', sCSKV='" + tbCSKV.Text + "', sToTruong='" + tbToTruong.Text + "', iSdtTDP='" + tbSdtTDP.Text + "'  Where sMaTDP='" + tbMaTDP.Text + "'";
            SqlCommand cmd = new SqlCommand(SqlSua, cnn);
            cmd.ExecuteNonQuery();
            hienTDP();
            Reset();
            cnn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            string SqlDelete = "delete tblToDanPho WHERE sMaTDP='" + tbMaTDP.Text + "'";
            SqlCommand cmd = new SqlCommand(SqlDelete, cnn);
            cmd.ExecuteNonQuery();
            hienTDP();
            Reset();
            cnn.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            string SqlTimkiem = "Select*From tblToDanPho Where sMaTDP= '" + tbMaTDP.Text + "'"; 
            SqlCommand cmd = new SqlCommand(SqlTimkiem, cnn);
            cmd.Parameters.AddWithValue("sMaTDP", btnTimKiem.Text);
            cmd.Parameters.AddWithValue("sMaP", tbMaP.Text);
            cmd.Parameters.AddWithValue("iMaTK", tbMaTK.Text);
            cmd.Parameters.AddWithValue("sTenTDP", tbTenTDP.Text);
            cmd.Parameters.AddWithValue("sCSKV", tbCSKV.Text);
            cmd.Parameters.AddWithValue("sToTruong", tbToTruong.Text);
            cmd.Parameters.AddWithValue("iSdtTDP", tbSdtTDP.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            dgrTDP.DataSource = tb;
            Reset();
            cnn.Close();
        } 
        public void Reset()
        {
            tbMaTDP.Text = "";
            tbMaP.Text = "";
            tbMaTK.Text = "";
            tbTenTDP.Text = "";
            tbCSKV.Text = "";
            tbToTruong.Text = "";
            tbSdtTDP.Text = "";
        }
    }
}



