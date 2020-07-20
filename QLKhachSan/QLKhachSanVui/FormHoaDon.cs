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
            DialogResult thoat = MessageBox.Show("B?n có mu?n thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Dua du lieu vao excel
            worksheet.Cells[1, 7] = "HÓA ĐƠN ";
            //worksheet.Cells[2, 7] = "tổng tiền " + txtTongTien.Text;


            worksheet.Cells[3, 4] = "STT";
            worksheet.Cells[3, 5] = "Mã Hóa Đơn";
            worksheet.Cells[3, 6] = "Mã phiếu thuê";
            worksheet.Cells[3, 7] = "Ngày thuê phòng";
            worksheet.Cells[3, 8] = "Giá tiền";
            worksheet.Cells[3, 9] = "Số ngày thuê";
            worksheet.Cells[3, 10] = "Ngày trả phòng";
            worksheet.Cells[3, 11] = "Tổng tiền";
            worksheet.Cells[3, 12] = "Mã khách hàng";
            worksheet.Cells[3, 13] = "Mã nhân viên";
            
            

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    worksheet.Cells[i + 4, 4] = i + 1;
                    worksheet.Cells[i + 4, j + 5] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
        public void timkiem(string s)
        {
            dataGridView1.DataSource = dt.seachingHD(s);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timkiem(textBox1.Text.Trim());
        }
    }

    //Hello word
}
