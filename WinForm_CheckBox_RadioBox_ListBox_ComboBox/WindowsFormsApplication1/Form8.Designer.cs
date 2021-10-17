namespace WindowsFormsApplication1
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.lblResult = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(206, 1);
            this.lblResult.MinimumSize = new System.Drawing.Size(330, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(330, 30);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Hoàng Sa, Trường Sa là của Việt Nam";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Items.AddRange(new object[] {
            "Vàng",
            "Đỏ",
            "Cam",
            "Hồng"});
            this.cboColor.Location = new System.Drawing.Point(305, 205);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(204, 24);
            this.cboColor.TabIndex = 1;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(209, 343);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(75, 32);
            this.btnChangeColor.TabIndex = 2;
            this.btnChangeColor.Text = "Đổi màu";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(434, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn màu :";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.lblResult);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
    }
}