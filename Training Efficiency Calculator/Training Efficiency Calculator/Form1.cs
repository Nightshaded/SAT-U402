using System;
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
            SetClientSizeCore(740,820);
        }
        public double Calculate(double Benchmark, double Input)
        {
            // creates a method to calculate
            double Output = Input / Benchmark * 100;
            // finds the percentage 
            return Output;
            // returns the percent
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        List<int> Inputs = new List<int>();
        List<int> Benchmarks = new List<int>();
        List<string> Titles = new List<string>();
        List<string> Outputs = new List<string>();
        // creates the lists
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Inputs.Clear();
            Benchmarks.Clear();
            Titles.Clear();
            Outputs.Clear(); 
            // clears all the lists 
            Titles.Add("Titles");
            if (Input1.Text != "" && BenchmarkInput1.Text != "" && TitleInput1.Text != "")
            {
                Output1.Text = Convert.ToString(Math.Round(Calculate(Convert.ToDouble(BenchmarkInput1.Text), Convert.ToDouble(Input1.Text)), 2) + "%");
                // calculates the output efficency and changes the label Output1
                TitleOutput1.Text = TitleInput1.Text;
                // transfers the title input to the label title output
                Inputs.Add(Convert.ToInt32(Input1.Text));
                // adds the Input to a list
                Benchmarks.Add(Convert.ToInt32(BenchmarkInput1.Text));
                // adds the Benchmark to a list
                Titles.Add(TitleInput1.Text);
                // adds the Title to the list
                Outputs.Add(Output1.Text);
                // adds the output to the list
                Input1.Text = "";
                BenchmarkInput1.Text = "";
                TitleInput1.Text = "";
                // clears all the textbox inputs
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
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // finds the unique pathway for any computer to the Documents folder
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, TextFileInput.Text + ".txt")))
            // uses steamwriter to create a file in the Documents folder and names it to the user's input
            {
                foreach (string item in Titles)
                // for each item in the list it will run a loop until it reaches the end of the list
                {
                    outputFile.WriteLine(item);
                    // prints the the list item into the text document
                }
                outputFile.WriteLine("Inputs");
                // prints out the Title of the list 
                foreach (int item2 in Inputs)
                {
                    outputFile.WriteLine(item2);
                }
                outputFile.WriteLine("Benchmarks");
                foreach (int item3 in Benchmarks)
                {
                    outputFile.WriteLine(item3);
                }
                outputFile.WriteLine("Outputs");
                foreach (string item4 in Outputs)
                {
                    outputFile.WriteLine(item4);
                }
            }
            TextFileInput.Text = "";
            // clears the text file input name
        }
    }
}
