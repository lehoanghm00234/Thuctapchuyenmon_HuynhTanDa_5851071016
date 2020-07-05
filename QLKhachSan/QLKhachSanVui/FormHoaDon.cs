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
    public partial class FormThuePhong : Form
    {
        public FormMain frmMain;
        public FormThuePhong()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void FormThuePhong_Load(object sender, EventArgs e)
        {
            cmbMaPT.DataSource = dt.phieuthuephongs.ToList();
            cmbMaPT.DisplayMember = "matp";
            cmbMaPT.ValueMember = "matp";
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

            }
           
           

            
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            txtTongTien.Text = (d * Convert.ToInt32(txtSoLuong.Text)).ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
    //Hello word
}
