using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class frmThanhPho : Form
    {
        string strConnectionString = "Data Source=LAPTOP-AB1V2ERG;Initial Catalog=qlbanhang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daThanhPho = null;
        DataTable dtThanhPho = null;
        bool them;
        public frmThanhPho()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                daThanhPho = new SqlDataAdapter("Select * Form thanhpho", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);
                dgvThanhPho.DataSource = dtThanhPho;
                dgvThanhPho.AutoResizeColumns();
                this.txtThanhPho.ResetText();
                this.txtTenThanhPho.ResetText();
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.panel1.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                
            }
            catch(Exception)
            {
                MessageBox.Show("không lấy được nội dung trong table thành phố.lỗi rồi !!!");
            }
        }
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmThanhPho_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void frmThanhPho_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtThanhPho.Dispose();
            dtThanhPho = null;
            conn = null;
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            this.txtThanhPho.ResetText();
            this.txtTenThanhPho.ResetText();
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.txtThanhPho.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            this.panel1.Enabled = true;
            int r = dgvThanhPho.CurrentCell.RowIndex;
            this.txtThanhPho.Text = dgvThanhPho.Rows[r].Cells[0].Value.ToString();
            this.txtTenThanhPho.Text = dgvThanhPho.Rows[r].Cells[1].Value.ToString();
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.txtThanhPho.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = dgvThanhPho.CurrentCell.ColumnIndex;
                string strTHANHPHO = dgvThanhPho.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Delete From thanhpho Where ThanhPho='"+strTHANHPHO+"'");
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Đã xóa xong!");
            }
            catch(SqlException)
            {
                MessageBox.Show("Không xóa được,Lỗi rồi!");
               
            }
            conn.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.txtThanhPho.ResetText();
            this.txtTenThanhPho.ResetText();
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel1.Enabled =  false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (them) { 
                try
                {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = System.String.Concat("Insert into ThanhPho Values(" + "'" + this.txtThanhPho.Text.ToString()
                                                              + "','" + this.txtTenThanhPho.Text.ToString() + "')");
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                MessageBox.Show("Không thêm được,Lỗi rồi!");

                }
            }
            else 
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = dgvThanhPho.CurrentCell.ColumnIndex;
                string strTHANHPHO = dgvThanhPho.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Update ThanhPho Set TenThanhPho='" + this.txtTenThanhPho.Text.ToString()
                                                             + "' Where ThanhPho=" + strTHANHPHO + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Đã sửa xong!");
            }
            conn.Close();
        }
            
    }
}
