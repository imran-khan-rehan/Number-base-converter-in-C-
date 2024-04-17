using System.Drawing;
using System.Windows.Forms;

namespace NumberBaseConverter
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
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.lblBinary = new System.Windows.Forms.Label();
            this.lblDenary = new System.Windows.Forms.Label();
            this.lblHexadecimal = new System.Windows.Forms.Label();
            this.txtHexadecimal = new System.Windows.Forms.TextBox();
            this.btnLeftShift = new System.Windows.Forms.Button();
            this.btnRightShift = new System.Windows.Forms.Button();
            this.numUpDownBits = new System.Windows.Forms.NumericUpDown();
            this.lblBits = new System.Windows.Forms.Label();
            this.radioBinary = new System.Windows.Forms.RadioButton();
            this.radioDenary = new System.Windows.Forms.RadioButton();
            this.radioHexadecimal = new System.Windows.Forms.RadioButton();
            this.txtDenary = new System.Windows.Forms.TextBox();
            this.zero = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBits)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBinary
            // 
            this.txtBinary.Location = new System.Drawing.Point(124, 38);
            this.txtBinary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(281, 26);
            this.txtBinary.TabIndex = 0;
            this.txtBinary.TextChanged += new System.EventHandler(this.PerformConversionsTextChanged);
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Location = new System.Drawing.Point(14, 41);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(53, 20);
            this.lblBinary.TabIndex = 1;
            this.lblBinary.Text = "Binary";
            // 
            // lblDenary
            // 
            this.lblDenary.AutoSize = true;
            this.lblDenary.Location = new System.Drawing.Point(14, 90);
            this.lblDenary.Name = "lblDenary";
            this.lblDenary.Size = new System.Drawing.Size(60, 20);
            this.lblDenary.TabIndex = 3;
            this.lblDenary.Text = "Denary";
            // 
            // lblHexadecimal
            // 
            this.lblHexadecimal.AutoSize = true;
            this.lblHexadecimal.Location = new System.Drawing.Point(14, 139);
            this.lblHexadecimal.Name = "lblHexadecimal";
            this.lblHexadecimal.Size = new System.Drawing.Size(100, 20);
            this.lblHexadecimal.TabIndex = 5;
            this.lblHexadecimal.Text = "Hexadecimal";
            // 
            // txtHexadecimal
            // 
            this.txtHexadecimal.Location = new System.Drawing.Point(124, 135);
            this.txtHexadecimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHexadecimal.Name = "txtHexadecimal";
            this.txtHexadecimal.Size = new System.Drawing.Size(281, 26);
            this.txtHexadecimal.TabIndex = 4;
            this.txtHexadecimal.TextChanged += new System.EventHandler(this.txtHexadecimal_TextChanged);
            // 
            // btnLeftShift
            // 
            this.btnLeftShift.Location = new System.Drawing.Point(124, 200);
            this.btnLeftShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLeftShift.Name = "btnLeftShift";
            this.btnLeftShift.Size = new System.Drawing.Size(112, 38);
            this.btnLeftShift.TabIndex = 6;
            this.btnLeftShift.Text = "Left Shift";
            this.btnLeftShift.UseVisualStyleBackColor = true;
            this.btnLeftShift.Click += new System.EventHandler(this.btnLeftShift_Click);
            // 
            // btnRightShift
            // 
            this.btnRightShift.Location = new System.Drawing.Point(292, 200);
            this.btnRightShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRightShift.Name = "btnRightShift";
            this.btnRightShift.Size = new System.Drawing.Size(112, 38);
            this.btnRightShift.TabIndex = 7;
            this.btnRightShift.Text = "Right Shift";
            this.btnRightShift.UseVisualStyleBackColor = true;
            this.btnRightShift.Click += new System.EventHandler(this.btnRightShift_Click);
            // 
            // numUpDownBits
            // 
            this.numUpDownBits.Location = new System.Drawing.Point(123, 301);
            this.numUpDownBits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numUpDownBits.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numUpDownBits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownBits.Name = "numUpDownBits";
            this.numUpDownBits.Size = new System.Drawing.Size(112, 26);
            this.numUpDownBits.TabIndex = 8;
            this.numUpDownBits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownBits.ValueChanged += new System.EventHandler(this.numUpDownBits_ValueChanged);
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Location = new System.Drawing.Point(14, 301);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(83, 20);
            this.lblBits.TabIndex = 9;
            this.lblBits.Text = "Bits Count";
            // 
            // radioBinary
            // 
            this.radioBinary.AutoSize = true;
            this.radioBinary.Checked = true;
            this.radioBinary.Location = new System.Drawing.Point(17, 11);
            this.radioBinary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBinary.Name = "radioBinary";
            this.radioBinary.Size = new System.Drawing.Size(78, 24);
            this.radioBinary.TabIndex = 10;
            this.radioBinary.TabStop = true;
            this.radioBinary.Text = "Binary";
            this.radioBinary.UseVisualStyleBackColor = true;
            this.radioBinary.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioDenary
            // 
            this.radioDenary.AutoSize = true;
            this.radioDenary.Location = new System.Drawing.Point(101, 11);
            this.radioDenary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioDenary.Name = "radioDenary";
            this.radioDenary.Size = new System.Drawing.Size(85, 24);
            this.radioDenary.TabIndex = 11;
            this.radioDenary.Text = "Denary";
            this.radioDenary.UseVisualStyleBackColor = true;
            this.radioDenary.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioHexadecimal
            // 
            this.radioHexadecimal.AutoSize = true;
            this.radioHexadecimal.Location = new System.Drawing.Point(195, 11);
            this.radioHexadecimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioHexadecimal.Name = "radioHexadecimal";
            this.radioHexadecimal.Size = new System.Drawing.Size(125, 24);
            this.radioHexadecimal.TabIndex = 12;
            this.radioHexadecimal.Text = "Hexadecimal";
            this.radioHexadecimal.UseVisualStyleBackColor = true;
            this.radioHexadecimal.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // txtDenary
            // 
            this.txtDenary.Location = new System.Drawing.Point(123, 87);
            this.txtDenary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDenary.Name = "txtDenary";
            this.txtDenary.Size = new System.Drawing.Size(281, 26);
            this.txtDenary.TabIndex = 13;
            this.txtDenary.TextChanged += new System.EventHandler(this.txtDenary_TextChanged_2);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(17, 172);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(35, 27);
            this.zero.TabIndex = 14;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button1_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(183, 168);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(35, 27);
            this.four.TabIndex = 15;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(224, 168);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(35, 27);
            this.five.TabIndex = 16;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(265, 168);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(35, 27);
            this.six.TabIndex = 17;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(306, 168);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(35, 27);
            this.seven.TabIndex = 18;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(347, 168);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(35, 27);
            this.eight.TabIndex = 19;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(142, 168);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(35, 27);
            this.three.TabIndex = 20;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(101, 168);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(35, 27);
            this.two.TabIndex = 21;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(58, 170);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(35, 27);
            this.one.TabIndex = 22;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button9_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(388, 166);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(35, 27);
            this.nine.TabIndex = 23;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(285, 248);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(35, 27);
            this.F.TabIndex = 25;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.F_Click);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(238, 248);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(35, 27);
            this.E.TabIndex = 26;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(183, 248);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(35, 27);
            this.D.TabIndex = 27;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(124, 248);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(35, 27);
            this.C.TabIndex = 28;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(79, 248);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(35, 27);
            this.B.TabIndex = 29;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(17, 248);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(35, 27);
            this.A.TabIndex = 30;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 351);
            this.Controls.Add(this.A);
            this.Controls.Add(this.B);
            this.Controls.Add(this.C);
            this.Controls.Add(this.D);
            this.Controls.Add(this.E);
            this.Controls.Add(this.F);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.txtDenary);
            this.Controls.Add(this.radioHexadecimal);
            this.Controls.Add(this.radioDenary);
            this.Controls.Add(this.radioBinary);
            this.Controls.Add(this.lblBits);
            this.Controls.Add(this.numUpDownBits);
            this.Controls.Add(this.btnRightShift);
            this.Controls.Add(this.btnLeftShift);
            this.Controls.Add(this.lblHexadecimal);
            this.Controls.Add(this.txtHexadecimal);
            this.Controls.Add(this.lblDenary);
            this.Controls.Add(this.lblBinary);
            this.Controls.Add(this.txtBinary);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Number Base Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.Label lblDenary;
        private System.Windows.Forms.Label lblHexadecimal;
        private System.Windows.Forms.TextBox txtHexadecimal;
        private System.Windows.Forms.Button btnLeftShift;
        private System.Windows.Forms.Button btnRightShift;
        private System.Windows.Forms.NumericUpDown numUpDownBits;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.RadioButton radioBinary;
        private System.Windows.Forms.RadioButton radioDenary;
        private System.Windows.Forms.RadioButton radioHexadecimal;
        private TextBox txtDenary;
        private Button zero;
        private Button four;
        private Button five;
        private Button six;
        private Button seven;
        private Button eight;
        private Button three;
        private Button two;
        private Button one;
        private Button nine;
        private Button F;
        private Button E;
        private Button D;
        private Button C;
        private Button B;
        private Button A;
    }
}
