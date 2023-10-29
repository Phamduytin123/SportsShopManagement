namespace DoAn
{
    partial class ManHinhChinh
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
            System.Windows.Forms.Panel panel3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManHinhChinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSportsShop = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHello = new System.Windows.Forms.Label();
            this.bttDangXuat = new System.Windows.Forms.Button();
            this.bttHoaDon = new System.Windows.Forms.Button();
            this.bttNhanVien = new System.Windows.Forms.Button();
            this.bttSanPham = new System.Windows.Forms.Button();
            this.bttTrangChu = new System.Windows.Forms.Button();
            this.trangChu1 = new DoAn.TrangChu();
            this.hoaDon1 = new DoAn.HoaDon();
            this.nhanVien1 = new DoAn.NhanVien();
            this.sanPham1 = new DoAn.SanPham();
            panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            panel3.Location = new System.Drawing.Point(-3, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(185, 213);
            panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbSportsShop);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 88);
            this.panel1.TabIndex = 0;
            // 
            // lbSportsShop
            // 
            this.lbSportsShop.AutoSize = true;
            this.lbSportsShop.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSportsShop.Location = new System.Drawing.Point(324, 20);
            this.lbSportsShop.Name = "lbSportsShop";
            this.lbSportsShop.Size = new System.Drawing.Size(324, 47);
            this.lbSportsShop.TabIndex = 3;
            this.lbSportsShop.Text = "Sport Clothes Shop";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(189, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(747, 587);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(panel3);
            this.panel2.Controls.Add(this.bttDangXuat);
            this.panel2.Controls.Add(this.bttHoaDon);
            this.panel2.Controls.Add(this.bttNhanVien);
            this.panel2.Controls.Add(this.bttSanPham);
            this.panel2.Controls.Add(this.bttTrangChu);
            this.panel2.Location = new System.Drawing.Point(-3, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 587);
            this.panel2.TabIndex = 1;
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.Location = new System.Drawing.Point(24, 307);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(48, 20);
            this.lbHello.TabIndex = 5;
            this.lbHello.Text = "Hello";
            // 
            // bttDangXuat
            // 
            this.bttDangXuat.BackColor = System.Drawing.Color.LightSalmon;
            this.bttDangXuat.FlatAppearance.BorderSize = 0;
            this.bttDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDangXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDangXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttDangXuat.Location = new System.Drawing.Point(-3, 520);
            this.bttDangXuat.Name = "bttDangXuat";
            this.bttDangXuat.Size = new System.Drawing.Size(185, 64);
            this.bttDangXuat.TabIndex = 4;
            this.bttDangXuat.Text = "ĐĂNG XUẤT";
            this.bttDangXuat.UseVisualStyleBackColor = false;
            this.bttDangXuat.Click += new System.EventHandler(this.bttDangXuat_Click);
            // 
            // bttHoaDon
            // 
            this.bttHoaDon.BackColor = System.Drawing.Color.LightSalmon;
            this.bttHoaDon.FlatAppearance.BorderSize = 0;
            this.bttHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHoaDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttHoaDon.Location = new System.Drawing.Point(-3, 450);
            this.bttHoaDon.Name = "bttHoaDon";
            this.bttHoaDon.Size = new System.Drawing.Size(185, 64);
            this.bttHoaDon.TabIndex = 4;
            this.bttHoaDon.Text = "HÓA ĐƠN";
            this.bttHoaDon.UseVisualStyleBackColor = false;
            this.bttHoaDon.Click += new System.EventHandler(this.bttHoaDon_Click);
            // 
            // bttNhanVien
            // 
            this.bttNhanVien.BackColor = System.Drawing.Color.LightSalmon;
            this.bttNhanVien.FlatAppearance.BorderSize = 0;
            this.bttNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttNhanVien.Location = new System.Drawing.Point(-3, 380);
            this.bttNhanVien.Name = "bttNhanVien";
            this.bttNhanVien.Size = new System.Drawing.Size(185, 64);
            this.bttNhanVien.TabIndex = 4;
            this.bttNhanVien.Text = "NHÂN VIÊN";
            this.bttNhanVien.UseVisualStyleBackColor = false;
            this.bttNhanVien.Click += new System.EventHandler(this.bttNhanVien_Click);
            // 
            // bttSanPham
            // 
            this.bttSanPham.BackColor = System.Drawing.Color.LightSalmon;
            this.bttSanPham.FlatAppearance.BorderSize = 0;
            this.bttSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttSanPham.Location = new System.Drawing.Point(-3, 310);
            this.bttSanPham.Name = "bttSanPham";
            this.bttSanPham.Size = new System.Drawing.Size(185, 64);
            this.bttSanPham.TabIndex = 4;
            this.bttSanPham.Text = "SẢN PHẨM";
            this.bttSanPham.UseVisualStyleBackColor = false;
            this.bttSanPham.Click += new System.EventHandler(this.bttSanPham_Click);
            // 
            // bttTrangChu
            // 
            this.bttTrangChu.BackColor = System.Drawing.Color.LightSalmon;
            this.bttTrangChu.FlatAppearance.BorderSize = 0;
            this.bttTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttTrangChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTrangChu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttTrangChu.Location = new System.Drawing.Point(-3, 240);
            this.bttTrangChu.Name = "bttTrangChu";
            this.bttTrangChu.Size = new System.Drawing.Size(185, 64);
            this.bttTrangChu.TabIndex = 3;
            this.bttTrangChu.Text = "TRANG CHỦ";
            this.bttTrangChu.UseVisualStyleBackColor = false;
            this.bttTrangChu.Click += new System.EventHandler(this.bttTrangChu_Click);
            // 
            // trangChu1
            // 
            this.trangChu1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trangChu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trangChu1.BackgroundImage")));
            this.trangChu1.Location = new System.Drawing.Point(185, 89);
            this.trangChu1.Name = "trangChu1";
            this.trangChu1.Size = new System.Drawing.Size(750, 587);
            this.trangChu1.TabIndex = 2;
            // 
            // hoaDon1
            // 
            this.hoaDon1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hoaDon1.Location = new System.Drawing.Point(178, 87);
            this.hoaDon1.Name = "hoaDon1";
            this.hoaDon1.Size = new System.Drawing.Size(757, 591);
            this.hoaDon1.TabIndex = 3;
            // 
            // nhanVien1
            // 
            this.nhanVien1.BackColor = System.Drawing.Color.BurlyWood;
            this.nhanVien1.Location = new System.Drawing.Point(178, 90);
            this.nhanVien1.Name = "nhanVien1";
            this.nhanVien1.Size = new System.Drawing.Size(757, 587);
            this.nhanVien1.TabIndex = 5;
            // 
            // sanPham1
            // 
            this.sanPham1.BackColor = System.Drawing.Color.LemonChiffon;
            this.sanPham1.Location = new System.Drawing.Point(185, 89);
            this.sanPham1.Name = "sanPham1";
            this.sanPham1.Size = new System.Drawing.Size(750, 587);
            this.sanPham1.TabIndex = 4;
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(934, 676);
            this.Controls.Add(this.trangChu1);
            this.Controls.Add(this.lbHello);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hoaDon1);
            this.Controls.Add(this.nhanVien1);
            this.Controls.Add(this.sanPham1);
            this.Name = "ManHinhChinh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bttDangXuat;
        private System.Windows.Forms.Button bttHoaDon;
        private System.Windows.Forms.Button bttNhanVien;
        private System.Windows.Forms.Button bttSanPham;
        private System.Windows.Forms.Button bttTrangChu;
        private System.Windows.Forms.Label lbSportsShop;
        private TrangChu trangChu1;
        private HoaDon hoaDon1;
        private System.Windows.Forms.Label lbHello;
        private SanPham sanPham1;
        private NhanVien nhanVien1;
    }
}

