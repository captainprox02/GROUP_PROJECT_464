namespace GROUP_PROJECT
{
	partial class frm_DatXe
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
			this.cb_LoaiXe = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cb_Xe = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.date_NgayDatXe = new System.Windows.Forms.DateTimePicker();
			this.date_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_DonGia = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_DatXe = new System.Windows.Forms.Button();
			this.btn_Thoat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_LoaiXe
			// 
			this.cb_LoaiXe.FormattingEnabled = true;
			this.cb_LoaiXe.Items.AddRange(new object[] {
            "Xe Du Lịch",
            "Xe Chở Hàng"});
			this.cb_LoaiXe.Location = new System.Drawing.Point(114, 42);
			this.cb_LoaiXe.Name = "cb_LoaiXe";
			this.cb_LoaiXe.Size = new System.Drawing.Size(121, 21);
			this.cb_LoaiXe.TabIndex = 0;
			this.cb_LoaiXe.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiXe_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Loại xe";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Chọn xe";
			// 
			// cb_Xe
			// 
			this.cb_Xe.FormattingEnabled = true;
			this.cb_Xe.Location = new System.Drawing.Point(114, 82);
			this.cb_Xe.Name = "cb_Xe";
			this.cb_Xe.Size = new System.Drawing.Size(121, 21);
			this.cb_Xe.TabIndex = 2;
			this.cb_Xe.SelectedIndexChanged += new System.EventHandler(this.cb_Xe_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Thuê từ ngày";
			// 
			// date_NgayDatXe
			// 
			this.date_NgayDatXe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_NgayDatXe.Location = new System.Drawing.Point(114, 121);
			this.date_NgayDatXe.Name = "date_NgayDatXe";
			this.date_NgayDatXe.Size = new System.Drawing.Size(121, 20);
			this.date_NgayDatXe.TabIndex = 7;
			this.date_NgayDatXe.ValueChanged += new System.EventHandler(this.date_NgayDatXe_ValueChanged);
			// 
			// date_NgayKetThuc
			// 
			this.date_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_NgayKetThuc.Location = new System.Drawing.Point(114, 160);
			this.date_NgayKetThuc.Name = "date_NgayKetThuc";
			this.date_NgayKetThuc.Size = new System.Drawing.Size(121, 20);
			this.date_NgayKetThuc.TabIndex = 9;
			this.date_NgayKetThuc.ValueChanged += new System.EventHandler(this.date_NgayKetThuc_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(45, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Đến ngày";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(52, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Đơn giá";
			// 
			// txt_DonGia
			// 
			this.txt_DonGia.Location = new System.Drawing.Point(114, 198);
			this.txt_DonGia.Name = "txt_DonGia";
			this.txt_DonGia.ReadOnly = true;
			this.txt_DonGia.Size = new System.Drawing.Size(121, 20);
			this.txt_DonGia.TabIndex = 11;
			this.txt_DonGia.Text = "0";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(273, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(149, 176);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// btn_DatXe
			// 
			this.btn_DatXe.Location = new System.Drawing.Point(248, 259);
			this.btn_DatXe.Name = "btn_DatXe";
			this.btn_DatXe.Size = new System.Drawing.Size(75, 23);
			this.btn_DatXe.TabIndex = 13;
			this.btn_DatXe.Text = "Đặt xe";
			this.btn_DatXe.UseVisualStyleBackColor = true;
			this.btn_DatXe.Click += new System.EventHandler(this.btn_DatXe_Click);
			// 
			// btn_Thoat
			// 
			this.btn_Thoat.Location = new System.Drawing.Point(347, 259);
			this.btn_Thoat.Name = "btn_Thoat";
			this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
			this.btn_Thoat.TabIndex = 14;
			this.btn_Thoat.Text = "Thoát";
			this.btn_Thoat.UseVisualStyleBackColor = true;
			this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
			// 
			// frm_DatXe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 306);
			this.Controls.Add(this.btn_Thoat);
			this.Controls.Add(this.btn_DatXe);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txt_DonGia);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.date_NgayKetThuc);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.date_NgayDatXe);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cb_Xe);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cb_LoaiXe);
			this.Name = "frm_DatXe";
			this.Text = "frm_DatXe";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_LoaiXe;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cb_Xe;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker date_NgayDatXe;
		private System.Windows.Forms.DateTimePicker date_NgayKetThuc;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_DonGia;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_DatXe;
		private System.Windows.Forms.Button btn_Thoat;
	}
}