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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(textBox1.Text);
            if (x / 100 == x % 100 % 10)
            {
                label2.Text = "Ваше число является полиндромом";
            }
            else
                label2.Text = "Ваше число не является полиндромом";

            textBox1.ReadOnly = true;

            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            label2.Text = "";

            button1.Visible = true;
            button2.Visible = false;

            textBox1.ReadOnly = false;
        }
    }
}
