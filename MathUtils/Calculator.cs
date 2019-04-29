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
            var result = x - y;
            _logger.Log($"{x} - {y} = {result}");
            return result; 
        }

        public int Multiply(int x, int y)
        {
            var result = x * y;
            _logger.Log($"{x} * {y} = {result}");
            return result;
        }

        public int Divide(int x, int y)
        {
            var result = x / y;
            _logger.Log($"{x} / {y} = {result}");
            return result;
        }

        public double Sqrt(double x)
        {
            var result = Math.Sqrt(x);
            _logger.Log($"The square root of {x} = {result}");
            return result;
        }

        public double Pow(double x, double y)
        {
            var result = Math.Pow(x, y);
            _logger.Log($"{x} raised to the power of {y} = {result}");
            return result;
        }

    }
}
