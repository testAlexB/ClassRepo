using System.Collections.Generic;

namespace ConsoleApp3
{
    public class Calculation
    {
        private string formula_;
        private double result_;
        private List<double> args_ = new List<double>();

        public Calculation(string formula, double result, List<double> args)
        {
            formula_ = formula;
            result_ = result;
            args_ = args;
        }

        public string ConvertToString()
        {
            "%1 = %2 * %3"; /// s = v * t
            "%1 = %2 + %3*%4 + (%5 * %6 *%6 / 2)" /// x = x0 + vot + (a * t * t / 2)
            return $"{formula_}, "
        }
    }
}
