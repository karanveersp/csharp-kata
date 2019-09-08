using System;

namespace Kata
{
    public class RiemannSum
    {
        private static double _calculate(Func<double, double> f, double startingPoint, double deltaX, double n)
        {
            double sum = 0;
            double x = startingPoint;  // only thing that changes from left/right Riemann sum

            // Sigma i=1 to i=n
            for (int i = 1; i <= n; i++) {
                sum += f(x) * deltaX;
                x += deltaX;  // next point
            }
            return Math.Round(sum, 4);
        }


        /**
            <summary>
                Calculates left sum
            </summary>
        */
        public static double Left(Func<double, double> f, double a, double b, double n=100000)
        {
            double deltaX = (b-a)/n;            
            double startingPoint = a;
            return _calculate(f, startingPoint, deltaX, n);
        }


        /**
            <summary>
                Calculates right sum
            </summary>
        */
        public static double Right(Func<double, double> f, double a, double b, double n = 100000)
        {
            double deltaX = (b-a)/n;            
            double startingPoint = a + deltaX;
            return _calculate(f, startingPoint, deltaX, n);
        }
        
        /**
            <summary>
                Calculates left sum and right sum returing the results as a tuple
            </summary>
         */
        public static (double leftSum, double rightSum) Both(Func<double, double> f, double a, double b, double n=100000)
        {
            double deltaX = (b-a)/n;            
            double leftStart = a;
            double rightStart = a + deltaX;
            double leftSum = _calculate(f, leftStart, deltaX, n);   
            double rightSum = _calculate(f, rightStart, deltaX, n);
            return (leftSum: leftSum, rightSum: rightSum);
        }

        public static double AverageValue(Func<double, double> f, double a, double b, double n=1000000)
        {
            double deltaX = (b-a)/n;
            double leftStart = a;
            double sum = _calculate(f, leftStart, deltaX, n);
            return (1/(b-a)) * sum;
        }

        public static (double ave, double c) AverageValueWithC(Func<double, double> f, double a, double b, double n=1000000)
        {
            double ave = AverageValue(f, a, b, n);
            double deltaX = (b-a)/n;
            double leftStart = a;

            double point  = leftStart;
            while (Math.Round(f(point), 4) != ave)
            {
                point += deltaX;
            }
            return (ave, Math.Round(point, 4));
        }

        public static void usage()
        {
            var result = RiemannSum.Both((double x) => Math.Sin(x), 0, 1, 4);
            Console.WriteLine("Left sum: {0}, Right sum: {1}", result.leftSum, result.rightSum);

            var ave = RiemannSum.AverageValue((double x) => Math.Sin(x), 0, Math.PI);
            Console.WriteLine("Ave {0}", ave);

            ave = RiemannSum.AverageValue((double x) => 6-3*x, 0, 2);
            Console.WriteLine("Ave {0}", ave);

            var point = RiemannSum.AverageValueWithC((double x) => (0.5*x) + 3, 0, 4);
            Console.WriteLine("Ave and C is {0}", point);

        }

    }
}