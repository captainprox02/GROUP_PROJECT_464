namespace GROUP_PROJECT
{
    partial class frm_DangNhapNV
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
			this.btn_DangNhapNV = new System.Windows.Forms.Button();
			this.txt_MatKhauNV = new System.Windows.Forms.TextBox();
			this.txt_DangNhapNV = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_DangNhapNV
			// 
			this.btn_DangNhapNV.Location = new System.Drawing.Point(365, 274);
			this.btn_DangNhapNV.Margin = new System.Windows.Forms.Padding(2);
			this.btn_DangNhapNV.Name = "btn_DangNhapNV";
			this.btn_DangNhapNV.Size = new System.Drawing.Size(86, 37);
			this.btn_DangNhapNV.TabIndex = 14;
			this.btn_DangNhapNV.Text = " Đăng nhập";
			this.btn_DangNhapNV.UseVisualStyleBackColor = true;
			this.btn_DangNhapNV.Click += new System.EventHandler(this.btn_DangNhapNV_Click);
			// 
			// txt_MatKhauNV
			// 
			this.txt_MatKhauNV.Location = new System.Drawing.Point(418, 209);
			this.txt_MatKhauNV.Margin = new System.Windows.Forms.Padding(2);
			this.txt_MatKhauNV.Name = "txt_MatKhauNV";
			this.txt_MatKhauNV.Size = new System.Drawing.Size(76, 20);
			this.txt_MatKhauNV.TabIndex = 13;
			// 
			// txt_DangNhapNV
			// 
			this.txt_DangNhapNV.Location = new System.Drawing.Point(418, 139);
			this.txt_DangNhapNV.Margin = new System.Windows.Forms.Padding(2);
			this.txt_DangNhapNV.Name = "txt_DangNhapNV";
			this.txt_DangNhapNV.Size = new System.Drawing.Size(76, 20);
			this.txt_DangNhapNV.TabIndex = 12;
			this.txt_DangNhapNV.UseWaitCursor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(306, 213);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = " Mật khẩu:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(306, 143);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Tài khoản:";
			// 
			// frm_DangNhapNV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_DangNhapNV);
			this.Controls.Add(this.txt_MatKhauNV);
			this.Controls.Add(this.txt_DangNhapNV);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frm_DangNhapNV";
			this.Text = "frm_DangNhapNV";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btn_DangNhapNV;
		private System.Windows.Forms.TextBox txt_MatKhauNV;
		private System.Windows.Forms.TextBox txt_DangNhapNV;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}