using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1DArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numbers = new int[7] { 22,55,99,44,20,30,70 };
        private void button2_Click(object sender, EventArgs e)
        {
           

           foreach(int a in numbers)
            {
                listBox1.Items.Add(a);

            }

          
           
        }

        private void btn_Maximum_Click(object sender, EventArgs e)
        {
            int iMax = numbers[0];
            for(int i=0;i<numbers.Length;i++)
            {
                if(iMax<numbers[i])
                {

                    iMax = numbers[i];
                }

            }
            tb_Maximum.Text = "Maximum Element Is:"+iMax.ToString();
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            int iSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                iSum = iSum + numbers[i];
            }
            tb_Sum.Text ="Sum Of All Elements Is:"+iSum.ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            listBox1.Text = "  ";
            tb_Maximum.Text = " ";
            tb_Sum.Text = " ";
        }

        private void tb_Maximum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
