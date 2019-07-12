using System;





namespace Calcpr
{
    public class Root : IoneArgument
    {
        /// <summary>
        /// this method find square root of argument
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            if(FirstElement<0) throw new Exception("отрицательное значение под корнем ");
            return Math.Sqrt(FirstElement);
        }
    }
}
