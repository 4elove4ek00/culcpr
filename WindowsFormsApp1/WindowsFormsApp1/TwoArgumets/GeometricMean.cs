using System;
namespace Calcpr.Class
{

    public class GeometricMean : ITwoArgumentsCalculator
    {
        /// <summary>
        /// this method find geometric mean of two arguments
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <param name="SecondElement"></param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            if(FirstElement * SecondElement<0) throw new Exception("отрицательное значение под корнем ");
            return Math.Sqrt(FirstElement * SecondElement);
        }
    }
}
