using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzacı_Sipariş_Otomasyonu
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + textBox2.Text);
            listBox2.Items.Add(textBox3.Text);
            listBox3.Items.Add(textBox4.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(label9.Text + label10.Text + label11.Text + label12.Text);
        }
            
           

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = checkBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = checkBox3.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = checkBox4.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Text = "";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label12.Text = "";
        }
    }
}
