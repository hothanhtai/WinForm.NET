
namespace WinForm
{
    partial class frm_NhapMang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mangA = new System.Windows.Forms.TextBox();
            this.txt_tongle = new System.Windows.Forms.TextBox();
            this.txt_tongchan = new System.Windows.Forms.TextBox();
            this.txt_tong = new System.Windows.Forms.TextBox();
            this.btn_tinhtoan = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(67, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(34, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng các số lẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(34, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng các số chẵn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(34, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng các số mảng A";
            // 
            // txt_mangA
            // 
            this.txt_mangA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mangA.Location = new System.Drawing.Point(156, 21);
            this.txt_mangA.Multiline = true;
            this.txt_mangA.Name = "txt_mangA";
            this.txt_mangA.Size = new System.Drawing.Size(355, 45);
            this.txt_mangA.TabIndex = 4;
            // 
            // txt_tongle
            // 
            this.txt_tongle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tongle.Location = new System.Drawing.Point(214, 154);
            this.txt_tongle.Multiline = true;
            this.txt_tongle.Name = "txt_tongle";
            this.txt_tongle.Size = new System.Drawing.Size(97, 47);
            this.txt_tongle.TabIndex = 5;
            // 
            // txt_tongchan
            // 
            this.txt_tongchan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tongchan.Location = new System.Drawing.Point(214, 231);
            this.txt_tongchan.Multiline = true;
            this.txt_tongchan.Name = "txt_tongchan";
            this.txt_tongchan.Size = new System.Drawing.Size(97, 45);
            this.txt_tongchan.TabIndex = 6;
            // 
            // txt_tong
            // 
            this.txt_tong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tong.Location = new System.Drawing.Point(214, 305);
            this.txt_tong.Multiline = true;
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(97, 46);
            this.txt_tong.TabIndex = 7;
            this.txt_tong.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btn_tinhtoan
            // 
            this.btn_tinhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_tinhtoan.Location = new System.Drawing.Point(48, 400);
            this.btn_tinhtoan.Name = "btn_tinhtoan";
            this.btn_tinhtoan.Size = new System.Drawing.Size(87, 38);
            this.btn_tinhtoan.TabIndex = 8;
            this.btn_tinhtoan.Text = "Tính toán";
            this.btn_tinhtoan.UseVisualStyleBackColor = true;
            this.btn_tinhtoan.Click += new System.EventHandler(this.btn_tinhtoan_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_lammoi.Location = new System.Drawing.Point(214, 400);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(83, 38);
            this.btn_lammoi.TabIndex = 9;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Red;
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoat.Location = new System.Drawing.Point(374, 400);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 38);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_NhapMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_tinhtoan);
            this.Controls.Add(this.txt_tong);
            this.Controls.Add(this.txt_tongchan);
            this.Controls.Add(this.txt_tongle);
            this.Controls.Add(this.txt_mangA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_NhapMang";
            this.Text = "frm_NhapMang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mangA;
        private System.Windows.Forms.TextBox txt_tongle;
        private System.Windows.Forms.TextBox txt_tongchan;
        private System.Windows.Forms.TextBox txt_tong;
        private System.Windows.Forms.Button btn_tinhtoan;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_thoat;
    }
}