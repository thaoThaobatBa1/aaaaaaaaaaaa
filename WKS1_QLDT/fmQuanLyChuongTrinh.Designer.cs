namespace Form1
{
    partial class fmQuanLyChuongTrinh
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
            this.btQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btQuanLyKhachHang = new System.Windows.Forms.Button();
            this.btQuanLySanPham = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btQuanLyNhanVien
            // 
            this.btQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanLyNhanVien.Location = new System.Drawing.Point(80, 143);
            this.btQuanLyNhanVien.Name = "btQuanLyNhanVien";
            this.btQuanLyNhanVien.Size = new System.Drawing.Size(174, 60);
            this.btQuanLyNhanVien.TabIndex = 0;
            this.btQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.btQuanLyNhanVien.UseVisualStyleBackColor = true;
            // 
            // btQuanLyKhachHang
            // 
            this.btQuanLyKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanLyKhachHang.Location = new System.Drawing.Point(310, 143);
            this.btQuanLyKhachHang.Name = "btQuanLyKhachHang";
            this.btQuanLyKhachHang.Size = new System.Drawing.Size(174, 60);
            this.btQuanLyKhachHang.TabIndex = 1;
            this.btQuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            this.btQuanLyKhachHang.UseVisualStyleBackColor = true;
            // 
            // btQuanLySanPham
            // 
            this.btQuanLySanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanLySanPham.Location = new System.Drawing.Point(554, 143);
            this.btQuanLySanPham.Name = "btQuanLySanPham";
            this.btQuanLySanPham.Size = new System.Drawing.Size(174, 60);
            this.btQuanLySanPham.TabIndex = 2;
            this.btQuanLySanPham.Text = "Quản Lý Sản Phẩm";
            this.btQuanLySanPham.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(310, 259);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(174, 60);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // fmQuanLyChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btQuanLySanPham);
            this.Controls.Add(this.btQuanLyKhachHang);
            this.Controls.Add(this.btQuanLyNhanVien);
            this.Name = "fmQuanLyChuongTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Chương Trình";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuanLyNhanVien;
        private System.Windows.Forms.Button btQuanLyKhachHang;
        private System.Windows.Forms.Button btQuanLySanPham;
        private System.Windows.Forms.Button btThoat;
    }
}