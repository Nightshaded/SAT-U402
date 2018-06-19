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
            List<TextBox> InputList = new List<TextBox>();
            for (int i = 1; i < 9; i++)
            {
                InputList.Add((TextBox)Controls.Find("Input" + i, true)[0]);
            }
            List<TextBox> BenchmarkList = new List<TextBox>();
            for (int k = 1; k < 9; k++)
            {
                BenchmarkList.Add((TextBox)Controls.Find("BenchmarkInput" + k, true)[0]);
            }
            List<double> OutputList = new List<double>();
            for(int l = 0; l < 9; l++)
            {
                OutputList.Add(Calculate(Convert.ToDouble(BenchmarkList[l]), Convert.ToDouble(InputList[l])));
            }
            Output1.Text = Convert.ToString(OutputList[0]);
            Output2.Text = Convert.ToString(OutputList[1]);
            Output3.Text = Convert.ToString(OutputList[2]);
            Output4.Text = Convert.ToString(OutputList[3]);
            Output5.Text = Convert.ToString(OutputList[4]);
            Output6.Text = Convert.ToString(OutputList[5]);
            Output7.Text = Convert.ToString(OutputList[6]);
            Output8.Text = Convert.ToString(OutputList[7]);
        }
    }
}
