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
    public partial class frm_ListBox : Form
    {
            Dictionary<string, string[]> HoTen = new Dictionary<string, string[]>();
        public frm_ListBox()
        {
            InitializeComponent();
            HoTen.Add("Nguyễn", new string[] { "Nguyễn Văn A", "Nguyễn Văn B", "Nguyễn Văn C", "Nguyễn Văn D", "Nguyễn Văn E" });
            HoTen.Add("Trần", new string[] { "Trần Văn G","Trần Văn H" });
            HoTen.Add("Ngô", new string[] { "Ngô Văn K","Ngô Văn L" });

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Lib_B.Items.Count; i++)
            {
                Lib_A.Items.Add(Lib_B.Items[i]);
            }
            Lib_B.Items.Clear();
        }

        private void Lib_A_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            for (int i = Lib_A.SelectedItems.Count - 1; i >=0; i--)
            {
                Lib_B.Items.Add(Lib_A.SelectedItems[i]);
                Lib_A.Items.Remove(Lib_A.SelectedItems[i]);
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            for (int i = Lib_B.SelectedItems.Count - 1; i >= 0; i--)
            {
                Lib_A.Items.Add(Lib_B.SelectedItems[i]);
                Lib_B.Items.Remove(Lib_B.SelectedItems[i]);
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < Lib_A.Items.Count; i++)
            {
                Lib_B.Items.Add(Lib_A.Items[i]);
            } 
            Lib_A.Items.Clear(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lib_A.Items.Clear();
            foreach (var item in HoTen[cb_ho.SelectedItem.ToString()])
            {
                Lib_A.Items.Add(item);
            }
        }

        private void frm_ListBox_Load(object sender, EventArgs e)
        {
            foreach (var ho in HoTen.Keys)
            {
                cb_ho.Items.Add(ho);
            }
        }
    }
}
