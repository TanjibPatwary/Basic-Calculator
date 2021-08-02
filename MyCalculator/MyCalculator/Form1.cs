using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form

    {

        Double result_val = 0;
        String result_op = "";
        bool operationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((Result.Text == "0") || operationPerformed)
                Result.Text = "";
            operationPerformed = false;

            Button button= (Button)sender;

            if (button.Text==".")
            {
                if(!Result.Text.Contains("."))
                    Result.Text = Result.Text + button.Text;

            }
            else
            Result.Text = Result.Text + button.Text;
            

        }

        private void op_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            result_op = button.Text;

            result_val = Double.Parse(Result.Text);
            label1.Text = result_val + " " + result_op;
            operationPerformed = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            result_val = 0;


        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (result_op)
            {
               
                case "+":
                    Result.Text = (result_val + Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (result_val - Double.Parse(Result.Text)).ToString();
                    break;
                 case "×":
                    Result.Text = (result_val * Double.Parse(Result.Text)).ToString();
                    break;
                 case "÷":
                    Result.Text = (result_val / Double.Parse(Result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
