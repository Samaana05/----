using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wiwiwi
{
    public partial class Form3 : Form
    {
        private string t1;
        private string t2;
        public Form3(string textBox1Value, string comboBox1Value)
        {
            InitializeComponent();
            this.t1 = textBox1Value;
            this.CenterToScreen();
            this.t2 = comboBox1Value;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label4.Text = t1;
            label6.Text = t2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        public void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
