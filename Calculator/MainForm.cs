using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class MainForm : Form
    {
        Calculator Calc = new Calculator();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            tbNumberStatus.Text = Calc.ActiveNumber;
            History.Text = Calc.History;
            ActiveOperation.Text = $"{Calc.ActiveOperation} {Calc.SecondNumber.ToString()}";
        }

        public void bClear_Click(object sender, EventArgs e)
        {
            Calc.Clear();
            UpdateForm();
        }

        private void bBackspace_Click(object sender, EventArgs e)
        {
            Calc.Backspace();
            UpdateForm();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Calc.PressNumber(0);
            UpdateForm();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Calc.PressNumber(1);
            UpdateForm();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Calc.PressNumber(2);
            UpdateForm();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Calc.PressNumber(3);
            UpdateForm();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Calc.PressNumber(4);
            UpdateForm();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Calc.PressNumber(5);
            UpdateForm();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Calc.PressNumber(6);
            UpdateForm();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Calc.PressNumber(7);
            UpdateForm();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Calc.PressNumber(8);
            UpdateForm();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Calc.PressNumber(9);
            UpdateForm();
        }

        private void bEqually_Click(object sender, EventArgs e)
        {
            Calc.Calculate();
            UpdateForm();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Calc.Add();
            UpdateForm();
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            Calc.Sub();
            UpdateForm();
        }

        private void bMultiplication_Click(object sender, EventArgs e)
        {
            Calc.Multiplication();
            UpdateForm();
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            Calc.Division();
            UpdateForm();
        }

        private void bPow_Click(object sender, EventArgs e)
        {
            Calc.Pow();
            UpdateForm();
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            Calc.Sqrt();
            UpdateForm();
        }
    }
}
