namespace WindowsFormsApplication1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.lstName = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Sinh Viên";
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.ItemHeight = 16;
            this.lstName.Items.AddRange(new object[] {
            "Dương Minh A",
            "Bùi Hữu B",
            "Đỗ Tiến C ",
            "Nguyễn Hoàng Vũ D"});
            this.lstName.Location = new System.Drawing.Point(294, 37);
            this.lstName.MultiColumn = true;
            this.lstName.Name = "lstName";
            this.lstName.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstName.Size = new System.Drawing.Size(214, 100);
            this.lstName.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(294, 145);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 31);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Hiển thị";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(414, 145);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(527, 188);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
    }
}