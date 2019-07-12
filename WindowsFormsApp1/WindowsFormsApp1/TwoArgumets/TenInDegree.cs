using System;





namespace Calcpr.Class
{
   
    public class TenInDegree : IoneArgument
    {
        /// <summary>
        /// It`s search 10 in pow [First number]
        /// </summary>
        /// <param name="FirstElement">First number</param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Pow(10, FirstElement);
            return result;
        }
    }
}
