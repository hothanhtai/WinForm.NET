
namespace WinForm
{
    partial class frm_TimThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TimThu));
            this.lb_thu = new System.Windows.Forms.Label();
            this.lb_timthu = new System.Windows.Forms.Label();
            this.txt_thu = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_thu
            // 
            this.lb_thu.AutoSize = true;
            this.lb_thu.BackColor = System.Drawing.Color.Cyan;
            this.lb_thu.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thu.Location = new System.Drawing.Point(275, 159);
            this.lb_thu.Name = "lb_thu";
            this.lb_thu.Size = new System.Drawing.Size(91, 22);
            this.lb_thu.TabIndex = 0;
            this.lb_thu.Text = "Nhập Thứ";
            // 
            // lb_timthu
            // 
            this.lb_timthu.AutoSize = true;
            this.lb_timthu.Location = new System.Drawing.Point(275, 340);
            this.lb_timthu.Name = "lb_timthu";
            this.lb_timthu.Size = new System.Drawing.Size(0, 17);
            this.lb_timthu.TabIndex = 1;
            // 
            // txt_thu
            // 
            this.txt_thu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_thu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_thu.Location = new System.Drawing.Point(372, 159);
            this.txt_thu.Name = "txt_thu";
            this.txt_thu.Size = new System.Drawing.Size(160, 22);
            this.txt_thu.TabIndex = 2;
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_tim.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_tim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_tim.Location = new System.Drawing.Point(365, 192);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 33);
            this.btn_tim.TabIndex = 3;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // frm_TimThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_thu);
            this.Controls.Add(this.lb_timthu);
            this.Controls.Add(this.lb_thu);
            this.Name = "frm_TimThu";
            this.Text = "frm_TimThu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thu;
        private System.Windows.Forms.Label lb_timthu;
        private System.Windows.Forms.TextBox txt_thu;
        private System.Windows.Forms.Button btn_tim;
    }
}