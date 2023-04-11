namespace GROUP_PROJECT
{
    partial class frm_DangNhapKH
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
			this.btn_DangNhapKH = new System.Windows.Forms.Button();
			this.txt_MatKhauKH = new System.Windows.Forms.TextBox();
			this.txt_TaiKhoanKH = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.llb_DNNV = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// btn_DangNhapKH
			// 
			this.btn_DangNhapKH.Location = new System.Drawing.Point(360, 304);
			this.btn_DangNhapKH.Margin = new System.Windows.Forms.Padding(2);
			this.btn_DangNhapKH.Name = "btn_DangNhapKH";
			this.btn_DangNhapKH.Size = new System.Drawing.Size(88, 37);
			this.btn_DangNhapKH.TabIndex = 9;
			this.btn_DangNhapKH.Text = " Đăng nhập";
			this.btn_DangNhapKH.UseVisualStyleBackColor = true;
			this.btn_DangNhapKH.Click += new System.EventHandler(this.btn_DangNhapKH_Click);
			// 
			// txt_MatKhauKH
			// 
			this.txt_MatKhauKH.Location = new System.Drawing.Point(418, 210);
			this.txt_MatKhauKH.Margin = new System.Windows.Forms.Padding(2);
			this.txt_MatKhauKH.Name = "txt_MatKhauKH";
			this.txt_MatKhauKH.Size = new System.Drawing.Size(76, 20);
			this.txt_MatKhauKH.TabIndex = 8;
			// 
			// txt_TaiKhoanKH
			// 
			this.txt_TaiKhoanKH.Location = new System.Drawing.Point(418, 176);
			this.txt_TaiKhoanKH.Margin = new System.Windows.Forms.Padding(2);
			this.txt_TaiKhoanKH.Name = "txt_TaiKhoanKH";
			this.txt_TaiKhoanKH.Size = new System.Drawing.Size(76, 20);
			this.txt_TaiKhoanKH.TabIndex = 7;
			this.txt_TaiKhoanKH.UseWaitCursor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(307, 214);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = " Mật khẩu:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(307, 180);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Tài khoản:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(150, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(499, 42);
			this.label3.TabIndex = 18;
			this.label3.Text = "ĐĂNG NHẬP KHÁCH HÀNG";
			// 
			// llb_DNNV
			// 
			this.llb_DNNV.AutoSize = true;
			this.llb_DNNV.Location = new System.Drawing.Point(280, 265);
			this.llb_DNNV.Name = "llb_DNNV";
			this.llb_DNNV.Size = new System.Drawing.Size(237, 13);
			this.llb_DNNV.TabIndex = 17;
			this.llb_DNNV.TabStop = true;
			this.llb_DNNV.Text = "Nếu là Nhân Viên, nhấn vào đây để Đăng Nhập";
			this.llb_DNNV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// frm_DangNhapKH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.llb_DNNV);
			this.Controls.Add(this.btn_DangNhapKH);
			this.Controls.Add(this.txt_MatKhauKH);
			this.Controls.Add(this.txt_TaiKhoanKH);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frm_DangNhapKH";
			this.Text = "frm_DangNhapKH";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btn_DangNhapKH;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel llb_DNNV;
		public System.Windows.Forms.TextBox txt_MatKhauKH;
		public System.Windows.Forms.TextBox txt_TaiKhoanKH;
	}
}