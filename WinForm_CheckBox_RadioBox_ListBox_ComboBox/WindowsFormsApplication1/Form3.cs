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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            //check string is empty or not
            // not empty
            if ( !string.IsNullOrEmpty(txtFirstNum.Text) && !string.IsNullOrEmpty(txtSecondNum.Text) )
            {
                    // check radio btn checked or not
                    if (rdoAdd.Checked == true)
                    {
                        int result = int.Parse(txtFirstNum.Text) + int.Parse(txtSecondNum.Text);
                        txtResult.Text = result.ToString();
                    }

                    else if (rdoSub.Checked == true)
                    {
                        int result = int.Parse(txtFirstNum.Text) - int.Parse(txtSecondNum.Text);
                        txtResult.Text = result.ToString();
                    }

                    else if (rdoDivide.Checked == true)
                    {
                        //Phep chia mau so phai khac 0
                        if (int.Parse(txtSecondNum.Text) != 0)
                        {
                            int result = int.Parse(txtFirstNum.Text) / int.Parse(txtSecondNum.Text);
                            txtResult.Text = result.ToString();
                        }
                        else
                        {
                            txtResult.Text = "Num 2 phải khác 0";
                        }
                    }

                    else if (rdoMultify.Checked == true)
                    {
                        int result = int.Parse(txtFirstNum.Text) * int.Parse(txtSecondNum.Text);
                        txtResult.Text = result.ToString();
                    }

                    else
                    {
                        MessageBox.Show("Chọn phép tính");
                    }
            }
            // string is empty
            else
            {
                // string is empty -> see which is empty
                if (string.IsNullOrEmpty(txtFirstNum.Text) && string.IsNullOrEmpty(txtSecondNum.Text)  )
                {
                    MessageBox.Show("Chưa nhập hai số");
                }
                else if ( string.IsNullOrEmpty(txtFirstNum.Text) )
                {
                    MessageBox.Show("Chưa nhập số đầu tiên");
                }
                else if (string.IsNullOrEmpty(txtSecondNum.Text))
                {
                    MessageBox.Show("Chưa nhập số thứ hai");
                }
            }

            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Radio Button Calculator";
        }

        private void txtFirstNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !(e.KeyChar >= '0' && e.KeyChar <= '9' )  ) 
                e.Handled = true;
        }

        private void txtSecondNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') ) 
                e.Handled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFirstNum.Text = txtSecondNum.Text = txtResult.Text = "";
            rdoDivide.Checked = rdoMultify.Checked =  rdoAdd.Checked = rdoSub.Checked = false;
            txtFirstNum.Focus();
        }

    }
}
