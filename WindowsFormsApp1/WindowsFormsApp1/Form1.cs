using System;
using System.Windows.Forms;
using Calculater.OneArgument;
using Calculater.TwoArguments;

namespace Calculater
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
                double firstArgument = Convert.ToDouble(firstElement.Text);
                double secondArgument = Convert.ToDouble(secondElement.Text);
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button) sender).Name);
                double result = calculator.Calculate(firstArgument, secondArgument);
                Conclusion.Text = result.ToString();
            }
            catch (FormatException exception)
            {
                firstElement.Text = "";
                secondElement.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        void OneCalculator(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(firstElement.Text);
                IOneArgument oneCalculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                double result = oneCalculator.OneCalculate(firstArgument);
                Conclusion.Text = result.ToString();
            }
            catch(FormatException exception)
            {

                firstElement.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
