using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class CalculateDataHM
    {
        public static double Add(double x, double y)
        {
            double output = x + y;
            return output;
        }

        public static double Subtract(double x, double y)
        {
            double output = x - y;
            return output;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            double output = (x / y);
            return output;
        }
    }
}
