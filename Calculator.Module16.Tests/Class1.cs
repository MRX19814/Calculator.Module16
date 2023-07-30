using NUnit.Framework;
using Practices;
using System;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            // Инициализация экземпляра калькулятора перед каждым тестом
            calculator = new Calculator();
        }

        [Test]
        public void TestAddition()
        {
            // Проверка метода Additional()
            int result = calculator.Additional(5, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void TestSubtraction()
        {
            // Проверка метода Subtraction()
            int result = calculator.Subtraction(10, 4);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void TestMultiplication()
        {
            // Проверка метода Miltiplication()
            int result = calculator.Miltiplication(2, 5);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void TestDivision()
        {
            // Проверка метода Division()
            int result = calculator.Division(15, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void TestDivision_DivideByZero()
        {
            // Проверка деления на ноль (ожидается исключение)
            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }
    }
}
