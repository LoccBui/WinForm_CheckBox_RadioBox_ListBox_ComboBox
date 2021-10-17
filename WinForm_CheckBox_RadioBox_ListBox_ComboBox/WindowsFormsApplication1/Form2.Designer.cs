namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.chkNetwork = new System.Windows.Forms.CheckBox();
            this.chkImageProcess = new System.Windows.Forms.CheckBox();
            this.chkWeb = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sinh viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập họ tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lớp : ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(129, 97);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(215, 22);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(129, 163);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(215, 22);
            this.txtLop.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Danh sách môn học";
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(37, 237);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(107, 21);
            this.chkCSharp.TabIndex = 6;
            this.chkCSharp.Text = "Lập trình C#";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // chkNetwork
            // 
            this.chkNetwork.AutoSize = true;
            this.chkNetwork.Location = new System.Drawing.Point(37, 264);
            this.chkNetwork.Name = "chkNetwork";
            this.chkNetwork.Size = new System.Drawing.Size(122, 21);
            this.chkNetwork.TabIndex = 7;
            this.chkNetwork.Text = "Mạng máy tính";
            this.chkNetwork.UseVisualStyleBackColor = true;
            // 
            // chkImageProcess
            // 
            this.chkImageProcess.AutoSize = true;
            this.chkImageProcess.Location = new System.Drawing.Point(37, 291);
            this.chkImageProcess.Name = "chkImageProcess";
            this.chkImageProcess.Size = new System.Drawing.Size(85, 21);
            this.chkImageProcess.TabIndex = 8;
            this.chkImageProcess.Text = "Xử lí ảnh";
            this.chkImageProcess.UseVisualStyleBackColor = true;
            // 
            // chkWeb
            // 
            this.chkWeb.AutoSize = true;
            this.chkWeb.Location = new System.Drawing.Point(37, 318);
            this.chkWeb.Name = "chkWeb";
            this.chkWeb.Size = new System.Drawing.Size(115, 21);
            this.chkWeb.TabIndex = 9;
            this.chkWeb.Text = "Lập trình web";
            this.chkWeb.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(34, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(269, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 421);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkWeb);
            this.Controls.Add(this.chkImageProcess);
            this.Controls.Add(this.chkNetwork);
            this.Controls.Add(this.chkCSharp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCSharp;
        private System.Windows.Forms.CheckBox chkNetwork;
        private System.Windows.Forms.CheckBox chkImageProcess;
        private System.Windows.Forms.CheckBox chkWeb;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}