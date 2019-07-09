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

        void Culculator(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(FirstElement.Text);
                double secondArgument = Convert.ToDouble(SecondElement.Text);
                ITwoArgumentsCalculator culculator = Factory.CreateCalculator(((Button) sender).Name);
                double result = calculator.Calculater(firstArgument, secondArgument);
                ResultTextBox.Text = result.ToString();
            }
            catch
            {
                firstArgumentTextBox.Text = "";
                secondArgumentTextBox.Text = "";
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
    }
}
