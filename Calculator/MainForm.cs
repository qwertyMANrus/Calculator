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
        private int StatusNumber { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateForm()
        {
            tbNumberStatus.Text = StatusNumber.ToString();
        }

        public void Decide()
        {

            UpdateForm();
        }

        public void clickNumber(byte n)
        {
            StatusNumber = n;
            UpdateForm();
        }

        public void bClear_Click(object sender, EventArgs e)
        {

            UpdateForm();
        }

        private void bBackspace_Click(object sender, EventArgs e)
        {

            UpdateForm();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            clickNumber(0);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            clickNumber(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            clickNumber(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            clickNumber(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            clickNumber(4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            clickNumber(5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            clickNumber(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            clickNumber(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            clickNumber(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            clickNumber(9);
        }

        private void bEqually_Click(object sender, EventArgs e)
        {
            Decide();
        }
    }
}
