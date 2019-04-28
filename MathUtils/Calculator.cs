using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtils
{
    public interface ILogger
    {
        void Log(string text);
    }

    public class Logger : ILogger
    {
        public void Log(string text)
        {
            //log to a file
        }
    }
    
    public interface IDivide
    {
        int Divide(int x, int y);
    }
    
    public class Calculator : IDivide
    {
        private readonly ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }
        public int Sum(int x, int y)
        {
            var result = x + y;
            _logger.Log($"{x} + {y} = {result}");
            return result;            
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
