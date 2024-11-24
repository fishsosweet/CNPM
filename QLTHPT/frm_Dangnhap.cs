using QLTHPT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTHPT
{
    public partial class frm_Dangnhap : Form
    {
        public frm_Dangnhap()
        {
            InitializeComponent();
        }
        public string loaitk;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable dt=new DataTable();
            dt = NguoiDung.DangNhap(TaiKhoan.Text, MatKhau.Text);
            if(dt.Rows.Count>0)
            {
                loaitk = dt.Rows[0][3].ToString();
                this.Hide();
                frm_QL a=new frm_QL();
                a.Show();
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
