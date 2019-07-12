namespace Calculater.TwoArguments
{
    
   public class Average : ITwoArgumentsCalculator
    {
        /// <summary>
        /// It`s search medium math
        /// </summary>
        /// <param name="firstElement">First number</param>
        /// <param name="secondElement">Second number</param>
        /// <returns></returns>
        public double Calculate(double firstElement, double secondElement)
        {
            double result = (firstElement + secondElement) / 2; 
            return result;
        }
    }
}
