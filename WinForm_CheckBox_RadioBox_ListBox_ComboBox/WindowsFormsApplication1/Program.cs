﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Run(new Form2());
            Application.Run(new Form3());
            Application.Run(new Form4());
            Application.Run(new Form5());
            Application.Run(new Form6());
            Application.Run(new Form7());
            Application.Run(new Form8());
        }
    }
}
