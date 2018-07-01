using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_Efficiency_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetClientSizeCore(740,800);
        }
        public double Calculate(double Benchmark, double Input)
        {
            double Output = Input / Benchmark * 100;
            return Output;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (Input1.Text != "" && BenchmarkInput1.Text != "" && TitleInput1.Text != "")
            {
                Output1.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput1.Text), Convert.ToDouble(Input1.Text)), 2) + "%");
                TitleOutput1.Text = TitleInput1.Text;
            }
            if (Input2.Text != "" && BenchmarkInput2.Text != "" && TitleInput2.Text != "")
            {
                TitleOutput2.Text = TitleInput2.Text;
                Output2.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput2.Text), Convert.ToDouble(Input2.Text)), 2) + "%");
            }
            if (Input3.Text != "" && BenchmarkInput3.Text != "" && TitleInput3.Text != "")
            {
                TitleOutput3.Text = TitleInput3.Text;
                Output3.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput3.Text), Convert.ToDouble(Input3.Text)), 2) + "%");
            }
            if (Input4.Text != "" && BenchmarkInput4.Text != "" && TitleInput4.Text != "")
            {

                TitleOutput4.Text = TitleInput4.Text;
                Output4.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput4.Text), Convert.ToDouble(Input4.Text)), 2) + "%");
            }
            if (Input5.Text != "" && BenchmarkInput5.Text != "" && TitleInput5.Text != "")
            {
                TitleOutput5.Text = TitleInput5.Text;
                Output5.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput5.Text), Convert.ToDouble(Input5.Text)), 2) + "%");
            }
            if (Input6.Text != "" && BenchmarkInput6.Text != "" && TitleInput6.Text != "")
            {
                TitleOutput6.Text = TitleInput6.Text;
                Output6.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput6.Text), Convert.ToDouble(Input6.Text)), 2) + "%");
            }
            if (Input7.Text != "" && BenchmarkInput7.Text != "" && TitleInput7.Text != "")
            {
                TitleOutput7.Text = TitleInput7.Text;
                Output7.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput7.Text), Convert.ToDouble(Input7.Text)), 2) + "%");
            }
            if (Input8.Text != "" && BenchmarkInput8.Text != "" && TitleInput8.Text != "")
            {
                TitleOutput8.Text = TitleInput8.Text;
                Output8.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput8.Text), Convert.ToDouble(Input8.Text)), 2) + "%");
            }
        }
    }
}
