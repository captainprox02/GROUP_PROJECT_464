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
            this.SuspendLayout();
            // 
            // btn_DangNhapKH
            // 
            this.btn_DangNhapKH.Location = new System.Drawing.Point(355, 286);
            this.btn_DangNhapKH.Name = "btn_DangNhapKH";
            this.btn_DangNhapKH.Size = new System.Drawing.Size(118, 46);
            this.btn_DangNhapKH.TabIndex = 9;
            this.btn_DangNhapKH.Text = " Đăng nhập";
            this.btn_DangNhapKH.UseVisualStyleBackColor = true;
            this.btn_DangNhapKH.Click += new System.EventHandler(this.btn_DangNhapKH_Click);
            // 
            // txt_MatKhauKH
            // 
            this.txt_MatKhauKH.Location = new System.Drawing.Point(425, 206);
            this.txt_MatKhauKH.Name = "txt_MatKhauKH";
            this.txt_MatKhauKH.Size = new System.Drawing.Size(100, 22);
            this.txt_MatKhauKH.TabIndex = 8;
            // 
            // txt_TaiKhoanKH
            // 
            this.txt_TaiKhoanKH.Location = new System.Drawing.Point(425, 119);
            this.txt_TaiKhoanKH.Name = "txt_TaiKhoanKH";
            this.txt_TaiKhoanKH.Size = new System.Drawing.Size(100, 22);
            this.txt_TaiKhoanKH.TabIndex = 7;
            this.txt_TaiKhoanKH.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = " Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài khoản:";
            // 
            // frm_DangNhapKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.TextBox txt_MatKhauKH;
        private System.Windows.Forms.TextBox txt_TaiKhoanKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}