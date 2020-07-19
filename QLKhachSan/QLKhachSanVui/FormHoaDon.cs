using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSanVui
{
    public partial class FormHoaDon : Form
    {
        public FormMain frmMain;
        public FormHoaDon()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void FormThuePhong_Load(object sender, EventArgs e)

        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt.hoadons.ToList();
            cmbMaPT.DataSource = dt.phieuthuephongs.ToList();
            cmbMaPT.DisplayMember = "matp";
            cmbMaPT.ValueMember = "matp";

            cbMaKhachHang.DataSource = dt.khachhangs.ToList();
            cbMaKhachHang.DisplayMember = "makh";
            cbMaKhachHang.ValueMember = "makh";

            cbMaNhanVien.DataSource = dt.nhanviens.ToList();
            cbMaNhanVien.DisplayMember = "manv";
            cbMaNhanVien.ValueMember = "manv";
            
        }
        int d;
        string s;

        private void cmbMaPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            phieuthuephong phieuthuephong = dt.phieuthuephongs.Where(p => p.matp == cmbMaPT.SelectedValue.ToString()).FirstOrDefault();
            if(phieuthuephong!=null)
            {
                txtNgayThuePhong.Text = phieuthuephong.ngaythue.ToString();
                s = phieuthuephong.maphong;
                phong phong = dt.phongs.Where(p => p.maphong == s.ToString()).FirstOrDefault();
                string c = phong.maloai;
                loaiphong loaiphong = dt.loaiphongs.Where(p => p.maloai == c).FirstOrDefault();
                d = Convert.ToInt32(loaiphong.gia);
                labGia.Text = d.ToString();
                

            }
           
           

            
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if(txtSoLuong.Text!="")
            {
                txtTongTien.Text = (d * Convert.ToInt32(txtSoLuong.Text)).ToString();

            }
         

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dt.xoaHoaDon(txtMahoadon.Text);
            FormThuePhong_Load(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dt.suaHoaDon(txtMahoadon.Text, cmbMaPT.SelectedValue.ToString(), txtNgayThuePhong.Text, labGia.Text, txtSoLuong.Text,
                dtpNgaythanhtoan.Text, txtTongTien.Text, cbMaKhachHang.SelectedValue.ToString(), cbMaNhanVien.SelectedValue.ToString());
            dataGridView1.DataSource = new DataClasses1DataContext().hoadons.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            dt.themHoaDon(txtMahoadon.Text, cmbMaPT.SelectedValue.ToString(),txtNgayThuePhong.Text, labGia.Text, txtSoLuong.Text, 
                dtpNgaythanhtoan.Text, txtTongTien.Text, cbMaKhachHang.SelectedValue.ToString(), cbMaNhanVien.SelectedValue.ToString());
            FormThuePhong_Load(sender, e);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtMahoadon.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cmbMaPT.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtNgayThuePhong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            labGia.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtSoLuong.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            dtpNgaythanhtoan.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtTongTien.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            cbMaKhachHang.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            cbMaNhanVien.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    //Hello word
}
