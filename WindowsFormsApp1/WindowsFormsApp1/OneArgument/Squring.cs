namespace Calculater.OneArgument
{
    public class Squring : IOneArgument
    {
        /// <summary>
        /// this method squaring argument
        /// </summary>
        /// <param name="firstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double firstElement)
        {
            double result = firstElement * firstElement;
            return result;
        }
    }
}
