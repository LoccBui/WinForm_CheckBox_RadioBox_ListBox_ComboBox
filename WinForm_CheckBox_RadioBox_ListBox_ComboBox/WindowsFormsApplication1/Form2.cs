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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Thông tin sinh viên ";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check String empty or not
            // String is not empty
            if (!string.IsNullOrEmpty(txtHoTen.Text) && !string.IsNullOrEmpty(txtLop.Text))
            {
                string s = ("Họ tên : " + txtHoTen.Text + ", Lớp : " + txtLop.Text + " \nDanh sách môn học :\n");
                //Check check box status
                if (chkCSharp.Checked == true)
                {
                    s = s + ("Lập trình C# \n");
                }
                if (chkNetwork.Checked == true)
                {
                    s = s + ("Mạng máy tính \n");
                }
                if (chkImageProcess.Checked == true)
                {
                    s = s + ("Xử lí ảnh \n");
                }
                if (chkWeb.Checked == true)
                {
                    s = s + ("Lập trình web \n");
                }
                MessageBox.Show(s);
            }

            // String is empty
            else
            {
                if (string.IsNullOrEmpty(txtHoTen.Text) && string.IsNullOrEmpty(txtLop.Text))
                {
                     MessageBox.Show("Chưa có giá trị họ tên và lớp");
                }
                else if (string.IsNullOrEmpty(txtLop.Text))
                {
                     MessageBox.Show("Chưa có giá trị lớp");
                }
                else if (string.IsNullOrEmpty(txtHoTen.Text)) 
                {
                    MessageBox.Show("Chưa có giá trị họ tên ");
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = true;
        }
    }
}
