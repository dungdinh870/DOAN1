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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
          
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if((this.txtUser.Text=="dung") && (this.txtPass.Text=="123"))
            {
                MessageBox.Show("Bạn đã đăng nhập thành công","Thông báo");
                this.Close();
            }    
            else
            {
                MessageBox.Show("Không đúng tên người dùng/mật khẩu??", "Thông báo");
                this.txtUser.Focus();
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("chắc không?", "traloi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();

        }
    }
}
