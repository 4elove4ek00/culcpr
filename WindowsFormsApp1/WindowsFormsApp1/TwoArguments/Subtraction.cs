namespace Calculater.TwoArguments
{
    
    public class Subtraction : ITwoArgumentsCalculator
    { /// <summary>
    /// It`s search subtraction 2 numbers.
    /// </summary>
    /// <param name="firstElement">It`s first number</param>
    /// <param name="secondElement">It`s second number</param>
    /// <returns></returns>
        public double Calculate(double firstElement, double secondElement)
        {
            double result = firstElement - secondElement;
            return result;
        }
    }
}
