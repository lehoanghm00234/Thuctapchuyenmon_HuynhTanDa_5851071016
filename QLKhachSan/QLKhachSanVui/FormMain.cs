using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKhachSanVui
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
         
            

        }
        public void ThongKe()
        {
            
        }
        private void MainEnabled()
        {
            
        }
        private void MainNoEnabled()
        {
            
        }
        private void MainEnQuanLy()
        {
            
        }
        private void MainEnNhanVien()
        {
            
       
        }
       public void NV()
        {
            mnNhanvien.Enabled = false;
            mnKhachhang1.Enabled = true;
            mnKhachhang.Enabled = true;
            mnInhoadon.Enabled = true;
            mnDatphong1.Enabled = true;
            mnThuephong.Enabled = true;
            mnQuanly.Enabled = true;
            mnPhong.Enabled = true;
            mndanhsachloaiphong.Enabled = true;
            mnTinhtrang.Enabled = true;
            mnChucvu.Enabled = false;
            mnNguoidung.Enabled = false;
        }
        public void admin()
            {
            mnNhanvien.Enabled = true;
            mnKhachhang.Enabled = true;
            mnKhachhang1.Enabled = true;
            mnInhoadon.Enabled = true;
            mnDatphong1.Enabled = true;
            mnThuephong.Enabled = true;
            mnQuanly.Enabled = true;
            mnPhong.Enabled = true;
            mndanhsachloaiphong.Enabled = true;
            mnTinhtrang.Enabled = true;
            mnChucvu.Enabled = true;
            mnNguoidung.Enabled = true;

        }
        private void mnDangnhap_Click(object sender, EventArgs e)
        {
           
            FormLogin formLogin = new FormLogin();
            
            formLogin.ShowDialog();
            //MessageBox.Show(formLogin.i.ToString());
            
            if (formLogin.i==1)
            {
                //MessageBox.Show(formLogin.i.ToString());
                MessageBox.Show("Quản lí đăng nhập thành công");
                admin()
              

;               


            }
            else if(formLogin.i==2)
            {
                MessageBox.Show("Nhân viên đăng nhập thành công");
                NV();
               

            }
        }
        private void mnDangxuat_Click(object sender, EventArgs e)
        {
            mnNhanvien.Enabled = false;
            mnKhachhang1.Enabled = false;
            mnKhachhang1.Enabled = false;
            mnInhoadon.Enabled = false;
            mnDatphong1.Enabled = false;
            mnThuephong.Enabled = false;
            mnQuanly.Enabled = false;
            mnPhong.Enabled = false;
            mndanhsachloaiphong.Enabled = false;
            mnTinhtrang.Enabled = false;
            mnChucvu.Enabled = false;
            mnNguoidung.Enabled = false;


        }
        private void mnDoimatkhau_Click(object sender, EventArgs e)
        {
           
        }
        private void mnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnKhachhang_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.ShowDialog();
        }
        private void mnInhoadon_Click(object sender, EventArgs e)
        {
            FormHoaDon formHoaDon = new FormHoaDon();
            formHoaDon.ShowDialog();
        }
        private void mnDatphong_Click(object sender, EventArgs e)
        {
        }
        private void mnThuephong_Click(object sender, EventArgs e)
        {
            FormDatPhong formDatPhong = new FormDatPhong();
            formDatPhong.ShowDialog();
        }
        private void mnPhong_Click(object sender, EventArgs e)
        {
            FormPhong formPhong = new FormPhong();
            formPhong.ShowDialog();
        }
        private void mnVattu_Click(object sender, EventArgs e)
        {

        }
        private void mnDichvu_Click(object sender, EventArgs e)
        {

        }
        private void mnNhanvien_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            formNhanVien.ShowDialog();
        }
        private void mnNguoidung_Click(object sender, EventArgs e)
        {
            FormNguoiDung formNguoiDung = new FormNguoiDung();
            formNguoiDung.ShowDialog();
        }
        private void mnThongtin_Click(object sender, EventArgs e)
        {
            
        }

        private void mnBaocao_Click(object sender, EventArgs e)
        {
           
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1ChucVu form1ChucVu = new Form1ChucVu();
            form1ChucVu.ShowDialog();
        }

        private void danhSáchLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhsachloaiphong dsloaiphong = new danhsachloaiphong();
            dsloaiphong.ShowDialog();
        }

        private void tìnhTrạngPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tinhtrang tinhtrang = new Tinhtrang();
            tinhtrang.ShowDialog();
        }

        private void doanhThuTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeHoaDon formThongKeHoaDon = new FormThongKeHoaDon();
            formThongKeHoaDon.ShowDialog();
        }
    }
}
