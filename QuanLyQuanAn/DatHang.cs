using System;
using System.Data.SqlClient;

namespace QuanLyQuanAn
{
    public partial class DatHang : Form
    {

        int[] nuockt = new int[12];
        int[] tt = new int[17];
        public DatHang()
        {
            InitializeComponent();
            ketnoi();
            sl0.Enabled = false;
            sl1.Enabled = false;
            sl2.Enabled = false;
            sl3.Enabled = false;
            sl4.Enabled = false;
            sl5.Enabled = false;
            sl6.Enabled = false;
            sl7.Enabled = false;
            sl8.Enabled = false;
            sl9.Enabled = false;
            sl10.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void tinhtong()
        {
            int i;
            tt[10] = 0;
            tt[11] = 0;
            for (i = 0; i < 10; i++)
            {
                tt[10] = tt[10] + tt[i];
            }

            gia10.Text = tt[10].ToString()   ;
            if (tt[10] == 0)
            {
                tt[11] = 0;
            }
            else
            {
                tt[11] = 2000;
            }
            gia11.Text =tt[11].ToString();


            tt[12] = ((tt[10] + tt[11]) * 10 / 100) + ((tt[10] + tt[11]) % 10 / 100);
            gia12.Text= tt[12].ToString();
            tt[13] = tt[10] + tt[11] + tt[12];
            gia13.Text=tt[13].ToString();
            if( checkBox10.Checked)
            {
                nuockt[10] = (int)sl10.Value;
            }
            else
            {
                nuockt[10] = 0;
            }
            tt[15] = nuockt[10] * 1000; 
            tt[16] = tt[15]/*khau trang*/ + tt[10]/*tong nuoc*/ + tt[11] + tt[12];
            gia14.Text= tt[16].ToString();

        }

        public void change_checkbox(CheckBox checkbox_x, NumericUpDown sl_x, Label gia_x, int x, int gia)
        {
            if (checkbox_x.Checked)
            {
                sl_x.Enabled = true;
                tt[x] = (int)(sl_x.Value * gia);
                gia_x.Text = tt[x].ToString();
            }
            if (!checkbox_x.Checked)
            {
                sl_x.Enabled = false;
                sl_x.Value = 1;
                gia_x.Text = "0";
                tt[x] = 0;
            }
        }

        public void change_sl(NumericUpDown sl_x, Label gia_x, int x, int gia)
        {
            tt[x] = (int)sl_x.Value * gia;
            gia_x.Text = tt[x].ToString();
        }

        private void checkBox0_CheckedChanged(object sender, EventArgs e)
        {
            change_checkbox(checkBox0, sl0, gia0, 0, 12000);
        }

        private void sl0_ValueChanged(object sender, EventArgs e)
        {
            change_sl(sl0, gia0, 0, 12000);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            change_checkbox(checkBox1, sl1, gia1, 1, 14000);

        }

        private void sl1_ValueChanged(object sender, EventArgs e)
        {
            change_sl(sl1, gia1, 1, 14000);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            change_checkbox(checkBox2, sl2, gia2, 2, 16000);
        }

        private void sl2_ValueChanged(object sender, EventArgs e)
        {
            change_sl(sl2, gia2, 2, 16000);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            change_checkbox(checkBox3, sl3, gia3, 3, 18000);

        }

        private void sl3_ValueChanged(object sender, EventArgs e)
        {
            change_sl(sl3, gia3, 3, 18000);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            change_checkbox(checkBox4, sl4, gia4, 4, 20000);

        }

        private void sl4_ValueChanged(object sender, EventArgs e)
        {
            change_sl(sl4, gia4, 4, 20000);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            change_checkbox(checkBox5, sl5, gia5, 5, 15000);

        }

        private void sl5_ValueChanged(object sender, EventArgs e)
        {
            change_sl(sl5, gia5, 5, 15000);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            change_checkbox(checkBox6, sl6, gia6, 6, 18000);

        }

        private void sl6_ValueChanged(object sender, EventArgs e)
        {
            change_sl(sl6, gia6, 6, 18000);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            change_checkbox(checkBox7, sl7, gia7, 7, 16000);

        }

        private void sl7_ValueChanged(object sender, EventArgs e)
        {
            change_sl(sl7, gia7, 7, 16000);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            change_checkbox(checkBox8, sl8, gia8, 8, 14000);

        }

        private void sl8_ValueChanged(object sender, EventArgs e)
        {
            change_sl(sl8, gia8, 8, 14000);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            change_checkbox(checkBox9, sl9, gia9, 9, 10000);

        }

        private void sl9_ValueChanged(object sender, EventArgs e)
        {
            change_sl(sl9, gia9, 9, 10000);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                sl10.Enabled = true;
                sl10.Value = 1;
            }
            if (!checkBox10.Checked)
            {
                sl10.Enabled = false;
                sl10.Value = 1;
            }
        }

        private void tong_Click(object sender, EventArgs e)
        {
            tinhtong();
        }

