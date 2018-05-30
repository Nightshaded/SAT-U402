namespace Training_Efficiency_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Save = new System.Windows.Forms.Button();
            this.LargeTitle = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.InputTitle = new System.Windows.Forms.Label();
            this.BenchmarkTitle = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(556, 1078);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(386, 133);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // LargeTitle
            // 
            this.LargeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargeTitle.Location = new System.Drawing.Point(314, 40);
            this.LargeTitle.Name = "LargeTitle";
            this.LargeTitle.Size = new System.Drawing.Size(870, 91);
            this.LargeTitle.TabIndex = 1;
            this.LargeTitle.Text = "Training Efficiency Calculator";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(30, 176);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(88, 42);
            this.Title.TabIndex = 2;
            this.Title.Text = "Title";
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(124, 176);
            this.TitleInput.Multiline = true;
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(313, 42);
            this.TitleInput.TabIndex = 3;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(136, 261);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(126, 42);
            this.Input.TabIndex = 4;
            // 
            // InputTitle
            // 
            this.InputTitle.AutoSize = true;
            this.InputTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTitle.Location = new System.Drawing.Point(30, 261);
            this.InputTitle.Name = "InputTitle";
            this.InputTitle.Size = new System.Drawing.Size(100, 42);
            this.InputTitle.TabIndex = 5;
            this.InputTitle.Text = "Input";
            // 
            // BenchmarkTitle
            // 
            this.BenchmarkTitle.AutoSize = true;
            this.BenchmarkTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BenchmarkTitle.Location = new System.Drawing.Point(30, 341);
            this.BenchmarkTitle.Name = "BenchmarkTitle";
            this.BenchmarkTitle.Size = new System.Drawing.Size(207, 42);
            this.BenchmarkTitle.TabIndex = 6;
            this.BenchmarkTitle.Text = "Benchmark";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(243, 341);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 42);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 1383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.BenchmarkTitle);
            this.Controls.Add(this.InputTitle);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.LargeTitle);
            this.Controls.Add(this.Save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label LargeTitle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label InputTitle;
        private System.Windows.Forms.Label BenchmarkTitle;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}

