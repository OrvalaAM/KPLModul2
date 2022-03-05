using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302204105
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(textBox1.Text == "") { 
                if(button.Text != "0")
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void plus(object sender, EventArgs e)
        {
            if(a != 0)
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            textBox1.Text = "";
            
        }

        private void samadengan(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            double hasil = a + b;
            textBox1.Text = hasil.ToString();
        }

        
    }
}
