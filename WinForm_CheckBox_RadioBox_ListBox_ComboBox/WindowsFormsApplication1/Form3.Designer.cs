namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoSub = new System.Windows.Forms.RadioButton();
            this.rdoMultify = new System.Windows.Forms.RadioButton();
            this.rdoDivide = new System.Windows.Forms.RadioButton();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Thứ Nhất : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Thứ Hai :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết Quả là :";
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(111, 26);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(148, 22);
            this.txtFirstNum.TabIndex = 3;
            this.txtFirstNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstNum_KeyPress);
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Location = new System.Drawing.Point(111, 89);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(148, 22);
            this.txtSecondNum.TabIndex = 4;
            this.txtSecondNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondNum_KeyPress);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(111, 149);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(148, 22);
            this.txtResult.TabIndex = 5;
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Location = new System.Drawing.Point(282, 27);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(99, 21);
            this.rdoAdd.TabIndex = 6;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "Phép Cộng";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoSub
            // 
            this.rdoSub.AutoSize = true;
            this.rdoSub.Location = new System.Drawing.Point(282, 69);
            this.rdoSub.Name = "rdoSub";
            this.rdoSub.Size = new System.Drawing.Size(88, 21);
            this.rdoSub.TabIndex = 7;
            this.rdoSub.TabStop = true;
            this.rdoSub.Text = "Phép Trừ";
            this.rdoSub.UseVisualStyleBackColor = true;
            // 
            // rdoMultify
            // 
            this.rdoMultify.AutoSize = true;
            this.rdoMultify.Location = new System.Drawing.Point(282, 116);
            this.rdoMultify.Name = "rdoMultify";
            this.rdoMultify.Size = new System.Drawing.Size(100, 21);
            this.rdoMultify.TabIndex = 8;
            this.rdoMultify.TabStop = true;
            this.rdoMultify.Text = "Phép Nhân";
            this.rdoMultify.UseVisualStyleBackColor = true;
            // 
            // rdoDivide
            // 
            this.rdoDivide.AutoSize = true;
            this.rdoDivide.Location = new System.Drawing.Point(282, 154);
            this.rdoDivide.Name = "rdoDivide";
            this.rdoDivide.Size = new System.Drawing.Size(94, 21);
            this.rdoDivide.TabIndex = 9;
            this.rdoDivide.TabStop = true;
            this.rdoDivide.Text = "Phép Chia";
            this.rdoDivide.UseVisualStyleBackColor = true;
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(15, 219);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(162, 34);
            this.btnCalculator.TabIndex = 10;
            this.btnCalculator.Text = "Tính";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(214, 219);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(162, 34);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 282);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.rdoDivide);
            this.Controls.Add(this.rdoMultify);
            this.Controls.Add(this.rdoSub);
            this.Controls.Add(this.rdoAdd);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.TextBox txtSecondNum;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoSub;
        private System.Windows.Forms.RadioButton rdoMultify;
        private System.Windows.Forms.RadioButton rdoDivide;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnRefresh;
    }
}