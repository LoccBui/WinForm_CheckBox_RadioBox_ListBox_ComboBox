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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Text = "Bảng cửu chương";
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtStart.Text = txtEnd.Text = txtCuuChuong.Text = "";
            lstHienThi.Items.Clear();     
            txtStart.Focus();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(txtStart.Text) && !string.IsNullOrEmpty(txtEnd.Text) && !string.IsNullOrEmpty(txtCuuChuong.Text))
            {
                for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)
                {
                    int result = int.Parse(txtCuuChuong.Text) * i;
                    string s = int.Parse(txtCuuChuong.Text) + "*" + i + "= " + result;
                    lstHienThi.Items.Add(s);
                }  
            }
            else
            {
                MessageBox.Show("Thiếu dữ kiện");
            }
                     
        }

        private void txtStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }

        private void txtEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && (!(e.KeyChar == (char)8)))
                e.Handled = true;
        }

        private void txtCuuChuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }


    }
}
