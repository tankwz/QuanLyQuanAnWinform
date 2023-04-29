using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyQuanAn
{
    public partial class QuanLy : Form
    {

        int[] nuockt = new int[12];
        int[] tt = new int[17];
        public QuanLy()
        {
            InitializeComponent();
            ketnoid();
            xem();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string ketnoistr = @"Data Source: DESKTOP-FODM6T1\SQLEXPRESS;Initial Catalog=WINFORMQLDH;User ID=sa;pwd=sa2012";
        SqlConnection con;
        public void ketnoid()
        {
            con = new SqlConnection(ketnoistr);
            MessageBox.Show("Đã Kết nối thành công!");
        }
        SqlCommand cmd;
        SqlDataAdapter dta;
        DataTable dt;
        public void xem()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                dta = new SqlDataAdapter("select don_hang.ma_dh, chi_tiet_don_hang.ma_sp, ten_sp, so_luong, giatien, " +
                    "tong_tien, trang_thai, ngay_gio  from don_hang, chi_tiet_don_hang, " +
                    "san_pham where don_hang.ma_dh = chi_tiet_don_hang.ma_dh and " +
                    "chi_tiet_don_hang.ma_sp = san_pham.ma_sp " +
                    "order by ngay_gio desc ", con);

                dta.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}