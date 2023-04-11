namespace GROUP_PROJECT
{
	partial class frm_HuyXe
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_Huy = new System.Windows.Forms.Button();
			this.btn_Thoat = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txt_DonGia = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.date_NgayDatXe = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_SoNgaythue = new System.Windows.Forms.TextBox();
			this.txt_LoaiXe = new System.Windows.Forms.TextBox();
			this.txt_TenXe = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 245);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(776, 193);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// btn_Huy
			// 
			this.btn_Huy.Location = new System.Drawing.Point(632, 202);
			this.btn_Huy.Name = "btn_Huy";
			this.btn_Huy.Size = new System.Drawing.Size(75, 23);
			this.btn_Huy.TabIndex = 1;
			this.btn_Huy.Text = "Huỷ Xe";
			this.btn_Huy.UseVisualStyleBackColor = true;
			this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
			// 
			// btn_Thoat
			// 
			this.btn_Thoat.Location = new System.Drawing.Point(713, 202);
			this.btn_Thoat.Name = "btn_Thoat";
			this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
			this.btn_Thoat.TabIndex = 2;
			this.btn_Thoat.Text = "Thoát";
			this.btn_Thoat.UseVisualStyleBackColor = true;
			this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(278, 49);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(149, 176);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 25;
			this.pictureBox1.TabStop = false;
			// 
			// txt_DonGia
			// 
			this.txt_DonGia.Location = new System.Drawing.Point(119, 205);
			this.txt_DonGia.Name = "txt_DonGia";
			this.txt_DonGia.ReadOnly = true;
			this.txt_DonGia.Size = new System.Drawing.Size(121, 20);
			this.txt_DonGia.TabIndex = 24;
			this.txt_DonGia.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(57, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 23;
			this.label5.Text = "Đơn giá";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 21;
			this.label4.Text = "Số ngày thuê";
			// 
			// date_NgayDatXe
			// 
			this.date_NgayDatXe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_NgayDatXe.Location = new System.Drawing.Point(119, 128);
			this.date_NgayDatXe.Name = "date_NgayDatXe";
			this.date_NgayDatXe.Size = new System.Drawing.Size(121, 20);
			this.date_NgayDatXe.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Thuê từ ngày";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "Tên xe";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Loại xe";
			// 
			// txt_SoNgaythue
			// 
			this.txt_SoNgaythue.Location = new System.Drawing.Point(119, 167);
			this.txt_SoNgaythue.Name = "txt_SoNgaythue";
			this.txt_SoNgaythue.ReadOnly = true;
			this.txt_SoNgaythue.Size = new System.Drawing.Size(121, 20);
			this.txt_SoNgaythue.TabIndex = 26;
			// 
			// txt_LoaiXe
			// 
			this.txt_LoaiXe.Location = new System.Drawing.Point(119, 49);
			this.txt_LoaiXe.Name = "txt_LoaiXe";
			this.txt_LoaiXe.ReadOnly = true;
			this.txt_LoaiXe.Size = new System.Drawing.Size(121, 20);
			this.txt_LoaiXe.TabIndex = 27;
			// 
			// txt_TenXe
			// 
			this.txt_TenXe.Location = new System.Drawing.Point(119, 89);
			this.txt_TenXe.Name = "txt_TenXe";
			this.txt_TenXe.ReadOnly = true;
			this.txt_TenXe.Size = new System.Drawing.Size(121, 20);
			this.txt_TenXe.TabIndex = 28;
			// 
			// frm_HuyXe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txt_TenXe);
			this.Controls.Add(this.txt_LoaiXe);
			this.Controls.Add(this.txt_SoNgaythue);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txt_DonGia);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.date_NgayDatXe);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Thoat);
			this.Controls.Add(this.btn_Huy);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frm_HuyXe";
			this.Text = "HuyXe";
			this.Load += new System.EventHandler(this.HuyXe_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_Huy;
		private System.Windows.Forms.Button btn_Thoat;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txt_DonGia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker date_NgayDatXe;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_SoNgaythue;
		private System.Windows.Forms.TextBox txt_LoaiXe;
		private System.Windows.Forms.TextBox txt_TenXe;
	}
}