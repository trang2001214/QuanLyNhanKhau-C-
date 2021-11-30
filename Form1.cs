using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanKhau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void quậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quan q = new Quan();
            q.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void phườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phuong p = new Phuong();
            p.ShowDialog();
        }

        private void tổDânPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDanPho tdp = new ToDanPho();
            tdp.ShowDialog();
        }
    }
}
