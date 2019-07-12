namespace Calculater.TwoArguments
{
    public class Multiplication : ITwoArgumentsCalculator
    {
        /// <summary>
        /// this method multiply two arguments
        /// </summary>
        /// <param name="firstElement"></param>
        /// <param name="secondElement"></param>
        /// <returns></returns>
        public double Calculate(double firstElement, double secondElement)
        {
            double result = firstElement * secondElement;
            return result;
        }
    }
}
