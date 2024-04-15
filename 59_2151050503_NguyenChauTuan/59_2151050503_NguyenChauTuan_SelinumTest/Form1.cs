using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _59_2151050503_NguyenChauTuan_SelinumTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 2; i++)
            {
                if(i==1)
                {
                    cmbchucnang.Items.Add("Tim kiem");
                    break;
                }
                cmbchucnang.Items.Add("Dang Ki");

            }
        }
        bool flag = true;
        bool flag2 = true;
        private void cmbchucnang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbchucnang.Text.Equals("Dang Ki") && flag == true)
            {
                flag = false;
                for (int i = 1; i < 2; i++)
                {
                    cmBox1.Items.Add("Testcase" + " "+i);
                }
            }
            if (cmbchucnang.Text.Equals("Tim kiem") && flag2 == true)
            {
                flag2 = false;
                for (int i = 1; i < 3; i++)
                {
                    cmBox1.Items.Add("Testcase" + " " + i);
                }
            }
        }

        private void cmBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }
    }
   
}
