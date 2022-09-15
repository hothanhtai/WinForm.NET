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
    public partial class frm_TimThu : Form
    {
        public frm_TimThu()
        {
            InitializeComponent();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            switch (txt_thu.Text)
            {
                case "2":
                    lb_timthu.Text = "Hôm nay la thu 2";
                    break;
                case "3":
                    lb_timthu.Text = "Hôm nay la thu 3";
                    break;
                case "4":
                    lb_timthu.Text = "Hôm nay la thu 4";
                    break;
                case "5":
                    lb_timthu.Text = "Hôm nay la thu 5";
                    break;
                case "6":
                    lb_timthu.Text = "Hôm nay la thu 6";
                    break;
                case "7":
                    lb_timthu.Text = "Hôm nay la thu 7";
                    break;
                case "8":
                    lb_timthu.Text = "Hôm nay la chu nhat";
                    break;
                default:
                    lb_timthu.Text = "Nhập ngu quá mời nhập lại đê!";
                    break;
            }
        }
    }
}
