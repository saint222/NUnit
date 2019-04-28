using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtils
{

    public interface IDivide
    {
        int Divide(int x, int y);
    }
    
    public class Calculator : IDivide
    {
        public int Sum(int x, int y)
        {
            return x + y; ;
        }

        public int Subtract (int x, int y)
        {
            return x - y; 
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }

        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }

    }
}
