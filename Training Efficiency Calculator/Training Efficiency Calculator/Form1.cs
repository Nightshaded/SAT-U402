﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        List<int> Inputs = new List<int>();
        List<int> Benchmarks = new List<int>();
        List<string> Titles = new List<string>();
        List<string> Outputs = new List<string>();
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Inputs.Clear();
            Benchmarks.Clear();
            Titles.Clear();
            Outputs.Clear();
            if (Input1.Text != "" && BenchmarkInput1.Text != "" && TitleInput1.Text != "")
            {
                Output1.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput1.Text), Convert.ToDouble(Input1.Text)), 2) + "%");
                TitleOutput1.Text = TitleInput1.Text;
                Inputs.Add(Convert.ToInt32(Input1.Text));
                Benchmarks.Add(Convert.ToInt32(BenchmarkInput1.Text));
                Titles.Add(TitleInput1.Text);
                Outputs.Add(Output1.Text);
                Input1.Text = "";
                BenchmarkInput1.Text = "";
                TitleInput1.Text = "";
            }
            if (Input2.Text != "" && BenchmarkInput2.Text != "" && TitleInput2.Text != "")
            {
                TitleOutput2.Text = TitleInput2.Text;
                Output2.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput2.Text), Convert.ToDouble(Input2.Text)), 2) + "%");
                Inputs.Add(Convert.ToInt32(Input2.Text));
                Benchmarks.Add(Convert.ToInt32(BenchmarkInput2.Text));
                Titles.Add(TitleInput2.Text);
                Outputs.Add(Output2.Text);
                Input2.Text = "";
                BenchmarkInput2.Text = "";
                TitleInput2.Text = "";
            }
            if (Input3.Text != "" && BenchmarkInput3.Text != "" && TitleInput3.Text != "")
            {
                TitleOutput3.Text = TitleInput3.Text;
                Output3.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput3.Text), Convert.ToDouble(Input3.Text)), 2) + "%");
                Inputs.Add(Convert.ToInt32(Input3.Text));
                Benchmarks.Add(Convert.ToInt32(BenchmarkInput3.Text));
                Titles.Add(TitleInput3.Text);
                Outputs.Add(Output3.Text);
                Input3.Text = "";
                BenchmarkInput3.Text = "";
                TitleInput3.Text = "";
            }
            if (Input4.Text != "" && BenchmarkInput4.Text != "" && TitleInput4.Text != "")
            {

                TitleOutput4.Text = TitleInput4.Text;
                Output4.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput4.Text), Convert.ToDouble(Input4.Text)), 2) + "%");
                Inputs.Add(Convert.ToInt32(Input4.Text));
                Benchmarks.Add(Convert.ToInt32(BenchmarkInput4.Text));
                Titles.Add(TitleInput4.Text);
                Outputs.Add(Output4.Text);
                Input4.Text = "";
                BenchmarkInput4.Text = "";
                TitleInput4.Text = "";
            }
            if (Input5.Text != "" && BenchmarkInput5.Text != "" && TitleInput5.Text != "")
            {
                TitleOutput5.Text = TitleInput5.Text;
                Output5.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput5.Text), Convert.ToDouble(Input5.Text)), 2) + "%");
                Inputs.Add(Convert.ToInt32(Input5.Text));
                Benchmarks.Add(Convert.ToInt32(BenchmarkInput5.Text));
                Titles.Add(TitleInput5.Text);
                Outputs.Add(Output5.Text);
                Input5.Text = "";
                BenchmarkInput5.Text = "";
                TitleInput5.Text = "";
            }
            if (Input6.Text != "" && BenchmarkInput6.Text != "" && TitleInput6.Text != "")
            {
                TitleOutput6.Text = TitleInput6.Text;
                Output6.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput6.Text), Convert.ToDouble(Input6.Text)), 2) + "%");
                Inputs.Add(Convert.ToInt32(Input6.Text));
                Benchmarks.Add(Convert.ToInt32(BenchmarkInput6.Text));
                Titles.Add(TitleInput6.Text);
                Outputs.Add(Output6.Text);
                Input6.Text = "";
                BenchmarkInput6.Text = "";
                TitleInput6.Text = "";
            }
            if (Input7.Text != "" && BenchmarkInput7.Text != "" && TitleInput7.Text != "")
            {
                TitleOutput7.Text = TitleInput7.Text;
                Output7.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput7.Text), Convert.ToDouble(Input7.Text)), 2) + "%");
                Inputs.Add(Convert.ToInt32(Input7.Text));
                Benchmarks.Add(Convert.ToInt32(BenchmarkInput7.Text));
                Titles.Add(TitleInput7.Text);
                Outputs.Add(Output7.Text);
                Input7.Text = "";
                BenchmarkInput7.Text = "";
                TitleInput7.Text = "";
            }
            if (Input8.Text != "" && BenchmarkInput8.Text != "" && TitleInput8.Text != "")
            {
                TitleOutput8.Text = TitleInput8.Text;
                Output8.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput8.Text), Convert.ToDouble(Input8.Text)), 2) + "%");
                Inputs.Add(Convert.ToInt32(Input8.Text));
                Benchmarks.Add(Convert.ToInt32(BenchmarkInput8.Text));
                Titles.Add(TitleInput8.Text);
                Outputs.Add(Output8.Text);
                Input8.Text = "";
                BenchmarkInput8.Text = "";
                TitleInput8.Text = "";
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            /*string MyDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(MyDocPath, TextFileInput.Text)))
            {
                foreach (int line in Inputs)
                    outputFile.WriteLine(line);
            }
            //System.IO.File.WriteAllLines(MyDocPath, Inputs.Select(x => x.ToString()).ToArray());  
            */
            // Create a string array with the lines of text
            string[] Titles2 = {Titles[0], Titles[1],Titles[3] };

            // Set a variable to the My Documents path.
            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "WriteLines.txt")))
            {
                foreach (string line in Titles2)
                    outputFile.WriteLine(line);
            }
        }
    }
}
