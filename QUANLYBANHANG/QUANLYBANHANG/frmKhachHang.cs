using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYBANHANG
{
    public partial class frmKhachHang : Form
    {
        string strConnectionString = "Data Source=LAPTOP-AB1V2ERG;Initial Catalog=qlbanhang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;
        SqlDataAdapter daThanhPho = null;
        DataTable dtThanhPho = null;
        bool them;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {

        }

        void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                daThanhPho = new SqlDataAdapter("Select * Form thanhpho", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);
                
                daKhachHang = new SqlDataAdapter("Select * Form khachhang", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);
                dgvKHACHKHANG.DataSource = dtKhachHang;

                this.txtMaKH.ResetText();
                this.txtTenCTy.ResetText();
                this.txtDiachi.ResetText();
                this.txtDienThoai.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.panel1.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
            }catch(Exception)
            {
                MessageBox.Show("Không lấy được nội dung trong table KhachHang.Lỗi rồi!!!");

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = dgvKHACHKHANG.CurrentCell.ColumnIndex;
                string strMAKH   = dgvKHACHKHANG.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Delete From khachhang Where MaKH='" + strMAKH + "'");
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được,Lỗi rồi!");

            }
            conn.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            this.cbThanhPho.DataSource = dtThanhPho;
            this.cbThanhPho.DisplayMember = "TenThanhPho";
            this.cbThanhPho.ValueMember = "ThanhPho";

            this.panel1.Enabled = true;
            int r = dgvKHACHKHANG.CurrentCell.RowIndex;

            this.txtMaKH.Text = dgvKHACHKHANG.Rows[r].Cells[0].Value.ToString();
            this.txtTenCTy.Text = dgvKHACHKHANG.Rows[r].Cells[1].Value.ToString();
            this.txtDiachi.Text = dgvKHACHKHANG.Rows[r].Cells[2].Value.ToString();
            this.cbThanhPho.Text = dgvKHACHKHANG.Rows[r].Cells[3].Value.ToString();
            this.txtDienThoai.Text = dgvKHACHKHANG.Rows[r].Cells[4].Value.ToString();

            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtMaKH.Focus();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            this.txtMaKH.ResetText();
            this.txtTenCTy.ResetText();
            this.txtDiachi.ResetText();
            this.txtDienThoai.ResetText();
          
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;


            this.cbThanhPho.DataSource = dtThanhPho;
            this.cbThanhPho.DisplayMember = "TenThanhPho";
            this.cbThanhPho.ValueMember = "ThanhPho";
            this.txtMaKH.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("Insert into ThanhPho Values(" + "'" + this.txtMaKH.Text.ToString()
                                                                                         + "','" + this.txtTenCTy.Text.ToString()
                                                                                         + "','" + this.txtDiachi.Text.ToString()
                                                                                         + "','" + this.cbThanhPho.SelectedValue.ToString()
                                                                                         + "','" + this.txtDienThoai.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;

                    cmd.ExecuteNonQuery();
                    LoadData();
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
                int r = dgvKHACHKHANG.CurrentCell.ColumnIndex;
                string strMAKH   = dgvKHACHKHANG.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Update ThanhPho Set TenCty='" + this.txtTenCTy.Text.ToString()
                                                                          + "',  Diachi = '" + this.txtDiachi.Text.ToString()
                                                                            + "',ThanhPho = '" + this.cbThanhPho.SelectedValue.ToString()
                                                                            + "',DienThoai  = '" + this.txtDienThoai.Text.ToString()
                                                                            + "'Where MaKH='" + strMAKH + "'");

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
            conn.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.txtMaKH.ResetText();
            this.txtTenCTy.ResetText();
            this.txtDiachi.ResetText();
            this.txtDienThoai.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel1.Enabled = false;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
