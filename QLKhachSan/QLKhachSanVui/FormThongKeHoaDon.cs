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
    public partial class FormThongKeHoaDon : Form
    {
        DataClasses1DataContext dt = new DataClasses1DataContext();

        public FormThongKeHoaDon()
        {
            InitializeComponent();
        }

        private void FormThongKeHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt.hoadons.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            thongke(textBox1.Text);

            int doanhthu = 0;
            for(int i=0;i<dataGridView1.RowCount;i++)
            {
                doanhthu += Convert.ToInt32(dataGridView1.Rows[i].Cells["tongtien"].Value);
            }
            txtTongTien.Text = doanhthu.ToString();
            
        }
        public void thongke(string s)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt.seaching(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Dua du lieu vao excel
            worksheet.Cells[1, 7] = "Báo Cáo Doanh Thu ";
            worksheet.Cells[2, 7] = "tổng tiền " + txtTongTien.Text;

            worksheet.Cells[2, 4] = "Tháng:" +textBox1.Text;
            worksheet.Cells[3, 4] = "STT";
            worksheet.Cells[3, 5] = "Mã Hóa Đơn";
            worksheet.Cells[3, 6] = "Mã phiếu thuê";
            worksheet.Cells[3, 7] = "Giá";
            worksheet.Cells[3, 8] = "Số lượng ngày thuê";
            worksheet.Cells[3, 9] = "Tổng tiền";
            worksheet.Cells[3, 10] = "Ngày thanh toán";
            worksheet.Cells[3, 11] = "Mã khách hàng";

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    worksheet.Cells[i + 4, 4] = i + 1;
                    worksheet.Cells[i + 4, j + 5] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
