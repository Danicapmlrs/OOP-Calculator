
namespace OOP_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Percentage = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputBox.Location = new System.Drawing.Point(12, 28);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(385, 91);
            this.OutputBox.TabIndex = 0;
            this.OutputBox.Text = "";
            this.OutputBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightGreen;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(22, 148);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 60);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightGreen;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(172, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 60);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button2_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightGreen;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(97, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 60);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGreen;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(97, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightGreen;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(172, 214);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 60);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGreen;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(22, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(97, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(172, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(22, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button9_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(247, 148);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(69, 60);
            this.Add.TabIndex = 14;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.button10_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Minus.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Minus.Location = new System.Drawing.Point(247, 214);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(69, 60);
            this.Minus.TabIndex = 13;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.button11_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Multiply.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Multiply.Location = new System.Drawing.Point(247, 280);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(69, 60);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "x";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.button12_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Divide.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Divide.Location = new System.Drawing.Point(247, 346);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(69, 60);
            this.Divide.TabIndex = 11;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.button13_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(322, 148);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(69, 60);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.button14_Click);
            // 
            // Percentage
            // 
            this.Percentage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Percentage.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Percentage.Location = new System.Drawing.Point(322, 214);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(69, 60);
            this.Percentage.TabIndex = 16;
            this.Percentage.Text = "%";
            this.Percentage.UseVisualStyleBackColor = false;
            this.Percentage.Click += new System.EventHandler(this.button15_Click);
            // 
            // Decimal
            // 
            this.Decimal.BackColor = System.Drawing.Color.Aquamarine;
            this.Decimal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Decimal.Location = new System.Drawing.Point(172, 346);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(69, 60);
            this.Decimal.TabIndex = 10;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = false;
            // 
            // Equals
            // 
            this.Equals.BackColor = System.Drawing.Color.DimGray;
            this.Equals.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Equals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Equals.Location = new System.Drawing.Point(322, 280);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(69, 126);
            this.Equals.TabIndex = 17;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = false;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.LightGreen;
            this.button0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(22, 346);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(144, 60);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button18_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.OutputBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Percentage;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button button0;
    }
}

