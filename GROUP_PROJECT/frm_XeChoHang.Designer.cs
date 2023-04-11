namespace GROUP_PROJECT
{
    partial class frm_XeChoHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.txt_MaXe = new System.Windows.Forms.TextBox();
			this.lbl_MaXe = new System.Windows.Forms.Label();
			this.lbl_BienSo = new System.Windows.Forms.Label();
			this.lbl_TenXe = new System.Windows.Forms.Label();
			this.lbl_TrongTai = new System.Windows.Forms.Label();
			this.lbl_NgayDangKiem = new System.Windows.Forms.Label();
			this.lbl_TieuChuanBang = new System.Windows.Forms.Label();
			this.lbl_SoTan = new System.Windows.Forms.Label();
			this.date_NgayDangKiem = new System.Windows.Forms.DateTimePicker();
			this.txt_BienSo = new System.Windows.Forms.TextBox();
			this.txt_TenXe = new System.Windows.Forms.TextBox();
			this.txt_TrongTai = new System.Windows.Forms.TextBox();
			this.txt_TieuChuanBang = new System.Windows.Forms.TextBox();
			this.txt_SoTan = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_Them = new System.Windows.Forms.Button();
			this.btn_Sua = new System.Windows.Forms.Button();
			this.btn_Xoa = new System.Windows.Forms.Button();
			this.btn_Thoat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_MaXe
			// 
			this.txt_MaXe.Location = new System.Drawing.Point(217, 32);
			this.txt_MaXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_MaXe.Name = "txt_MaXe";
			this.txt_MaXe.ReadOnly = true;
			this.txt_MaXe.Size = new System.Drawing.Size(151, 20);
			this.txt_MaXe.TabIndex = 0;
			// 
			// lbl_MaXe
			// 
			this.lbl_MaXe.AutoSize = true;
			this.lbl_MaXe.Location = new System.Drawing.Point(120, 32);
			this.lbl_MaXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_MaXe.Name = "lbl_MaXe";
			this.lbl_MaXe.Size = new System.Drawing.Size(38, 13);
			this.lbl_MaXe.TabIndex = 1;
			this.lbl_MaXe.Text = "Mã Xe";
			// 
			// lbl_BienSo
			// 
			this.lbl_BienSo.AutoSize = true;
			this.lbl_BienSo.Location = new System.Drawing.Point(120, 74);
			this.lbl_BienSo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_BienSo.Name = "lbl_BienSo";
			this.lbl_BienSo.Size = new System.Drawing.Size(44, 13);
			this.lbl_BienSo.TabIndex = 2;
			this.lbl_BienSo.Text = "Biển Số";
			// 
			// lbl_TenXe
			// 
			this.lbl_TenXe.AutoSize = true;
			this.lbl_TenXe.Location = new System.Drawing.Point(120, 111);
			this.lbl_TenXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_TenXe.Name = "lbl_TenXe";
			this.lbl_TenXe.Size = new System.Drawing.Size(42, 13);
			this.lbl_TenXe.TabIndex = 3;
			this.lbl_TenXe.Text = "Tên Xe";
			// 
			// lbl_TrongTai
			// 
			this.lbl_TrongTai.AutoSize = true;
			this.lbl_TrongTai.Location = new System.Drawing.Point(120, 145);
			this.lbl_TrongTai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_TrongTai.Name = "lbl_TrongTai";
			this.lbl_TrongTai.Size = new System.Drawing.Size(49, 13);
			this.lbl_TrongTai.TabIndex = 4;
			this.lbl_TrongTai.Text = "Trọng tải";
			// 
			// lbl_NgayDangKiem
			// 
			this.lbl_NgayDangKiem.AutoSize = true;
			this.lbl_NgayDangKiem.Location = new System.Drawing.Point(120, 180);
			this.lbl_NgayDangKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_NgayDangKiem.Name = "lbl_NgayDangKiem";
			this.lbl_NgayDangKiem.Size = new System.Drawing.Size(87, 13);
			this.lbl_NgayDangKiem.TabIndex = 5;
			this.lbl_NgayDangKiem.Text = "Ngày Đăng Kiểm";
			// 
			// lbl_TieuChuanBang
			// 
			this.lbl_TieuChuanBang.AutoSize = true;
			this.lbl_TieuChuanBang.Location = new System.Drawing.Point(120, 219);
			this.lbl_TieuChuanBang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_TieuChuanBang.Name = "lbl_TieuChuanBang";
			this.lbl_TieuChuanBang.Size = new System.Drawing.Size(90, 13);
			this.lbl_TieuChuanBang.TabIndex = 6;
			this.lbl_TieuChuanBang.Text = "Tiêu Chuẩn Bằng";
			// 
			// lbl_SoTan
			// 
			this.lbl_SoTan.AutoSize = true;
			this.lbl_SoTan.Location = new System.Drawing.Point(120, 258);
			this.lbl_SoTan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_SoTan.Name = "lbl_SoTan";
			this.lbl_SoTan.Size = new System.Drawing.Size(42, 13);
			this.lbl_SoTan.TabIndex = 7;
			this.lbl_SoTan.Text = "Số Tấn";
			// 
			// date_NgayDangKiem
			// 
			this.date_NgayDangKiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_NgayDangKiem.Location = new System.Drawing.Point(217, 180);
			this.date_NgayDangKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.date_NgayDangKiem.Name = "date_NgayDangKiem";
			this.date_NgayDangKiem.Size = new System.Drawing.Size(151, 20);
			this.date_NgayDangKiem.TabIndex = 8;
			// 
			// txt_BienSo
			// 
			this.txt_BienSo.Location = new System.Drawing.Point(217, 74);
			this.txt_BienSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_BienSo.Name = "txt_BienSo";
			this.txt_BienSo.ReadOnly = true;
			this.txt_BienSo.Size = new System.Drawing.Size(151, 20);
			this.txt_BienSo.TabIndex = 9;
			// 
			// txt_TenXe
			// 
			this.txt_TenXe.Location = new System.Drawing.Point(217, 111);
			this.txt_TenXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_TenXe.Name = "txt_TenXe";
			this.txt_TenXe.ReadOnly = true;
			this.txt_TenXe.Size = new System.Drawing.Size(151, 20);
			this.txt_TenXe.TabIndex = 10;
			// 
			// txt_TrongTai
			// 
			this.txt_TrongTai.Location = new System.Drawing.Point(217, 145);
			this.txt_TrongTai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_TrongTai.Name = "txt_TrongTai";
			this.txt_TrongTai.ReadOnly = true;
			this.txt_TrongTai.Size = new System.Drawing.Size(151, 20);
			this.txt_TrongTai.TabIndex = 11;
			// 
			// txt_TieuChuanBang
			// 
			this.txt_TieuChuanBang.Location = new System.Drawing.Point(217, 219);
			this.txt_TieuChuanBang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_TieuChuanBang.Name = "txt_TieuChuanBang";
			this.txt_TieuChuanBang.ReadOnly = true;
			this.txt_TieuChuanBang.Size = new System.Drawing.Size(151, 20);
			this.txt_TieuChuanBang.TabIndex = 12;
			// 
			// txt_SoTan
			// 
			this.txt_SoTan.Location = new System.Drawing.Point(217, 258);
			this.txt_SoTan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_SoTan.Name = "txt_SoTan";
			this.txt_SoTan.ReadOnly = true;
			this.txt_SoTan.Size = new System.Drawing.Size(151, 20);
			this.txt_SoTan.TabIndex = 13;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(427, 32);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(212, 243);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(43, 337);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(682, 166);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// btn_Them
			// 
			this.btn_Them.Location = new System.Drawing.Point(122, 299);
			this.btn_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(83, 26);
			this.btn_Them.TabIndex = 16;
			this.btn_Them.Text = "Thêm";
			this.btn_Them.UseVisualStyleBackColor = true;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// btn_Sua
			// 
			this.btn_Sua.Location = new System.Drawing.Point(240, 299);
			this.btn_Sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Sua.Name = "btn_Sua";
			this.btn_Sua.Size = new System.Drawing.Size(83, 26);
			this.btn_Sua.TabIndex = 17;
			this.btn_Sua.Text = "Sửa";
			this.btn_Sua.UseVisualStyleBackColor = true;
			this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
			// 
			// btn_Xoa
			// 
			this.btn_Xoa.Location = new System.Drawing.Point(355, 299);
			this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(83, 26);
			this.btn_Xoa.TabIndex = 18;
			this.btn_Xoa.Text = "Xóa";
			this.btn_Xoa.UseVisualStyleBackColor = true;
			this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
			// 
			// btn_Thoat
			// 
			this.btn_Thoat.Location = new System.Drawing.Point(556, 299);
			this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Thoat.Name = "btn_Thoat";
			this.btn_Thoat.Size = new System.Drawing.Size(83, 26);
			this.btn_Thoat.TabIndex = 19;
			this.btn_Thoat.Text = "Thoát";
			this.btn_Thoat.UseVisualStyleBackColor = true;
			this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
			// 
			// frm_XeChoHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 532);
			this.Controls.Add(this.btn_Thoat);
			this.Controls.Add(this.btn_Xoa);
			this.Controls.Add(this.btn_Sua);
			this.Controls.Add(this.btn_Them);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txt_SoTan);
			this.Controls.Add(this.txt_TieuChuanBang);
			this.Controls.Add(this.txt_TrongTai);
			this.Controls.Add(this.txt_TenXe);
			this.Controls.Add(this.txt_BienSo);
			this.Controls.Add(this.date_NgayDangKiem);
			this.Controls.Add(this.lbl_SoTan);
			this.Controls.Add(this.lbl_TieuChuanBang);
			this.Controls.Add(this.lbl_NgayDangKiem);
			this.Controls.Add(this.lbl_TrongTai);
			this.Controls.Add(this.lbl_TenXe);
			this.Controls.Add(this.lbl_BienSo);
			this.Controls.Add(this.lbl_MaXe);
			this.Controls.Add(this.txt_MaXe);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frm_XeChoHang";
			this.Text = "frm_XeChoHang";
			this.Load += new System.EventHandler(this.frm_XeChoHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MaXe;
        private System.Windows.Forms.Label lbl_MaXe;
        private System.Windows.Forms.Label lbl_BienSo;
        private System.Windows.Forms.Label lbl_TenXe;
        private System.Windows.Forms.Label lbl_TrongTai;
        private System.Windows.Forms.Label lbl_NgayDangKiem;
        private System.Windows.Forms.Label lbl_TieuChuanBang;
        private System.Windows.Forms.Label lbl_SoTan;
        private System.Windows.Forms.DateTimePicker date_NgayDangKiem;
        private System.Windows.Forms.TextBox txt_BienSo;
        private System.Windows.Forms.TextBox txt_TenXe;
        private System.Windows.Forms.TextBox txt_TrongTai;
        private System.Windows.Forms.TextBox txt_TieuChuanBang;
        private System.Windows.Forms.TextBox txt_SoTan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
    }
}