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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Form CheckBox";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Check String empty or not
            //String is not empty
            if ( !string.IsNullOrEmpty(txtHoTen.Text) )
            {
                //Condition of checkBox Status
                if (chkLuaChon.CheckState == CheckState.Checked)
                {
                    MessageBox.Show(txtHoTen.Text + " là sinh viên trường Đại học Lạc Hồng và là sinh viên khoa CNTT");
                }
                else if (chkLuaChon.CheckState == CheckState.Unchecked)
                {
                    MessageBox.Show(txtHoTen.Text + " không là sinh viên trường Đại học Lạc Hồng và không là sinh viên khoa CNTT");
                }
                else if (chkLuaChon.CheckState == CheckState.Indeterminate)
                {
                    MessageBox.Show(txtHoTen.Text + " là sinh viên trường Đại học Lạc Hồng Nhưng Không là sinh viên khoa CNTT");
                }
            }
            // String is empty
            else
            {
                MessageBox.Show("Chưa có họ tên");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHoTen.Focus();
            txtHoTen.Clear();
            chkLuaChon.CheckState = CheckState.Unchecked;
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') 
                e.Handled = true;
        }
    }
}
