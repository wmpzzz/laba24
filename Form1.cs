using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text && textBox1.Text != "")
            {
                MessageBox.Show(textBox1.Text + ", вы успешно зарегистрированы", "Information");
            }
            else
            {
                MessageBox.Show("Ошибка заполнения", "Information");
            }

            if(textBox2.Text == "")
            {
                textBox2.BackColor = Color.FromName("red");
            }
            else
            {
                textBox2.BackColor = Color.FromName("Window");
            }

            if (textBox3.Text == "")
            {
                textBox3.BackColor = Color.FromName("red");
            }
            else
            {
                textBox3.BackColor = Color.FromName("Window");
            }

            if (textBox1.Text == "")
            {
                textBox1.BackColor = Color.FromName("red");
            }
            else
            {
                textBox1.BackColor = Color.FromName("Window");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
