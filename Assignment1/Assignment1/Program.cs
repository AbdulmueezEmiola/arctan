using System;

namespace Assignment1
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value to find");
            double valueToFind = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the accuracy to which the value will be found");
            int nChecker = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(valueToFind.ToString());
            //Console.WriteLine(nChecker);
            Console.WriteLine("The value computed from the series is {0}", calculateValue(valueToFind, nChecker));
            Console.WriteLine("The value computed from the compiler is {0}", Math.Atan(1/valueToFind));
            double error = calculateValue(valueToFind, nChecker) - Math.Atan(1/valueToFind);
            Console.WriteLine("The absolute Error is {0}", error);
            Console.WriteLine(calculateLastValue(valueToFind, nChecker)>error);
            Console.WriteLine("Now answering the second part...");
            Console.WriteLine("Enter the value to find");
            double secondValueToFind = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of E");
            double secondChecker = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The answer of the second part is {0}",calculateSecondQuestion(secondValueToFind, secondChecker));
        }
        static double calculateLastValue(double x, int N)
        {
            double sum = x;
            double value = 0;
            value = calculateValue(x, N) / calculateValue(x, N - 1);
            return value;
        }
        static double calculateValue(double x, int N)
        {
            double sum = Math.PI / 2;
            int n = 1;
            while (n <= N)
            {
                double value = 0;
                double valueNum = Math.Pow(-1,n);
                double valueDen = 2 * n - 1;
                double valueExp = 0;
                valueExp = Math.Pow(x, 2 * n - 1);                
                value = (valueNum * valueExp) / valueDen ;
                sum += value;
                ++n;
            }
            return sum;
        }
        static int calculateSecondQuestion(double x, double E)
        {
            double sum = Math.PI/2;
            int n = 1;
            int count = 1;
            double stopValue = Math.Atan(1/x);
            while (Math.Abs(sum - stopValue)>E)
            {
                double value = 0;
                double valueNum = Math.Pow(-1, n );
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
