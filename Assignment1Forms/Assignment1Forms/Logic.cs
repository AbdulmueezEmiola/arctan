using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Forms
{
    class Logic
    {
        public double calculateValue(double x, int N)
        {
            double sum = Math.PI / 2;
            int n = 1;
            while (n <= N)
            {
                double value = 0;
                double valueNum = Math.Pow(-1, n);
                double valueDen = 2 * n - 1;
                double valueExp = 0;
                valueExp = Math.Pow(x, 2 * n - 1);
                value = (valueNum * valueExp) / valueDen;
                sum += value;
                ++n;
            }
            return sum;
        }
        public int calculateSecondQuestion(double x, double E)
        {
            double sum = Math.PI / 2;
            int n = 1;
            int count = 1;
            double stopValue = Math.Atan(1 / x);
            while (Math.Abs(sum - stopValue) > E)
            {
                double value = 0;
                double valueNum = Math.Pow(-1, n);
                double valueDen = 2 * n - 1;
                double valueExp = 0;
                valueExp = Math.Pow(x, 2 * n - 1);
                value = (valueNum * valueExp) / valueDen;
                sum += value;
                ++n;
                ++count;
            }
            return count;
        }

    }
}
