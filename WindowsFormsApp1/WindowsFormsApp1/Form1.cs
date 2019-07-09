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


        private void Form1_Load(object sender, EventArgs e)
        {
            


        }


        private void Addition_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(FirstElement.Text);
            double secondArgument = Convert.ToDouble(SecondElement.Text);
            double result = firstArgument + secondArgument;
            Conclusion.Text = result.ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(FirstElement.Text);
            double secondArgument = Convert.ToDouble(SecondElement.Text);
            double result = firstArgument / secondArgument;
            Conclusion.Text = result.ToString();
        }

        private void Substraction_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(FirstElement.Text);
            double secondArgument = Convert.ToDouble(SecondElement.Text);
            double result = firstArgument - secondArgument;
            Conclusion.Text = result.ToString();
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(FirstElement.Text);
            double secondArgument = Convert.ToDouble(SecondElement.Text);
            double result = firstArgument * secondArgument;
            Conclusion.Text = result.ToString();
        }
    }
}
