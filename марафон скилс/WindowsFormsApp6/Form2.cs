using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Runner" && textBox2.Text == "123") 
            {
                Form frm3 = new Form3();
                frm3.Show();
            }
            else if (textBox1.Text == "Administrator" && textBox2.Text == "1234") 
            {
                Form frm4 = new Form4();
                frm4.Show();
            }
            else if (textBox1.Text == "Coordinator" && textBox2.Text == "12345")
            {
                Form frm5 = new Form5();
                frm5.Show();
            }
            
        }
    }
}
