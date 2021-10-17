namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNetwork = new System.Windows.Forms.RadioButton();
            this.rdoHTTT = new System.Windows.Forms.RadioButton();
            this.rdoKTMT = new System.Windows.Forms.RadioButton();
            this.rdoCNPM = new System.Windows.Forms.RadioButton();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khoa :";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(106, 74);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(158, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(105, 121);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(158, 22);
            this.txtKhoa.TabIndex = 5;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(16, 28);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(58, 21);
            this.rdoNam.TabIndex = 7;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(110, 28);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(47, 21);
            this.rdoNu.TabIndex = 8;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNetwork
            // 
            this.rdoNetwork.AutoSize = true;
            this.rdoNetwork.Location = new System.Drawing.Point(6, 121);
            this.rdoNetwork.Name = "rdoNetwork";
            this.rdoNetwork.Size = new System.Drawing.Size(224, 21);
            this.rdoNetwork.TabIndex = 10;
            this.rdoNetwork.TabStop = true;
            this.rdoNetwork.Text = "Mạng máy tính và truyền thông";
            this.rdoNetwork.UseVisualStyleBackColor = true;
            // 
            // rdoHTTT
            // 
            this.rdoHTTT.AutoSize = true;
            this.rdoHTTT.Location = new System.Drawing.Point(7, 163);
            this.rdoHTTT.Name = "rdoHTTT";
            this.rdoHTTT.Size = new System.Drawing.Size(146, 21);
            this.rdoHTTT.TabIndex = 11;
            this.rdoHTTT.TabStop = true;
            this.rdoHTTT.Text = "Hệ thống thông tin";
            this.rdoHTTT.UseVisualStyleBackColor = true;
            // 
            // rdoKTMT
            // 
            this.rdoKTMT.AutoSize = true;
            this.rdoKTMT.Location = new System.Drawing.Point(6, 79);
            this.rdoKTMT.Name = "rdoKTMT";
            this.rdoKTMT.Size = new System.Drawing.Size(138, 21);
            this.rdoKTMT.TabIndex = 12;
            this.rdoKTMT.TabStop = true;
            this.rdoKTMT.Text = "Kỹ thuật máy tính";
            this.rdoKTMT.UseVisualStyleBackColor = true;
            // 
            // rdoCNPM
            // 
            this.rdoCNPM.AutoSize = true;
            this.rdoCNPM.Location = new System.Drawing.Point(6, 36);
            this.rdoCNPM.Name = "rdoCNPM";
            this.rdoCNPM.Size = new System.Drawing.Size(168, 21);
            this.rdoCNPM.TabIndex = 13;
            this.rdoCNPM.TabStop = true;
            this.rdoCNPM.Text = "Công nghệ phần mềm";
            this.rdoCNPM.UseVisualStyleBackColor = true;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(6, 52);
            this.txtKetqua.MinimumSize = new System.Drawing.Size(250, 100);
            this.txtKetqua.Multiline = true;
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.ReadOnly = true;
            this.txtKetqua.Size = new System.Drawing.Size(283, 377);
            this.txtKetqua.TabIndex = 15;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(26, 466);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 31);
            this.btnDangKy.TabIndex = 16;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(248, 466);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Location = new System.Drawing.Point(27, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 55);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoCNPM);
            this.groupBox2.Controls.Add(this.rdoNetwork);
            this.groupBox2.Controls.Add(this.rdoHTTT);
            this.groupBox2.Controls.Add(this.rdoKTMT);
            this.groupBox2.Location = new System.Drawing.Point(26, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 197);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngành học";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKetqua);
            this.groupBox3.Location = new System.Drawing.Point(327, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 438);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nội dung sinh viên đăng ký";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(137, 466);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 31);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 520);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNetwork;
        private System.Windows.Forms.RadioButton rdoHTTT;
        private System.Windows.Forms.RadioButton rdoKTMT;
        private System.Windows.Forms.RadioButton rdoCNPM;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh;
    }
}