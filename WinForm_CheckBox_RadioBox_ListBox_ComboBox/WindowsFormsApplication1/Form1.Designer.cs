namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.chkLuaChon = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lựa chọn: ";
            // 
            // chkLuaChon
            // 
            this.chkLuaChon.AutoSize = true;
            this.chkLuaChon.Location = new System.Drawing.Point(136, 198);
            this.chkLuaChon.Name = "chkLuaChon";
            this.chkLuaChon.Size = new System.Drawing.Size(264, 21);
            this.chkLuaChon.TabIndex = 2;
            this.chkLuaChon.Text = "Sinh Viên Trường DHLH, Khoa CNTT";
            this.chkLuaChon.ThreeState = true;
            this.chkLuaChon.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gửi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Chọn lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(136, 26);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(307, 22);
            this.txtHoTen.TabIndex = 6;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "1) Check : Sinh Viên CNTT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "2) Uncheck : Không là sinh viên CNTT và ĐHLH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "3) Indeteminate : Là sinh viên ĐHLH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 321);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkLuaChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkLuaChon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

