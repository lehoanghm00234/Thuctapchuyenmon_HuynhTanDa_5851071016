namespace QLKhachSanVui
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKhachhang1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnInhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDatphong1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThuephong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mndanhsachloaiphong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTinhtrang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChucvu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.lbllogo = new System.Windows.Forms.Label();
            this.doanhThuTheoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHethong,
            this.mnKhachhang1,
            this.mnDatphong1,
            this.mnQuanly,
            this.mnBaocao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnHethong
            // 
            this.mnHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDangnhap,
            this.mnDangxuat,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.mnThoat});
            this.mnHethong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnHethong.Name = "mnHethong";
            this.mnHethong.Size = new System.Drawing.Size(102, 28);
            this.mnHethong.Text = "Hệ thống";
            // 
            // mnDangnhap
            // 
            this.mnDangnhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnDangnhap.Image = ((System.Drawing.Image)(resources.GetObject("mnDangnhap.Image")));
            this.mnDangnhap.Name = "mnDangnhap";
            this.mnDangnhap.Size = new System.Drawing.Size(224, 28);
            this.mnDangnhap.Text = "Đăng nhập";
            this.mnDangnhap.Click += new System.EventHandler(this.mnDangnhap_Click);
            // 
            // mnDangxuat
            // 
            this.mnDangxuat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnDangxuat.Image = ((System.Drawing.Image)(resources.GetObject("mnDangxuat.Image")));
            this.mnDangxuat.Name = "mnDangxuat";
            this.mnDangxuat.Size = new System.Drawing.Size(224, 28);
            this.mnDangxuat.Text = "Đăng xuất";
            this.mnDangxuat.Click += new System.EventHandler(this.mnDangxuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnThoat
            // 
            this.mnThoat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(224, 28);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.Click += new System.EventHandler(this.mnThoat_Click);
            // 
            // mnKhachhang1
            // 
            this.mnKhachhang1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnKhachhang,
            this.mnInhoadon});
            this.mnKhachhang1.Enabled = false;
            this.mnKhachhang1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnKhachhang1.Name = "mnKhachhang1";
            this.mnKhachhang1.Size = new System.Drawing.Size(126, 28);
            this.mnKhachhang1.Text = "Khách hàng";
            // 
            // mnKhachhang
            // 
            this.mnKhachhang.Enabled = false;
            this.mnKhachhang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnKhachhang.Name = "mnKhachhang";
            this.mnKhachhang.Size = new System.Drawing.Size(288, 28);
            this.mnKhachhang.Text = "Danh sách khách hàng";
            this.mnKhachhang.Click += new System.EventHandler(this.mnKhachhang_Click);
            // 
            // mnInhoadon
            // 
            this.mnInhoadon.Enabled = false;
            this.mnInhoadon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnInhoadon.Name = "mnInhoadon";
            this.mnInhoadon.Size = new System.Drawing.Size(288, 28);
            this.mnInhoadon.Text = "Hóa đơn";
            this.mnInhoadon.Click += new System.EventHandler(this.mnInhoadon_Click);
            // 
            // mnDatphong1
            // 
            this.mnDatphong1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThuephong});
            this.mnDatphong1.Enabled = false;
            this.mnDatphong1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnDatphong1.Name = "mnDatphong1";
            this.mnDatphong1.Size = new System.Drawing.Size(111, 28);
            this.mnDatphong1.Text = "Đặt phòng";
            // 
            // mnThuephong
            // 
            this.mnThuephong.Enabled = false;
            this.mnThuephong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnThuephong.Name = "mnThuephong";
            this.mnThuephong.Size = new System.Drawing.Size(234, 28);
            this.mnThuephong.Text = "Phiếu đặt phòng";
            this.mnThuephong.Click += new System.EventHandler(this.mnThuephong_Click);
            // 
            // mnQuanly
            // 
            this.mnQuanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPhong,
            this.mnNhanvien,
            this.mnNguoidung});
            this.mnQuanly.Enabled = false;
            this.mnQuanly.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnQuanly.Name = "mnQuanly";
            this.mnQuanly.Size = new System.Drawing.Size(89, 28);
            this.mnQuanly.Text = "Quản lý";
            // 
            // mnPhong
            // 
            this.mnPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mndanhsachloaiphong,
            this.mnTinhtrang});
            this.mnPhong.Enabled = false;
            this.mnPhong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnPhong.Name = "mnPhong";
            this.mnPhong.Size = new System.Drawing.Size(224, 28);
            this.mnPhong.Text = "Phòng";
            this.mnPhong.Click += new System.EventHandler(this.mnPhong_Click);
            // 
            // mndanhsachloaiphong
            // 
            this.mndanhsachloaiphong.Enabled = false;
            this.mndanhsachloaiphong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mndanhsachloaiphong.Name = "mndanhsachloaiphong";
            this.mndanhsachloaiphong.RightToLeftAutoMirrorImage = true;
            this.mndanhsachloaiphong.Size = new System.Drawing.Size(278, 28);
            this.mndanhsachloaiphong.Text = "Danh sách loại phòng";
            this.mndanhsachloaiphong.Click += new System.EventHandler(this.danhSáchLoạiPhòngToolStripMenuItem_Click);
            // 
            // mnTinhtrang
            // 
            this.mnTinhtrang.Enabled = false;
            this.mnTinhtrang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnTinhtrang.Name = "mnTinhtrang";
            this.mnTinhtrang.Size = new System.Drawing.Size(278, 28);
            this.mnTinhtrang.Text = "Tình Trạng Phòng";
            this.mnTinhtrang.Click += new System.EventHandler(this.tìnhTrạngPhòngToolStripMenuItem_Click);
            // 
            // mnNhanvien
            // 
            this.mnNhanvien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnChucvu});
            this.mnNhanvien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnNhanvien.Name = "mnNhanvien";
            this.mnNhanvien.Size = new System.Drawing.Size(224, 28);
            this.mnNhanvien.Text = "Nhân viên";
            this.mnNhanvien.Click += new System.EventHandler(this.mnNhanvien_Click);
            // 
            // mnChucvu
            // 
            this.mnChucvu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnChucvu.Name = "mnChucvu";
            this.mnChucvu.Size = new System.Drawing.Size(224, 28);
            this.mnChucvu.Text = "Chức vụ";
            this.mnChucvu.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // mnNguoidung
            // 
            this.mnNguoidung.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnNguoidung.Name = "mnNguoidung";
            this.mnNguoidung.Size = new System.Drawing.Size(224, 28);
            this.mnNguoidung.Text = "Người dùng";
            this.mnNguoidung.Click += new System.EventHandler(this.mnNguoidung_Click);
            // 
            // mnBaocao
            // 
            this.mnBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuTheoThángToolStripMenuItem});
            this.mnBaocao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mnBaocao.Name = "mnBaocao";
            this.mnBaocao.Size = new System.Drawing.Size(93, 28);
            this.mnBaocao.Text = "Báo cáo";
            this.mnBaocao.Click += new System.EventHandler(this.mnBaocao_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "home1.png");
            this.imageList1.Images.SetKeyName(2, "home2.png");
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUser.Location = new System.Drawing.Point(16, 43);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(69, 20);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Hi user!";
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbllogo.Location = new System.Drawing.Point(234, 43);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(410, 42);
            this.lbllogo.TabIndex = 7;
            this.lbllogo.Text = "QUẢN LÝ KHÁCH SẠN";
            this.lbllogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // doanhThuTheoThángToolStripMenuItem
            // 
            this.doanhThuTheoThángToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.doanhThuTheoThángToolStripMenuItem.Name = "doanhThuTheoThángToolStripMenuItem";
            this.doanhThuTheoThángToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.doanhThuTheoThángToolStripMenuItem.Text = "Doanh thu theo tháng";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.lbllogo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý khách sạn";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnHethong;
        private System.Windows.Forms.ToolStripMenuItem mnDangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnDangxuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnKhachhang1;
        private System.Windows.Forms.ToolStripMenuItem mnKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnInhoadon;
        private System.Windows.Forms.ToolStripMenuItem mnDatphong1;
        private System.Windows.Forms.ToolStripMenuItem mnThuephong;
        private System.Windows.Forms.ToolStripMenuItem mnQuanly;
        private System.Windows.Forms.ToolStripMenuItem mnPhong;
        private System.Windows.Forms.ToolStripMenuItem mnNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnNguoidung;
        private System.Windows.Forms.ToolStripMenuItem mnBaocao;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem mnChucvu;
        private System.Windows.Forms.ToolStripMenuItem mndanhsachloaiphong;
        private System.Windows.Forms.ToolStripMenuItem mnTinhtrang;
        private System.Windows.Forms.ToolStripMenuItem doanhThuTheoThángToolStripMenuItem;
    }
}

