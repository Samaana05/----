using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wiwiwi
{
    public partial class Form2 : Form
    {
        public int n;
       
        public Form2()
        {
            InitializeComponent();
            n = 50;
            textBox1.Text = "$50";
            textBox1.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            n += 10;
            update();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                n -= 10;
                update();
            }
        }
        public void update()
        {
            textBox1.Text = "$" + n.ToString();
            label12.Text = "$" + n.ToString();
            textBox1.ForeColor = Color.Black;
        }

        public void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            string t2 = comboBox1.Text;
            Form3 form3 = new Form3(t1, t2);
            form3.Show();
            form3.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
