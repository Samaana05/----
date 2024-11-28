using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form6 : Form
    {
        private DateTime startTime;
        private Timer timer;
        private TimeSpan timeRemaining;
        
        public Form6()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form frm7 = new Form7();
            frm7.Show();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            balance += 10;
            label13.Text = balance.ToString();
        }
        private int balance = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            balance -= 10;
            label13.Text= balance.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startTime = DateTime.Now.AddDays(18).AddHours(8).AddMinutes(17).AddSeconds(0);
            timer = new Timer();
            timer.Interval = 1000;
        }
    }

   

}
