namespace QuanLyQuanAn
{
    partial class QuanLy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            this.panel2 = new System.Windows.Forms.Panel();
            this.thoat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_dh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_gio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.thoat);
            this.panel2.Controls.Add(this.label11);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 128);
            this.panel2.TabIndex = 1;
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thoat.Image = ((System.Drawing.Image)(resources.GetObject("thoat.Image")));
            this.thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thoat.Location = new System.Drawing.Point(860, 33);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(126, 60);
            this.thoat.TabIndex = 87;
            this.thoat.Text = "Trở Về";
            this.thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(137, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(566, 106);
            this.label11.TabIndex = 82;
            this.label11.Text = "Xem Hóa Đơn";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.label43);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(12, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1151, 577);
            this.panel6.TabIndex = 4;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(62, 16);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(249, 23);
            this.label43.TabIndex = 63;
            this.label43.Text = "Tìm kiếm theo mã đơn hàng: ";
            this.label43.Click += new System.EventHandler(this.label43_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_dh,
            this.ma_sp,
            this.ten_sp,
            this.so_luong,
            this.giatien,
            this.tong_tien,
            this.ngay_gio});
            this.dataGridView1.Location = new System.Drawing.Point(3, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1137, 511);
            this.dataGridView1.TabIndex = 0;
            // 
            // ma_dh
            // 
            this.ma_dh.DataPropertyName = "ma_dh";
            this.ma_dh.HeaderText = "Mã Đơn Hàng";
            this.ma_dh.MinimumWidth = 6;
            this.ma_dh.Name = "ma_dh";
            this.ma_dh.ReadOnly = true;
            this.ma_dh.Width = 150;
            // 
            // ma_sp
            // 
            this.ma_sp.DataPropertyName = "ma_sp";
            this.ma_sp.HeaderText = "Mã Sản Phẩm";
            this.ma_sp.MinimumWidth = 6;
            this.ma_sp.Name = "ma_sp";
            this.ma_sp.ReadOnly = true;
            this.ma_sp.Width = 150;
            // 
            // ten_sp
            // 
            this.ten_sp.DataPropertyName = "ten_sp";
            this.ten_sp.HeaderText = "Tên Sản Phẩm";
            this.ten_sp.MinimumWidth = 6;
            this.ten_sp.Name = "ten_sp";
            this.ten_sp.ReadOnly = true;
            this.ten_sp.Width = 200;
            // 
            // so_luong
            // 
            this.so_luong.DataPropertyName = "so_luong";
            this.so_luong.HeaderText = "Số Lượng";
            this.so_luong.MinimumWidth = 6;
            this.so_luong.Name = "so_luong";
            this.so_luong.ReadOnly = true;
            this.so_luong.Width = 125;
            // 
            // giatien
            // 
            this.giatien.DataPropertyName = "giatien";
            this.giatien.HeaderText = "Giá Tiền";
            this.giatien.MinimumWidth = 6;
            this.giatien.Name = "giatien";
            this.giatien.ReadOnly = true;
            this.giatien.Width = 125;
            // 
            // tong_tien
            // 
            this.tong_tien.DataPropertyName = "tong_tien";
            this.tong_tien.HeaderText = "Tổng Tiền";
            this.tong_tien.MinimumWidth = 6;
            this.tong_tien.Name = "tong_tien";
            this.tong_tien.ReadOnly = true;
            this.tong_tien.Width = 125;
            // 
            // ngay_gio
            // 
            this.ngay_gio.DataPropertyName = "ngay_gio";
            this.ngay_gio.HeaderText = "Ngày Giờ";
            this.ngay_gio.MinimumWidth = 6;
            this.ngay_gio.Name = "ngay_gio";
            this.ngay_gio.ReadOnly = true;
            this.ngay_gio.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 727);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Name = "QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn Hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Panel panel6;
        private Button thoat;
        private Label label11;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ma_dh;
        private DataGridViewTextBoxColumn ma_sp;
        private DataGridViewTextBoxColumn ten_sp;
        private DataGridViewTextBoxColumn so_luong;
        private DataGridViewTextBoxColumn giatien;
        private DataGridViewTextBoxColumn tong_tien;
        private DataGridViewTextBoxColumn ngay_gio;
        private Label label43;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}