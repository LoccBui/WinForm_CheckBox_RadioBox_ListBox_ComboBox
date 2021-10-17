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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Thông tin sinh viên";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //string s = "Sinh viên tên : " + txtHoTen.Text + ", Khoa:  " + txtKhoa.Text;
            string s = "";

            //check HoTen and khoa empty or not
            if (string.IsNullOrEmpty(txtHoTen.Text) && string.IsNullOrEmpty(txtKhoa.Text))
            {
                s = "Sinh viên tên : Không có" + ", Khoa:  Không có ";
            }
            else if (string.IsNullOrEmpty(txtHoTen.Text) )
            {
                 s = "Sinh viên tên : Không có" + ", Khoa:  " + txtKhoa.Text;
            }
            else if ( string.IsNullOrEmpty(txtKhoa.Text))
            {
                s = "Sinh viên tên : " + txtHoTen.Text + ", Khoa:  Không có ";
            }
            

            //check radio btn Gioi Tinh
            if (rdoNam.Checked == true)
            {
                s = s + (", Giới tính : Nam ");
            }
            else if (rdoNu.Checked == true)
            {
                s = s + (", Giới tính : Nu ");
            }
            else
            {
                s = s + ", Giới tính :Chưa chọn giới tính ";
            }


            // check radio btn Chuyen Nganh
            if (rdoCNPM.Checked == true)
            {
                s = s + (", Chuyên ngành :  Công nghệ phần mềm ");
            }
            else if (rdoHTTT.Checked == true)
            {
                s = s + (", Chuyên ngành :  Hệ thống thông tin  ");
            }
            else if (rdoKTMT.Checked == true)
            {
                s = s + ("Chuyên ngành :  Kỹ thuật phần mềm  ");
            }
            else if (rdoNetwork.Checked == true)
            {
                s = s + ("Chuyên ngành : Mạng máy tính và truyền thông  ");
            }
            else
            {
                s = s + ("Chưa chọn chuyên ngành");
            }

            txtKetqua.Text = s;
                 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = txtKhoa.Text = "";
            rdoNam.Checked = rdoNu.Checked = false;
            rdoCNPM.Checked = rdoHTTT.Checked = rdoKTMT.Checked = rdoNetwork.Checked = false;
            txtHoTen.Focus();
        }

    }
}
