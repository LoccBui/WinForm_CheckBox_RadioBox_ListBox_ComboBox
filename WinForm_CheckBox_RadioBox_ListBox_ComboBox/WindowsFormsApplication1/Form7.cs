using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.Text = "ComboBox Chọn Màu";
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if(cboColor.Text == "Vàng")
            {
                lblResult.ForeColor = Color.Yellow;
            }
            else if (cboColor.Text == "Cam")
            {
                lblResult.ForeColor = Color.Orange;
            }
            else if (cboColor.Text == "Đỏ")
            {
                lblResult.ForeColor = Color.Red;
            }
            else if (cboColor.Text == "Xanh Lá")
            {
                lblResult.ForeColor = Color.Green;
            }
            else if (cboColor.Text == "")
            {
                MessageBox.Show("Chưa chọn màu");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if ( d == DialogResult.OK )
                    this.Close();                        
        }
    }
}
