using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class frmtrangchu : Form
    {
        public frmtrangchu()
        {
            InitializeComponent();
            Form frm = new frmlogin();
            frm.ShowDialog();
        }
        void XemDanhMuc(int intDanhMuc)
        {
            Form frm = new frmDanhMucKhachHang();
            frm.Text=intDanhMuc.ToString();
            frm.ShowDialog();
        }


        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void danhMucSanPhamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmSanPham();
            frm.ShowDialog();
        }
        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmlogin();
            frm.Text = "login";
            frm.ShowDialog();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDoipass();
            frm.Text = "Doi mat khau";
            frm.ShowDialog();
        }

        private void danhMucKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }

        private void danhMucThanhPhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void danhMucNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }

        private void danhMucSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void danhMucHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);
        }

        private void danhMucChiTietHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }

        private void danhMucThanhPhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmThanhPho();
            frm.ShowDialog();
        }

        private void danhMucKhachHangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void danhMucNhanVienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void danhMucHoaDonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmHoaDon();
            frm.ShowDialog();
        }

        private void danhMucChiTietHoaDonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmChiTietHoaDon();
            frm.ShowDialog();
        }
    }
}
