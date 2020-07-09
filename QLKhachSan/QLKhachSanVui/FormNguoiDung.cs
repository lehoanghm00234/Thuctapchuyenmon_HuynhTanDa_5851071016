using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKhachSanVui
{
    public partial class FormNguoiDung : Form
    {
        public FormMain frmMain;
        public FormNguoiDung()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void FormNguoiDung_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt.nguoidungs.ToList();
            cbChucvu.DataSource = dt.chucvus.ToList();
            cbChucvu.DisplayMember = "tenchucvu";
            cbChucvu.ValueMember = "tenchucvu";
        }
        private void LoadDataUser()
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.themNguoidung(txtTaikhoan.Text, txtMatkhau.Text, cbChucvu.SelectedValue.ToString());
            FormNguoiDung_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            dt.suaNguoidung(txtTaikhoan.Text, txtMatkhau.Text, cbChucvu.SelectedValue.ToString());
            dataGridView1.DataSource = new DataClasses1DataContext().nguoidungs.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtTaikhoan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMatkhau.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbChucvu.SelectedValue = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dt.xoaNguoidung(txtTaikhoan.Text);
            FormNguoiDung_Load(sender, e);
        }
    }
}
