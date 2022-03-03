using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int a;
        public char islem;
        public bool et;

        private void BtnC_Click(object sender, EventArgs e)
        {
            LblResult.Text = "0";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            islem = '/';
            et = true;
            a = Convert.ToInt32(LblResult.Text);

        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            islem = '*';
            et = true;
            a = Convert.ToInt32(LblResult.Text);
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            islem = '-';
            et = true;        
            a = Convert.ToInt32(LblResult.Text);
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            islem = '+';
            et = true;                            
            a = Convert.ToInt32(LblResult.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (et) { LblResult.Text = ""; et = false; }
            if(LblResult.Text == "0") { LblResult.Text = ""; }
            LblResult.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (et) { LblResult.Text = ""; et = false; }
            if (LblResult.Text == "0") { LblResult.Text = ""; }
            LblResult.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (et) { LblResult.Text = ""; et = false; }
            if (LblResult.Text == "0") { LblResult.Text = ""; }
            LblResult.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (et) { LblResult.Text = ""; et = false; }
            if (LblResult.Text == "0") { LblResult.Text = ""; }
            LblResult.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (et) { LblResult.Text = ""; et = false; }
            if (LblResult.Text == "0") { LblResult.Text = ""; }
            LblResult.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (et) { LblResult.Text = ""; et = false; }
            if (LblResult.Text == "0") { LblResult.Text = ""; }
            LblResult.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (et) { LblResult.Text = ""; et = false; }
            if (LblResult.Text == "0") { LblResult.Text = ""; }
            LblResult.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (et) { LblResult.Text = ""; et = false; }
            if (LblResult.Text == "0") { LblResult.Text = ""; }
            LblResult.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (et) { LblResult.Text = ""; et = false; }
            if (LblResult.Text == "0") { LblResult.Text = ""; }
            LblResult.Text += "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (et) { LblResult.Text = ""; et = false; }
            if (LblResult.Text == "0") { LblResult.Text = ""; }
            LblResult.Text += "0";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(LblResult.Text);
            int sonuc;
            switch (islem)
            {
                case '+':
                    sonuc = a + b;
                    break;
                case '-':
                    sonuc = a - b;
                    break;
                case '/':
                    sonuc = a / b;
                    break;
                case '*':
                    sonuc = a * b;
                    break;
                default:
                    sonuc = 0;
                    break;
                
            }
            LblResult.Text = Convert.ToString(sonuc);
        }
    }
}
