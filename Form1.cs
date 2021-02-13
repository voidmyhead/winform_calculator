using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformcalculator
{
    public partial class Form1 : Form
    {
        private double lvalue;
        private bool opFlag = false;
        private char btn_operation = '\0';

        public Form1()
        {
            InitializeComponent();

            Text = "Winform Calculator";
            //버튼
            //대상.속성 = 값;
           
        }

        private void 일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)//숫자버튼
        {
            if (label2.Text == "0" || opFlag == true)
            {
                label2.Text = ((Button)sender).Text;
                opFlag = false;
            }
            else {
                label2.Text = label2.Text + ((Button)sender).Text;
            }
            
           
        }

        private void button36_Click(object sender, EventArgs e)//연산버튼
        {
            lvalue = Double.Parse(label2.Text);
            

            if (((Button)sender).Text == "+")
            {
                btn_operation = '+';
                
                opFlag = true;
            }
            else if (((Button)sender).Text == "-")
            {
                btn_operation = '-';
                label3.Text = label2.Text + btn_operation;
                opFlag = true;

            }
            else if (((Button)sender).Text == "*")
            {
                btn_operation = '*';
                label3.Text = label2.Text + btn_operation;
                opFlag = true;

            }
            else if (((Button)sender).Text == "/")
            {
                btn_operation = '/';
                label3.Text = label2.Text + btn_operation;
                opFlag = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)//CE버튼
        {
            label2.Text = "0";
            label3.Text = "";
        }

        private void button34_Click(object sender, EventArgs e)//결과버튼
        {
            Double rvalue = Double.Parse(label2.Text);
            switch (btn_operation)
            {
                case '+':
                    label2.Text = (lvalue + rvalue).ToString();
                    break;
                case '-':
                    label2.Text = (lvalue - rvalue).ToString(); 
                    break;
                case '/':
                    label2.Text = (lvalue / rvalue).ToString();
                    break;
                case '*':
                    label2.Text = (lvalue * rvalue).ToString();
                    break;
            }
            label3.Text = "";
        }
        private void button35_Click(object sender, EventArgs e)//소수점 버튼
        {
            if (label2.Text.Contains("."))
                return;
            else
                label2.Text = label2.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)//한글자 지우기 버튼
        {
            label2.Text = label2.Text.Remove(label2.Text.Length - 1);
        }
    }
}