namespace Calculater.OneArgument
{
    public class Negatively :IOneArgument
    {
        /// <summary>
        /// this method reverse argument
        /// </summary>
        /// <param name="firstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double firstElement)
        {
            double result = 0-firstElement;
            return result;
        }
    }
}
