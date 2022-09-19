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
    public partial class frm_GiaiPTBac2 : Form
    {
        public frm_GiaiPTBac2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // kiem tra cac he so
            if (int.Parse(txt_hesoA.Text) == 0)
            {
                if (int.Parse(txt_hesoB.Text) == 0)
                {
                    if (int.Parse(txt_hesoC.Text) == 0)
                    {
                        lb_ketqua.Text = "Phương trình vô số nghiệm";
                    }
                    else
                    {
                        lb_ketqua.Text = "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    int ttt = (-int.Parse(txt_hesoC.Text) / int.Parse(txt_hesoB.Text));
                    lb_ketqua.Text = $"Phuong trinh co mot nghiem: x = {ttt} ";
                }
                return;
            }
            // tinh delta
            float delta = int.Parse(txt_hesoB.Text) * int.Parse(txt_hesoB.Text) - 4 * int.Parse(txt_hesoA.Text) * int.Parse(txt_hesoC.Text);
            float x1;
            float x2;
            // tinh nghiem
            if (delta > 0)
            {
                x1 = (float)((-int.Parse(txt_hesoB.Text) + Math.Sqrt(delta)) / (2 * int.Parse(txt_hesoA.Text)));
                x2 = (float)((-int.Parse(txt_hesoB.Text) - Math.Sqrt(delta)) / (2 * int.Parse(txt_hesoA.Text)));
                lb_ketqua.Text = $"Phuong trinh co 2 nghiem phan biet la: x1 = {x1} va x2 = {x2}";
            }
            else if (delta == 0)
            {
                x1 = (-int.Parse(txt_hesoB.Text) / (2 * int.Parse(txt_hesoA.Text)));

               lb_ketqua.Text = $"Phong trinh co nghiem kep: x1 = x2 = {x1}";
            }
            else
            {
                lb_ketqua.Text = "Phuong trinh vo nghiem";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
            Application.Exit();

            }
        }
    }
}
