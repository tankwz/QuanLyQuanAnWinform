using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyQuanAn
{
    public partial class QuanLy : Form
    {
        Form DatHang;
        public QuanLy(Form DatHang)
        {
            InitializeComponent();
            ketnoid();
            xem();
            this.DatHang = DatHang;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string ketnoistr = @"Data Source=DESKTOP-FODM6T1\SQLEXPRESS;Initial Catalog=QLDH;User ID=sa;pwd=sa2012";
        SqlConnection con;
        public void ketnoid()
        {
            con = new SqlConnection(ketnoistr);
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
                dta = new SqlDataAdapter("select don_hang.ma_dh,chi_tiet_don_hang.ma_sp,ten_sp,so_luong,giatien,tong_tien " +
                    ",ngay_gio from don_hang,chi_tiet_don_hang,san_pham where don_hang.ma_dh = chi_tiet_don_hang.ma_dh " +
                    "and chi_tiet_don_hang.ma_sp = san_pham.ma_sp " +
                    "order by ngay_gio desc", con);


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
            this.Close();
            DatHang.Show();
        }
        DataTable da;
        SqlDataAdapter sda;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new DataTable();
                sda = new SqlDataAdapter("select * from (select don_hang.ma_dh,chi_tiet_don_hang.ma_sp,ten_sp,so_luong,giatien,tong_tien " +
                    ",ngay_gio from don_hang,chi_tiet_don_hang,san_pham where don_hang.ma_dh = chi_tiet_don_hang.ma_dh " +
                    "and chi_tiet_don_hang.ma_sp = san_pham.ma_sp " +
                    ") a where ma_dh like '" + textBox1.Text + "%' order by ngay_gio desc ", con);
                sda.Fill(da);
                dataGridView1.DataSource = da;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }
    }
}