using MainApplication.Database;
using MainApplication.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.MyFunctions
{
	public static class MyFictionFunctions
	{
		public static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Divides two numbers
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero");
            }
            return a / b;
        }

        // Calculates the distance between two points
        public static double Distance(double[] point1, double[] point2)
        {
            return Math.Sqrt(Math.Pow(point2[0] - point1[0], 2) + Math.Pow(point2[1] - point1[1], 2));
        }

        // Solves a quadratic equation, returns the roots
        public static (double? root1, double? root2) SolveQuadratic(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                return (null, null); // No real roots
            }
            else if (discriminant == 0)
            {
                return (-b / (2 * a), null); // One root
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return (root1, root2); // Two roots
            }
        }

    // Calculates the sum of a geometric series
        public static double GeometricSum(double a, double r, int n)
        {
            if (r == 1)
            {
                return a * n; // Simplified case
            }
            return a * (1 - Math.Pow(r, n)) / (1 - r);
        }
	}
}
