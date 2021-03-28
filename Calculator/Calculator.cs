using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForm
{
    public class Calculator
    {
        private bool EmptyFirstNumber { get; set; }

        private string history = "";

        public string History
        {
            get
            {
                if (!EmptyFirstNumber)
                {
                    return history;
                }
                return history;
            }
        }

        public string ActiveNumber { get; private set; }

        public string ActiveOperation { get; private set; }

        public double Result { get; private set; }

        private double FirstNumber { get; set; }

        public double SecondNumber { get; private set; }

        private bool WriteNumber { get; set; }

        delegate double CalculateNumber(double x, double y);
        private CalculateNumber calculateNumber;

        

        public Calculator()
        {
            Clear();
        }

        public void Calculate()
        {
            if (EmptyFirstNumber)
            {
                FirstNumber = SecondNumber;
                history = FirstNumber.ToString();
                EmptyFirstNumber = false;
            }
            else
            {
                history += $" {ActiveOperation} {SecondNumber}";
                Result = calculateNumber(FirstNumber, SecondNumber);
                FirstNumber = Result;
                ActiveNumber = Result.ToString();
                WriteNumber = false;
            }
            
        }

        public void Add()
        {
            calculateNumber = (x, y) => x + y;
            ActiveOperation = "+";
            WriteNumber = false;
        }

        public void Sub()
        {
            calculateNumber = (x, y) => x - y;
            ActiveOperation = "-";
            WriteNumber = false;
        }

        public void Multiplication()
        {
            calculateNumber = (x, y) => x * y;
            ActiveOperation = "x";
            WriteNumber = false;
        }

        public void Division()
        {
            calculateNumber = (x, y) => x / y;
            ActiveOperation = "/";
            WriteNumber = false;
        }

        public void Pow()
        {
            calculateNumber = (x, y) => Math.Pow(x, y);
            ActiveOperation = "^";
            WriteNumber = false;
        }

        public void Sqrt()
        {
            calculateNumber = (x, y) => Math.Sqrt(x);
            ActiveOperation = "sqrt";
            WriteNumber = false;
            Calculate();
        }

        public void Clear()
        {
            calculateNumber = (x, y) => x + y;
            ActiveOperation = "+";
            history = "";
            ActiveNumber = "0";
            Result = 0;
            FirstNumber = 0;
            SecondNumber = 0;
            WriteNumber = true;
            EmptyFirstNumber = true;
        }

        public void PressNumber(byte n)
        {
            n = Math.Max(Convert.ToByte(0), Math.Min(n, Convert.ToByte(9)));
            if (WriteNumber)
            {
                SecondNumber = Convert.ToDouble(ActiveNumber + n);
            }
            else
            {
                Calculate();
                WriteNumber = true;
                SecondNumber = n;
            }
            ActiveNumber = SecondNumber.ToString();
        }

        public void Backspace()
        {
            if (WriteNumber)
            {
                if (ActiveNumber.Length > 1)
                {
                    ActiveNumber = ActiveNumber.Substring(0, ActiveNumber.Length - 1);
                }
                else if (ActiveNumber.Length <= 1)
                {
                    ActiveNumber = "0";
                }
                SecondNumber = Convert.ToDouble(ActiveNumber);
            }
        }
    }
}
