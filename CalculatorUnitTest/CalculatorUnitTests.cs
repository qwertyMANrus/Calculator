using NUnit.Framework;
using CalculatorForm;

namespace CalculatorUnitTest
{
    public class Tests
    {
        Calculator Calc = new Calculator();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Clear()
        {
            Calc.Clear();
            string expected = Calc.ActiveNumber;

            string actual = "0";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_InputAllNumberButtons()
        {
            Calc.Clear();
            Calc.PressNumber(0);
            Calc.PressNumber(1);
            Calc.PressNumber(2);
            Calc.PressNumber(3);
            Calc.PressNumber(4);
            Calc.PressNumber(5);
            Calc.PressNumber(6);
            Calc.PressNumber(7);
            Calc.PressNumber(8);
            Calc.PressNumber(9);
            Calc.PressNumber(0);
            Calc.PressNumber(0);
            Calc.PressNumber(5);
            string expected = Calc.ActiveNumber;

            string actual = "123456789005";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Backspace420()
        {
            Calc.Clear();
            Calc.PressNumber(4);
            Calc.PressNumber(2);
            Calc.PressNumber(0);
            Calc.PressNumber(0);
            Calc.PressNumber(7);
            Calc.Backspace();
            Calc.Backspace();
            string expected = Calc.ActiveNumber;

            string actual = "420";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Backspace0()
        {
            Calc.Clear();
            Calc.PressNumber(0);
            Calc.PressNumber(1);
            Calc.PressNumber(2);
            Calc.Backspace();
            Calc.Backspace();
            Calc.Backspace();
            string expected = Calc.ActiveNumber;

            string actual = "0";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Backspace00()
        {
            Calc.Clear();
            Calc.PressNumber(0);
            Calc.PressNumber(1);
            Calc.PressNumber(2);
            Calc.Backspace();
            Calc.Backspace();
            Calc.Backspace();
            Calc.Backspace();
            Calc.Backspace();
            string expected = Calc.ActiveNumber;

            string actual = "0";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_2Add3_Return5()
        {
            Calc.Clear();
            Calc.PressNumber(2);
            Calc.Add();
            Calc.PressNumber(3);
            Calc.Calculate();
            double expected = Calc.Result;

            double actual = 5;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_429Add642_Return1071()
        {
            Calc.Clear();
            Calc.PressNumber(4);
            Calc.PressNumber(2);
            Calc.PressNumber(9);
            Calc.Add();
            Calc.PressNumber(6);
            Calc.PressNumber(4);
            Calc.PressNumber(2);
            Calc.Calculate();
            double expected = Calc.Result;

            double actual = 1071;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_7Sub3_Return4()
        {
            Calc.Clear();
            Calc.PressNumber(7);
            Calc.Sub();
            Calc.PressNumber(3);
            Calc.Calculate();
            double expected = Calc.Result;

            double actual = 4;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_7Sub7_Return0()
        {
            Calc.Clear();
            Calc.PressNumber(7);
            Calc.Sub();
            Calc.PressNumber(7);
            Calc.Calculate();
            double expected = Calc.Result;

            double actual = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_7Sub11_ReturnMin4()
        {
            Calc.Clear();
            Calc.PressNumber(7);
            Calc.Sub();
            Calc.PressNumber(1);
            Calc.PressNumber(1);
            Calc.Calculate();
            double expected = Calc.Result;

            double actual = -4;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_7Mul8_Return56()
        {
            Calc.Clear();
            Calc.PressNumber(7);
            Calc.Multiplication();
            Calc.PressNumber(8);
            Calc.Calculate();
            double expected = Calc.Result;

            double actual = 56;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_42Div4_Return()
        {
            Calc.Clear();
            Calc.PressNumber(4);
            Calc.PressNumber(2);
            Calc.Division();
            Calc.PressNumber(4);
            Calc.Calculate();
            double expected = Calc.Result;

            double actual = 10.5;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_42Div6_Return()
        {
            Calc.Clear();
            Calc.PressNumber(4);
            Calc.PressNumber(2);
            Calc.Division();
            Calc.PressNumber(8);
            Calc.Calculate();
            double expected = Calc.Result;

            double actual = 5.25;

            Assert.AreEqual(expected, actual);
        }
    }
}