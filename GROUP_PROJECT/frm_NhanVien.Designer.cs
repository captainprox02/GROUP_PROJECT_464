namespace GROUP_PROJECT
{
	partial class frm_NhanVien
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
			this.btn_QLXeChoHang = new System.Windows.Forms.Button();
			this.btn_QLXeDuLich = new System.Windows.Forms.Button();
			this.btn_PheDuyet = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_QLXeChoHang
			// 
			this.btn_QLXeChoHang.Location = new System.Drawing.Point(225, 103);
			this.btn_QLXeChoHang.Name = "btn_QLXeChoHang";
			this.btn_QLXeChoHang.Size = new System.Drawing.Size(106, 99);
			this.btn_QLXeChoHang.TabIndex = 3;
			this.btn_QLXeChoHang.Text = "Quản Lý Xe Chở Hàng";
			this.btn_QLXeChoHang.UseVisualStyleBackColor = true;
			this.btn_QLXeChoHang.Click += new System.EventHandler(this.btn_QLXeChoHang_Click);
			// 
			// btn_QLXeDuLich
			// 
			this.btn_QLXeDuLich.Location = new System.Drawing.Point(80, 103);
			this.btn_QLXeDuLich.Name = "btn_QLXeDuLich";
			this.btn_QLXeDuLich.Size = new System.Drawing.Size(106, 99);
			this.btn_QLXeDuLich.TabIndex = 2;
			this.btn_QLXeDuLich.Text = "Quản Lý Xe Du Lịch";
			this.btn_QLXeDuLich.UseVisualStyleBackColor = true;
			this.btn_QLXeDuLich.Click += new System.EventHandler(this.btn_QLXeDuLich_Click);
			// 
			// btn_PheDuyet
			// 
			this.btn_PheDuyet.Location = new System.Drawing.Point(364, 103);
			this.btn_PheDuyet.Name = "btn_PheDuyet";
			this.btn_PheDuyet.Size = new System.Drawing.Size(106, 99);
			this.btn_PheDuyet.TabIndex = 4;
			this.btn_PheDuyet.Text = "Phê Duyệt Hợp Đồng";
			this.btn_PheDuyet.UseVisualStyleBackColor = true;
			this.btn_PheDuyet.Click += new System.EventHandler(this.btn_PheDuyet_Click);
			// 
			// frm_NhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_PheDuyet);
			this.Controls.Add(this.btn_QLXeChoHang);
			this.Controls.Add(this.btn_QLXeDuLich);
			this.Name = "frm_NhanVien";
			this.Text = "frm_NhanVien";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_QLXeChoHang;
		private System.Windows.Forms.Button btn_QLXeDuLich;
		private System.Windows.Forms.Button btn_PheDuyet;
	}
}