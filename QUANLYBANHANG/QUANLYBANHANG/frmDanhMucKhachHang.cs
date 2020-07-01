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
    public partial class frmDanhMucKhachHang : Form
    {
       
        
        public frmDanhMucKhachHang()
        {
            InitializeComponent();
        }

        String StrConnectionString = "Data Source=LAPTOP-AB1V2ERG;Initial Catalog=qlbanhang;Integrated Security=True";
        SqlDataAdapter daTable;
        SqlConnection conn;
        DataTable dtTable;


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            
            try
            {
                //khởi động connection
                conn = new SqlConnection(StrConnectionString);
                int intDM = Convert.ToInt32(this.Text);
                switch(intDM)
                {
                    case 1:
                        lblDanhMucKH.Text = "Danh muc thanh pho";
                        daTable = new SqlDataAdapter("SELECT ThanhPho,TenThanhPho Form thanhpho",conn);
                        break;
                    case 2:
                        lblDanhMucKH.Text = "Danh Muc Khach Hang";
                        daTable = new SqlDataAdapter("SELECT MaKH,TenCty Form khachhang", conn);
                        break;
                    case 3:
                        lblDanhMucKH.Text = "Danh Muc Nhan Vien";
                        daTable = new SqlDataAdapter("SELECT MaNV,Holot,Ten Form nhanvien", conn);
                        break;
                    case 4:
                        lblDanhMucKH.Text = "Danh Muc San Pham";
                        daTable = new SqlDataAdapter("SELECT MaSP,TenSP,Donvitinh,Dongia Form sanpham", conn);
                        break;
                    case 5:
                        lblDanhMucKH.Text = "Danh Muc Hoa Don";
                        daTable = new SqlDataAdapter("SELECT MaHD,MaKH,MaNV Form hoadon", conn);
                        break;
                    case 6:
                        lblDanhMucKH.Text = "Danh Muc Chi Tiet Hoa Don";
                        daTable = new SqlDataAdapter("SELECT Form chitiethoadon", conn);
                        break;
                    default:
                        break;
                }
                dtTable = new DataTable();
                dtTable.Clear();
                daTable.Fill(dtTable);
                dgvDanhMucKH.DataSource = dtTable;
                dgvDanhMucKH.AutoResizeColumns();
            }
            catch(SqlException)
            {
                MessageBox.Show("không lấy được nội dung trong table.lỗi rồi ????") ;
            }
        }
    }
}
