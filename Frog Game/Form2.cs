using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int level = 0;
        public Form2()
        {
            InitializeComponent();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && (radioButton1.Checked || radioButton2.Checked))
            {
                Form1 form1 = new Form1(textBox1.Text,level);
                form1.Show();
            }
            else
            {
                button1.Enabled = false;
            }
;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
                button1.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            level = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            level = 2;
        }
    }
}