        string ddketnoi = @"Data Source =DESKTOP-FODM6T1\SQLEXPRESS;Initial Catalog=QLDH;User Id=sa;pwd=sa2012;";
        SqlConnection con;
        SqlCommand cmd;
        public void ketnoi()
        {
             con = new SqlConnection(ddketnoi);
            MessageBox.Show("Đã Kết nối thành công!");
        }

        public void capnhatcsdl()
        {
            try
            {

                con.Open();
               
                cmd = new SqlCommand("INSERT INTO don_hang(tong_tien, ngay_gio) values ('" + tt[16] + "', GETDATE() )",con); 
                cmd.ExecuteNonQuery();
                if (checkBox0.Checked)
                {
                    cmd = new SqlCommand ("INSERT INTO chi_tiet_don_hang(ma_dh, ma_sp, so_luong, giatien) VALUES( IDENT_CURRENT('don_hang'),1,'"+ nuockt[0] + "','"+ tt[0] + "')",con);
                    cmd.ExecuteNonQuery ();
                }
                if (checkBox1.Checked)
                {
                    cmd = new SqlCommand("INSERT INTO chi_tiet_don_hang(ma_dh, ma_sp, so_luong, giatien) VALUES( IDENT_CURRENT('don_hang'),2,'" + nuockt[1] + "','" + tt[1] + "')", con);
                    cmd.ExecuteNonQuery();
                }
                if (checkBox2.Checked)
                {
                    cmd = new SqlCommand("INSERT INTO chi_tiet_don_hang(ma_dh, ma_sp, so_luong, giatien) VALUES( IDENT_CURRENT('don_hang'),3,'" + nuockt[2] + "','" + tt[2] + "')", con);
                    cmd.ExecuteNonQuery();
                }
                if (checkBox3.Checked)
                {
                    cmd = new SqlCommand("INSERT INTO chi_tiet_don_hang(ma_dh, ma_sp, so_luong, giatien) VALUES( IDENT_CURRENT('don_hang'),4,'" + nuockt[3] + "','" + tt[3] + "')", con);
                    cmd.ExecuteNonQuery();
                }
                if (checkBox4.Checked)
                {
                    cmd = new SqlCommand("INSERT INTO chi_tiet_don_hang(ma_dh, ma_sp, so_luong, giatien) VALUES( IDENT_CURRENT('don_hang'),5,'" + nuockt[4] + "','" + tt[4] + "')", con);
                    cmd.ExecuteNonQuery();
                }
                if (checkBox5.Checked)
                {
                    cmd = new SqlCommand("INSERT INTO chi_tiet_don_hang(ma_dh, ma_sp, so_luong, giatien) VALUES( IDENT_CURRENT('don_hang'),6,'" + nuockt[5] + "','" + tt[5] + "')", con);
                    cmd.ExecuteNonQuery();
                }
                if (checkBox6.Checked)
                {
                    cmd = new SqlCommand("INSERT INTO chi_tiet_don_hang(ma_dh, ma_sp, so_luong, giatien) VALUES( IDENT_CURRENT('don_hang'),7,'" + nuockt[6] + "','" + tt[6] + "')", con);
                    cmd.ExecuteNonQuery();
                }
                if (checkBox7.Checked)
                {
                    cmd = new SqlCommand("INSERT INTO chi_tiet_don_hang(ma_dh, ma_sp, so_luong, giatien) VALUES( IDENT_CURRENT('don_hang'),8,'" + nuockt[7] + "','" + tt[7] + "')", con);
                    cmd.ExecuteNonQuery();
                }
                if (checkBox8.Checked)
                {
                    cmd = new SqlCommand("INSERT INTO chi_tiet_don_hang(ma_dh, ma_sp, so_luong, giatien) VALUES( IDENT_CURRENT('don_hang'),9,'" + nuockt[8] + "','" + tt[8] + "')", con);
                    cmd.ExecuteNonQuery();
                }
                if (checkBox9.Checked)
                {
                    cmd = new SqlCommand(" INSERT INTO chi_tiet_don_hang(ma_dh, ma_sp, so_luong, giatien) VALUES( IDENT_CURRENT('don_hang'),10,'" + nuockt[9] + "','" + tt[9] + "')", con);
                    cmd.ExecuteNonQuery();
                }
                if (checkBox10.Checked)
                {
                    cmd = new SqlCommand("INSERT INTO chi_tiet_don_hang(ma_dh, ma_sp, so_luong, giatien) VALUES( IDENT_CURRENT('don_hang'),11,'" + nuockt[10] + "','" + tt[15] + "')", con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();


                MessageBox.Show("Đã Lưu Vào Cơ Sở Dữ Liệu");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void xacnhan_Click(object sender, EventArgs e)
        {
            tinhtong();

            if (tt[16] != 0)
            {  
                hoadon.Text="";

                nuockt[0] = (int)sl0.Value;
                nuockt[1] = (int)sl1.Value;
                nuockt[2] = (int)sl2.Value;
                nuockt[3] = (int)sl3.Value;
                nuockt[4] = (int)sl4.Value;
                nuockt[5] = (int)sl5.Value;
                nuockt[6] = (int)sl6.Value;
                nuockt[7] = (int)sl7.Value;
                nuockt[8] = (int)sl8.Value;
                nuockt[9] = (int)sl9.Value;
                nuockt[10] = (int)sl10.Value;

                /*    Calendar time = Calendar.getInstance();
                    time.getTime();
                    SimpleDateFormat time1 = new SimpleDateFormat("HH:mm:ss");
                    time1.format(time.getTime());
                    SimpleDateFormat date = new SimpleDateFormat("dd-MM-yyyy");
                    date.format(time.getTime());*/
                DateTime day = DateTime.Today;

                hoadon.AppendText("\t        ĐƠN HÀNG\n=============================\n");

                if (checkBox0.Checked)
                {
                    hoadon.AppendText(
                            "Cà Phê đen đá(" + nuockt[0] + ").............\n" + tt[0] + "\n"
                    );
                }
                if (checkBox1.Checked)
                {
                    hoadon.AppendText(
                            "Cà Phê sữa đặc(" + nuockt[1] + ")............\n" + tt[1] + "\n"
                    );
                }
                if (checkBox2.Checked)
                {
                    hoadon.AppendText(
                            "Cà Phê Cappuccino(" + nuockt[2] + ").........\n" + tt[2] + "\n"
                    );
                }
                if (checkBox3.Checked)
                {
                    hoadon.AppendText(
                            "Cà Phê Mocha(" + nuockt[3] + ")..............\n" + tt[3] + "\n"
                    );
                }
                if (checkBox4.Checked)
                {
                    hoadon.AppendText(
                            "Bánh Flan(" + nuockt[4] + ").................\n" + tt[4] + "\n"
                    );
                }
                if (checkBox5.Checked)
                {
                    hoadon.AppendText(
                            "Mỳ Bò(" + nuockt[5] + ").....................\n" + tt[5] + "\n"
                    );
                }
                if (checkBox6.Checked)
                {
                    hoadon.AppendText(
                            "Bún Thịt Nướng(" + nuockt[6] + ")............\n" + tt[6] + "\n"
                    );
                }
                if (checkBox7.Checked)
                {
                    hoadon.AppendText(
                            "Cơm Sườn(" + nuockt[7] + ")..................\n" + tt[7] + "\n"
                    );
                }
                if (checkBox8.Checked)
                {
                    hoadon.AppendText(
                            "Hủ Tiếu(" + nuockt[8] + ")...................\n" + tt[8] + "\n"
                    );
                }
                if (checkBox9.Checked)
                {
                    hoadon.AppendText(
                            "Sting Dâu(" + nuockt[9] + ").................\n" + tt[9] + "\n"
                    );
                }
                if (checkBox10.Checked)
                {
                    hoadon.AppendText(
                            "Khẩu Trang(" + nuockt[10] + ")................\n" + tt[15] + "\n"
                    );
                }
                hoadon.AppendText("=============================\nTổng tiền là: " + tt[16]);
                hoadon.AppendText("\n=============================\nNgày:" + DateTime.Now.ToString("dd/MM/yyyy") + "\nGiờ:"+ DateTime.Now.ToString("HH:mm:ss") + "\n=============================\n\t   THANKS YOU\n");
            }
            capnhatcsdl();

            xoadl();
        }
        public void xoadl()
        {
            // TODO add your handling code here:

            checkBox0.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;

            sl0.Value = 1;
            sl1.Value = 1;
            sl2.Value = 1;
            sl3.Value = 1;
            sl4.Value = 1;
            sl5.Value = 1;
            sl6.Value = 1;
            sl7.Value = 1;
            sl8.Value = 1;
            sl9.Value = 1;
            sl10.Value = 1;

            gia0.Text = "0";
            gia1.Text = "0";
            gia2.Text = "0";
            gia3.Text = "0";
            gia4.Text = "0";
            gia5.Text = "0";
            gia6.Text = "0";
            gia7.Text = "0";
            gia8.Text = "0";
            gia9.Text = "0";
            gia10.Text = "0";
            gia11.Text = "0";
            gia12.Text = "0";
            gia13.Text = "0";
            gia14.Text = "0";

            sl0.Enabled = false;
            sl1.Enabled = false;
            sl2.Enabled = false;
            sl3.Enabled = false;
            sl4.Enabled = false;
            sl5.Enabled = false;
            sl6.Enabled = false;
            sl7.Enabled = false;
            sl8.Enabled = false;
            sl9.Enabled = false;
            sl10.Enabled = false;

            int i;
            for (i = 0; i < 10; i++)
            {
                tt[i] = 0;
            }
        }
        

        private void xoa_Click(object sender, EventArgs e)
        {
            xoadl();
            hoadon.Text = "";

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnxemhd_Click(object sender, EventArgs e)
        {
            QuanLy QL = new QuanLy(this);
            QL.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}