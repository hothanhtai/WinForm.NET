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

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string a = "admin";

            
            
                int count = 0;
                if (txt_tendangnhap.Text.ToLower() == a && txt_matkhau.Text == "123456")
                {
                    frm_QLSinhVien sv = new frm_QLSinhVien();
                    sv.Show();
                }
                else
                {
                    count++;
                }
                if (count == 3)
                {

                }
         
            
            
        }
    }
}
