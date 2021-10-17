namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtCuuChuong = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstHienThi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(210, 34);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(208, 22);
            this.txtStart.TabIndex = 0;
            this.txtStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStart_KeyPress);
            // 
            // txtCuuChuong
            // 
            this.txtCuuChuong.Location = new System.Drawing.Point(210, 125);
            this.txtCuuChuong.Name = "txtCuuChuong";
            this.txtCuuChuong.Size = new System.Drawing.Size(208, 22);
            this.txtCuuChuong.TabIndex = 1;
            this.txtCuuChuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuuChuong_KeyPress);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(210, 77);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(208, 22);
            this.txtEnd.TabIndex = 2;
            this.txtEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnd_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cửu chương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết thúc";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(66, 371);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(101, 29);
            this.btnThucHien.TabIndex = 7;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(191, 371);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(101, 29);
            this.btnLamLai.TabIndex = 8;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(317, 371);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 29);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstHienThi
            // 
            this.lstHienThi.FormattingEnabled = true;
            this.lstHienThi.ItemHeight = 16;
            this.lstHienThi.Location = new System.Drawing.Point(67, 170);
            this.lstHienThi.Name = "lstHienThi";
            this.lstHienThi.Size = new System.Drawing.Size(351, 180);
            this.lstHienThi.TabIndex = 10;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 436);
            this.Controls.Add(this.lstHienThi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtCuuChuong);
            this.Controls.Add(this.txtStart);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtCuuChuong;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListBox lstHienThi;
    }
}