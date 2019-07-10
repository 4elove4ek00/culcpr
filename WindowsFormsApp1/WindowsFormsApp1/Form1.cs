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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        void Calculator(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(FirstElement.Text);
                double secondArgument = Convert.ToDouble(SecondElement.Text);
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button) sender).Name);
                double result = calculator.Calculate(firstArgument, secondArgument);
                Conclusion.Text = result.ToString();
            }
            catch
            {
                FirstElement.Text = "";
                SecondElement.Text = "";
            }
        }

        void OneCalculator(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(FirstElement.Text);
                IoneArgument Onecalculator = OneArgumentsFactory.CreateCalculator(((Button)sender).Name);
                double result = Onecalculator.OneCalculate(firstArgument);
                Conclusion.Text = result.ToString();
            }
            catch
            {
                FirstElement.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Addition_Click(object sender, EventArgs e)
        {
        }

        private void Division_Click(object sender, EventArgs e)
        {
        }

        private void Substraction_Click(object sender, EventArgs e)
        {
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
        }

        private void SecondElement_TextChanged(object sender, EventArgs e)
        {

        }

        private void Conclusion_Click(object sender, EventArgs e)
        {

        }
    }
}
