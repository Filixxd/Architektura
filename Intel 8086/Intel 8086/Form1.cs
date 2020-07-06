using System;
using System.Windows.Forms;

namespace Intel_8086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            string curItem2 = listBox2.SelectedItem.ToString();
            string function = listBox3.SelectedItem.ToString();
            if (function == "MOVE" && curItem == "AX" && curItem2 == "AX")
            {
                textBox1.Text = textBox1.Text;
            }
            else if(function == "MOVE" && curItem == "AX" && curItem2 == "BX")
            {
                textBox2.Text=textBox1.Text;
            }
            else if (function == "MOVE" && curItem == "AX" && curItem2 == "CX")
            {
                textBox3.Text = textBox1.Text;
            }
            else if (function == "MOVE" && curItem == "AX" && curItem2 == "DX")
            {
                textBox4.Text = textBox1.Text;
            }
            else if (function == "MOVE" && curItem == "BX" && curItem2 == "AX")
            {
                textBox1.Text = textBox2.Text;
            }
            else if (function == "MOVE" && curItem == "BX" && curItem2 == "BX")
            {
                textBox2.Text = textBox2.Text;
            }
            else if (function == "MOVE" && curItem == "BX" && curItem2 == "CX")
            {
                textBox3.Text = textBox2.Text;
            }
            else if (function == "MOVE" && curItem == "BX" && curItem2 == "DX")
            {
                textBox4.Text = textBox2.Text;
            }
            else if (function == "MOVE" && curItem == "BX" && curItem2 == "BX")
            {
                textBox2.Text = textBox2.Text;
            }
            else if (function == "MOVE" && curItem == "CX" && curItem2 == "AX")
            {
                textBox1.Text = textBox3.Text;
            }
            else if (function == "MOVE" && curItem == "CX" && curItem2 == "BX")
            {
                textBox2.Text = textBox3.Text;
            }
            else if (function == "MOVE" && curItem == "CX" && curItem2 == "CX")
            {
                textBox3.Text = textBox3.Text;
            }
            else if (function == "MOVE" && curItem == "CX" && curItem2 == "DX")
            {
                textBox4.Text = textBox3.Text;
            }
            else if (function == "MOVE" && curItem == "DX" && curItem2 == "AX")
            {
                textBox1.Text = textBox4.Text;
            }
            else if (function == "MOVE" && curItem == "DX" && curItem2 == "BX")
            {
                textBox2.Text = textBox4.Text;
            }
            else if (function == "MOVE" && curItem == "DX" && curItem2 == "CX")
            {
                textBox3.Text = textBox4.Text;
            }
            else if (function == "MOVE" && curItem == "DX" && curItem2 == "DX")
            {
                textBox4.Text = textBox4.Text;
            }
        }
    }
}
