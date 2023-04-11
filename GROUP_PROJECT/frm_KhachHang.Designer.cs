namespace GROUP_PROJECT
{
	partial class frm_KhachHang
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
			this.btn_DatXe = new System.Windows.Forms.Button();
			this.btn_HuyXe = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_DatXe
			// 
			this.btn_DatXe.Location = new System.Drawing.Point(12, 52);
			this.btn_DatXe.Name = "btn_DatXe";
			this.btn_DatXe.Size = new System.Drawing.Size(361, 99);
			this.btn_DatXe.TabIndex = 0;
			this.btn_DatXe.Text = "Đặt xe";
			this.btn_DatXe.UseVisualStyleBackColor = true;
			this.btn_DatXe.Click += new System.EventHandler(this.btn_DatXe_Click);
			// 
			// btn_HuyXe
			// 
			this.btn_HuyXe.Location = new System.Drawing.Point(379, 52);
			this.btn_HuyXe.Name = "btn_HuyXe";
			this.btn_HuyXe.Size = new System.Drawing.Size(340, 99);
			this.btn_HuyXe.TabIndex = 1;
			this.btn_HuyXe.Text = "Huỷ xe";
			this.btn_HuyXe.UseVisualStyleBackColor = true;
			this.btn_HuyXe.Click += new System.EventHandler(this.btn_HuyXe_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 185);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(706, 253);
			this.dataGridView1.TabIndex = 2;
			// 
			// frm_KhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_HuyXe);
			this.Controls.Add(this.btn_DatXe);
			this.Name = "frm_KhachHang";
			this.Text = "frm_KhachHang";
			this.Load += new System.EventHandler(this.frm_KhachHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_DatXe;
		private System.Windows.Forms.Button btn_HuyXe;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}