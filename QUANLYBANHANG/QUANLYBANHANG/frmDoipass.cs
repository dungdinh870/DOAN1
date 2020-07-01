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
    public partial class frmDoipass : Form
    {
        public frmDoipass()
        {
            InitializeComponent();
        }

        private void frmDoipass_Load(object sender, EventArgs e)
        {
            //if (txtOldpass.Text == password)
            //{
            //    if (txtOldpass.Text == txt)

            //}
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtOldpass.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ?");
                txtOldpass.Focus();
            }    
            else if(txtNewpass.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới!");
                txtNewpass.Focus();

            }   
            else if(txtCheckpass.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ!");
                txtCheckpass.Focus();

            }
            MessageBox.Show("Đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOldpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
