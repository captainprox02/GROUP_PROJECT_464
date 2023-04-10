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
            this.btn_DangNhapNV.Location = new System.Drawing.Point(355, 286);
            this.btn_DangNhapNV.Name = "btn_DangNhapNV";
            this.btn_DangNhapNV.Size = new System.Drawing.Size(114, 45);
            this.btn_DangNhapNV.TabIndex = 19;
            this.btn_DangNhapNV.Text = " Đăng nhập";
            this.btn_DangNhapNV.UseVisualStyleBackColor = true;
            this.btn_DangNhapNV.Click += new System.EventHandler(this.btn_DangNhapNV_Click);
            // 
            // txt_MatKhauNV
            // 
            this.txt_MatKhauNV.Location = new System.Drawing.Point(425, 206);
            this.txt_MatKhauNV.Name = "txt_MatKhauNV";
            this.txt_MatKhauNV.Size = new System.Drawing.Size(100, 22);
            this.txt_MatKhauNV.TabIndex = 18;
            this.txt_MatKhauNV.TextChanged += new System.EventHandler(this.txt_MatKhauNV_TextChanged);
            // 
            // txt_DangNhapNV
            // 
            this.txt_DangNhapNV.Location = new System.Drawing.Point(425, 119);
            this.txt_DangNhapNV.Name = "txt_DangNhapNV";
            this.txt_DangNhapNV.Size = new System.Drawing.Size(100, 22);
            this.txt_DangNhapNV.TabIndex = 17;
            this.txt_DangNhapNV.UseWaitCursor = true;
            this.txt_DangNhapNV.TextChanged += new System.EventHandler(this.txt_DangNhapNV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = " Mật khẩu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tài khoản:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_DangNhapNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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