
namespace WinForm
{
    partial class frm_GiaiPTBac2
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
            this.txt_hesoA = new System.Windows.Forms.TextBox();
            this.txt_hesoB = new System.Windows.Forms.TextBox();
            this.txt_hesoC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(72, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ SỐ A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(72, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "HỆ SỐ B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(72, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "HỆ SỐ C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(72, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "KẾT QUẢ";
            // 
            // txt_hesoA
            // 
            this.txt_hesoA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hesoA.Location = new System.Drawing.Point(231, 65);
            this.txt_hesoA.Name = "txt_hesoA";
            this.txt_hesoA.Size = new System.Drawing.Size(202, 22);
            this.txt_hesoA.TabIndex = 4;
            // 
            // txt_hesoB
            // 
            this.txt_hesoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hesoB.Location = new System.Drawing.Point(231, 142);
            this.txt_hesoB.Name = "txt_hesoB";
            this.txt_hesoB.Size = new System.Drawing.Size(202, 22);
            this.txt_hesoB.TabIndex = 5;
            // 
            // txt_hesoC
            // 
            this.txt_hesoC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hesoC.Location = new System.Drawing.Point(231, 224);
            this.txt_hesoC.Name = "txt_hesoC";
            this.txt_hesoC.Size = new System.Drawing.Size(202, 22);
            this.txt_hesoC.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(188, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Giải";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(385, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.AutoSize = true;
            this.lb_ketqua.Location = new System.Drawing.Point(231, 312);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(0, 17);
            this.lb_ketqua.TabIndex = 9;
            // 
            // frm_GiaiPTBac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_ketqua);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_hesoC);
            this.Controls.Add(this.txt_hesoB);
            this.Controls.Add(this.txt_hesoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_GiaiPTBac2";
            this.Text = "frm_GiaiPTBac2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hesoA;
        private System.Windows.Forms.TextBox txt_hesoB;
        private System.Windows.Forms.TextBox txt_hesoC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_ketqua;
    }
}