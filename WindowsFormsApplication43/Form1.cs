using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi; 
             sayi = Convert.ToInt32(textBox1.Text);
            if (sayi < 10)
            {
                sayi++;
            }
            textBox1.Text = sayi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if (sayi > 0)
            {
                sayi--;
            }
            textBox1.Text = sayi.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int toplam, sayi = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                toplam = i * sayi;
                listBox1.Items.Add(i + " x " + sayi + " = " + toplam);
            }
        }
    }
}
