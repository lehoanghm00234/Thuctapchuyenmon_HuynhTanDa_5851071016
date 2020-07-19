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
    public partial class FormLogin : Form
    {
        //public FormMain frmMain;
        //String fullname="";

        public FormLogin()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private bool passw()
        {
            
            return true;
        }
        private bool tendn()
        {
            
            return true;
        }
        private bool kiemtra()
        {
            
            return false;
        }
        public int i;
        public bool check()
        {
            nguoidung nguoidung = dt.nguoidungs.Where(s => s.taikhoan == txttenDangnhap.Text).Where
               (s => s.matkhau == txtmatKhau.Text).FirstOrDefault();
            if (nguoidung.chucvu == "Admin")
            {
                i = 1;

                return true;

            }
           
           else if (nguoidung.chucvu =="NV")
            {
                i = 2;
                // this.Hide();
                return true;
            }
            return false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(check()==true)
            {
                this.Hide();
            }
           

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
