namespace Calculater.TwoArguments
{
   
    public class Remainder : ITwoArgumentsCalculator
    {
        /// <summary>
        /// It`s search remainder of dividing 2 numbers.
        /// </summary>
        /// <param name="firstElement"></param>
        /// <param name="secondElement"></param>
        /// <returns></returns>
        public double Calculate(double firstElement, double secondElement)
        {
            double result = firstElement % secondElement;
            return result;
        }
    }

}
