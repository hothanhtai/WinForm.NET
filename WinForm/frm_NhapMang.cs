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
    public partial class frm_NhapMang : Form
    {

        public frm_NhapMang()
        {
            InitializeComponent();
        }
        int tongchan = 0;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có thật sự muốn thoát?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dialog == DialogResult.OK)
            {
            Application.Exit();
            }
        }

        private void btn_tinhtoan_Click(object sender, EventArgs e)
        {
            string [] j = txt_mangA.Text.Split(' ');
            foreach (var item in j)
            {
                if (int.Parse(item)%2 == 0)
                {
                    tongchan = int.Parse(item);
                }

            }
            txt_tongchan.Text = tongchan.ToString();

        }
    }
}
