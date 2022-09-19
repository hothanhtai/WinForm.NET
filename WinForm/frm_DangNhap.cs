using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        int count = 0;
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
                string a = "admin";
                if (txt_tendangnhap.Text.ToLower() == a && txt_matkhau.Text == "123456")
                {
                    frm_QLSinhVien sv = new frm_QLSinhVien();
                    sv.Show();
                    count = 0;
                }
                else
                {
                    MessageBox.Show($"Bạn nhập sai tên đăng nhập hoặc mật khẩu {count+1} lần ");
                    count++;
                    if (count == 3)
                    {
                        Application.Exit();
                    }
            }
               
         
            
            
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_tendangnhap.Text = "";
            txt_matkhau.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn thật sự muốn thoát hay không?", "cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                Application.Exit(); 

            }
        }
    }
}
