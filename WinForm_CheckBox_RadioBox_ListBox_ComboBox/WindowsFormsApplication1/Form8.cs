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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if(cboColor.Text == "Vàng")
            {
                lblResult.BackColor = Color.Yellow;
                lblResult.ForeColor = Color.Yellow;
            }
            else if (cboColor.Text == "Đỏ")
            {
                lblResult.BackColor = Color.Red;
                lblResult.ForeColor = Color.Red;
            }
            else if (cboColor.Text == "Cam")
            {
                lblResult.BackColor = Color.Orange;
                lblResult.ForeColor = Color.Orange;
            }
            else if (cboColor.Text == "Hồng")
            {
                lblResult.BackColor = Color.Pink;
                lblResult.ForeColor = Color.Pink;
            }
            else if ( cboColor.Text == "")
            {
                MessageBox.Show("Chưa chọn màu");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(d == DialogResult.OK)
                    this.Close();
        }
    }
}
