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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Text = "List Box Danh sách sinh viên";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string s = "";
 
            if( lstName.SelectedIndex >= 0 )
            {
                foreach (string item in lstName.SelectedItems)
                {
                    s = s + item + "\n";
                }
                MessageBox.Show(s);
            }

            else if( lstName.SelectedIndex < 0 )
            {
                s = s + "Chưa có tên được chọn";
                MessageBox.Show(s);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
