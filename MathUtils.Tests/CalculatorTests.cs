using System;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using NUnit.Framework;
using Assert = NUnit.Framework.Assert; //чтобы не было конфликтов с NUnit

// из NuGEt в проект с тестом: NUnit + NUnit3TestAdapter

namespace MathUtils.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private IDivide divide = null;

        [Test]
        [TestCase(5, 5, ExpectedResult = 1)]
        [TestCase(10, 2, ExpectedResult = 5)]
        public int Test_Divide_Method_Within_Int_Range(int x, int y) // (без Assert) нужен тип возвр.знач. и аргументы
        {
            divide = new Calculator();
            return divide.Divide(x, y);
        }

        [Test]
        [ExpectedException(typeof(DivideByZeroException))] // атрибут от VS
        public void Test_Divide_By_Zero_Method()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(5, 0));
        }

        [Test]
        public void Test_Sum_Method_Within_Int_Range()
        {
            var calc = new Calculator();
            var result = calc.Sum(2, 1);
            Assert.AreEqual(3, result); // ожидаемый и реальный
            
            Assert.AreNotEqual(0, calc.Sum(1,1)); // ошибочный и реальный (укороченный вариант)
        }

        [Test]
        public void Test_Subtract_Method_Within_Int_Range()
        {
            var calc = new Calculator();
            var result = calc.Subtract(10, 5);
            Assert.AreEqual(5, result);

            var resultSec = calc.Subtract(5, 1);
            Assert.AreNotEqual(5, resultSec);
        }

        [Test]
        public void Test_Multiply_Method_Within_Int_Range()
        {
            var calc = new Calculator();
            var result = calc.Multiply(7,7);
            Assert.AreEqual(49, result);

            Assert.AreNotEqual(50, calc.Multiply(7, 7));
            
        }

        [Test]
        public void Test_Sqrt_Method_Within_Int_Range()
        {
            var calc = new Calculator();
            var result = calc.Sqrt(49);
            Assert.AreEqual(7, result);

            var resultSec = calc.Sqrt(64);
            Assert.AreNotEqual(10, resultSec);
        }

        [Test]
        public void Test_Pow_Method_Within_Int_Range()
        {
            var calc = new Calculator();
            var result = calc.Pow(2,2);
            Assert.AreEqual(4, result);

            var resultSec = calc.Pow(3, 2);
            //Assert.AreNotEqual(10, result);
            Assert.That(10 != resultSec); // аналогично, но с that
            //Assert.That(result, Is.Null); проверка на NULL
            //Assert.That(result, Is.True); проверка на TRUE/FALSE
        }
    }
}
