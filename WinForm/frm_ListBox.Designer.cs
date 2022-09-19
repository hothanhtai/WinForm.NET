
namespace WinForm
{
    partial class frm_ListBox
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
            this.Lib_A = new System.Windows.Forms.ListBox();
            this.Lib_B = new System.Windows.Forms.ListBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.cb_ho = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lib_A
            // 
            this.Lib_A.FormattingEnabled = true;
            this.Lib_A.ItemHeight = 16;
            this.Lib_A.Items.AddRange(new object[] {
            "Nguyễn Văn A",
            "Nguyễn Văn B",
            "Nguyễn Văn C",
            "Nguyễn Văn D",
            "Nguyễn Văn E",
            "Trần Văn G",
            "Trần Văn H",
            "Ngô Văn K",
            "Ngô Văn L"});
            this.Lib_A.Location = new System.Drawing.Point(218, 110);
            this.Lib_A.Name = "Lib_A";
            this.Lib_A.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Lib_A.Size = new System.Drawing.Size(120, 164);
            this.Lib_A.TabIndex = 0;
            this.Lib_A.SelectedIndexChanged += new System.EventHandler(this.Lib_A_SelectedIndexChanged);
            // 
            // Lib_B
            // 
            this.Lib_B.FormattingEnabled = true;
            this.Lib_B.ItemHeight = 16;
            this.Lib_B.Location = new System.Drawing.Point(500, 110);
            this.Lib_B.Name = "Lib_B";
            this.Lib_B.Size = new System.Drawing.Size(120, 164);
            this.Lib_B.TabIndex = 1;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(377, 110);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 2;
            this.btn_1.Text = ">";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(377, 139);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 23);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = ">>";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(377, 219);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 23);
            this.btn_3.TabIndex = 4;
            this.btn_3.Text = "<";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(377, 248);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 23);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "<<";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cb_ho
            // 
            this.cb_ho.FormattingEnabled = true;
            this.cb_ho.Location = new System.Drawing.Point(218, 36);
            this.cb_ho.Name = "cb_ho";
            this.cb_ho.Size = new System.Drawing.Size(121, 24);
            this.cb_ho.TabIndex = 6;
            this.cb_ho.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên";
            // 
            // frm_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_ho);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.Lib_B);
            this.Controls.Add(this.Lib_A);
            this.Name = "frm_ListBox";
            this.Text = "5";
            this.Load += new System.EventHandler(this.frm_ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lib_A;
        private System.Windows.Forms.ListBox Lib_B;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.ComboBox cb_ho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}