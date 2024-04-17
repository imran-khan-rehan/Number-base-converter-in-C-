using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NumberBaseConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDigitButtons(); // Call the method to create digit buttons
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                // Clear all text boxes
                txtBinary.Clear();
                txtDenary.Clear();
                txtHexadecimal.Clear();

                // Enable or disable controls based on selected base
                bool isBinary = radioButton == radioBinary;
                bool isDenary = radioButton == radioDenary;
                bool isHexadecimal = radioButton == radioHexadecimal;

                txtBinary.Enabled = isBinary;
                txtDenary.Enabled = isDenary;
                txtHexadecimal.Enabled = isHexadecimal;

                numUpDownBits.Enabled = isBinary;
                btnLeftShift.Enabled = isBinary;
                btnRightShift.Enabled = isBinary;

                // Update conversions based on the current input base
               // PerformConversions();
            }
        }

     

        // Event handler for left shift button
        private void btnLeftShift_Click(object sender, EventArgs e)
        {
            // Perform left shift on binary number
            if (!string.IsNullOrEmpty(txtBinary.Text))
            {
                // Check if left shift will result in overflow
                if (txtBinary.Text[0] == '1')
                {
                    MessageBox.Show("Overflow detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Shift binary number to the left
                txtBinary.Text = txtBinary.Text.Substring(1) + "0";
            }

            // Update other fields based on the shifted binary number
            PerformConversions();
        }

        // Event handler for right shift button
        private void btnRightShift_Click(object sender, EventArgs e)
        {
            // Perform right shift on binary number
            if (!string.IsNullOrEmpty(txtBinary.Text))
            {
                // Shift binary number to the right
                txtBinary.Text = "0" + txtBinary.Text.Substring(0, txtBinary.Text.Length - 1);
            }

            // Update other fields based on the shifted binary number
            PerformConversions();
        }

        // Event handler for bits count change
        private void numUpDownBits_ValueChanged(object sender, EventArgs e)
        {
            // Get the new number of bits
            int newBitsCount = (int)numUpDownBits.Value;

            // Update binary number to match the new bits count
            if (!string.IsNullOrEmpty(txtBinary.Text))
            {
                // Trim or pad the binary number to match the new bits count
                if (txtBinary.Text.Length > newBitsCount)
                {
                    // Trim extra bits from the left
                    txtBinary.Text = txtBinary.Text.Substring(txtBinary.Text.Length - newBitsCount);
                }
                else if (txtBinary.Text.Length < newBitsCount)
                {
                    // Pad extra bits with zeros on the left
                    txtBinary.Text = txtBinary.Text.PadLeft(newBitsCount, '0');
                }
            }

            // Update other fields based on the modified binary number
            PerformConversions();
        }

        // Event handler for text change in txtBinary
        private void PerformConversionsTextChanged(object sender, EventArgs e)
        {
            PerformConversions();
        }

        // Event handler for text change in txtDenary
        private void txtDenary_TextChanged(object sender, EventArgs e)
        {
            PerformConversions();
       
        }

        // Method to perform conversions and update other fields
        private void PerformConversions()
        {
            if (radioBinary.Checked && !string.IsNullOrEmpty(txtBinary.Text))
            {
                // Validate binary input
                if (!IsBinary(txtBinary.Text))
                {
                    txtBinary.Clear();
                    
                    MessageBox.Show("Invalid binary number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                // Convert binary to denary and update denary field
                try
                {
                    txtDenary.Text = Convert.ToInt32(txtBinary.Text, 2).ToString();
                }
                catch (FormatException)
                {
                    // Handle invalid binary format
                    txtDenary.Text = "Invalid";
                }

                // Convert denary to hexadecimal and update hexadecimal field
                try
                {
                    int denaryValue = string.IsNullOrEmpty(txtDenary.Text) ? 0 : int.Parse(txtDenary.Text);
                    txtHexadecimal.Text = denaryValue.ToString("X");
                }
                catch (FormatException)
                {
                    // Handle invalid denary format
                    txtHexadecimal.Text = "Invalid";
                }
            }
            else if (radioDenary.Checked && !string.IsNullOrEmpty(txtDenary.Text))
            {
               //MessageBox.Show("Invalid binary number!"+txtDenary.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Validate denary input
                if (!IsDenary(txtDenary.Text))
                {
                    txtDenary.Clear();
                    MessageBox.Show("Invalid denary number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convert denary to binary and update binary field
                try
                {
                    txtBinary.Text = Convert.ToString(int.Parse(txtDenary.Text), 2);
                }
                catch (FormatException)
                {
                    // Handle invalid denary format
                    txtBinary.Text = "Invalid";
                }

                // Convert denary to hexadecimal and update hexadecimal field
                try
                {
                    int denaryValue = string.IsNullOrEmpty(txtDenary.Text) ? 0 : int.Parse(txtDenary.Text);
                    txtHexadecimal.Text = denaryValue.ToString("X");
                }
                catch (FormatException)
                {
                    // Handle invalid denary format
                    txtHexadecimal.Text = "Invalid";
                }
            }
            else if (radioHexadecimal.Checked && !string.IsNullOrEmpty(txtHexadecimal.Text))
            {
              // MessageBox.Show("Invalid binary number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Validate hexadecimal input
                if (!IsHexadecimal(txtHexadecimal.Text))
                {
                    txtHexadecimal.Clear();
                    MessageBox.Show("Invalid hexadecimal number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convert hexadecimal to denary and update denary field
                try
                {
                    txtDenary.Text = Convert.ToInt32(txtHexadecimal.Text, 16).ToString();
                }
                catch (FormatException)
                {
                    // Handle invalid hexadecimal format
                    txtDenary.Text = "Invalid";
                }

                // Convert denary to binary and update binary field
                try
                {
                    int denaryValue = string.IsNullOrEmpty(txtDenary.Text) ? 0 : int.Parse(txtDenary.Text);
                    txtBinary.Text = Convert.ToString(denaryValue, 2);
                }
                catch (FormatException)
                {
                    // Handle invalid denary format
                    txtBinary.Text = "Invalid";
                }
            }
            else
            {
               // MessageBox.Show("Invalid binary number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void PerformConversions(string inputValue)
        {
            // Validate input for binary digits (0 or 1)
            if (radioBinary.Checked && (inputValue != "0" && inputValue != "1"))
            {
                MessageBox.Show("Invalid input for binary conversion! Only 0 and 1 are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate input for hexadecimal digits (0-9, A-F)
            if (radioHexadecimal.Checked && !Regex.IsMatch(inputValue, "^[0-9A-Fa-f]$"))
            {
                MessageBox.Show("Invalid input for hexadecimal conversion! Only digits 0-9 and letters A-F are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Depending on the selected radio button, update the corresponding text field
            if (radioBinary.Checked)
            {
                // Update binary text field
                txtBinary.Text += inputValue;

                // Convert binary to denary and update denary field
                try
                {
                    txtDenary.Text = Convert.ToInt32(txtBinary.Text, 2).ToString();
                }
                catch (FormatException)
                {
                    // Handle invalid binary format
                    txtDenary.Text = "Invalid";
                }

                // Convert denary to hexadecimal and update hexadecimal field
                try
                {
                    int denaryValue = string.IsNullOrEmpty(txtDenary.Text) ? 0 : int.Parse(txtDenary.Text);
                    txtHexadecimal.Text = denaryValue.ToString("X");
                }
                catch (FormatException)
                {
                    // Handle invalid denary format
                    txtHexadecimal.Text = "Invalid";
                }
            }
            else if (radioDenary.Checked)
            {
                // Update denary text field
                txtDenary.Text += inputValue;

                // Convert denary to binary and update binary field
                try
                {
                    txtBinary.Text = Convert.ToString(int.Parse(txtDenary.Text), 2);
                }
                catch (FormatException)
                {
                    // Handle invalid denary format
                    txtBinary.Text = "Invalid";
                }

                // Convert denary to hexadecimal and update hexadecimal field
                try
                {
                    int denaryValue = string.IsNullOrEmpty(txtDenary.Text) ? 0 : int.Parse(txtDenary.Text);
                    txtHexadecimal.Text = denaryValue.ToString("X");
                }
                catch (FormatException)
                {
                    // Handle invalid denary format
                    txtHexadecimal.Text = "Invalid";
                }
            }
            else if (radioHexadecimal.Checked)
            {
                // Update hexadecimal text field
                txtHexadecimal.Text += inputValue;

                // Convert hexadecimal to denary and update denary field
                try
                {
                    txtDenary.Text = Convert.ToInt32(txtHexadecimal.Text, 16).ToString();
                }
                catch (FormatException)
                {
                    // Handle invalid hexadecimal format
                    txtDenary.Text = "Invalid";
                }

                // Convert denary to binary and update binary field
                try
                {
                    int denaryValue = string.IsNullOrEmpty(txtDenary.Text) ? 0 : int.Parse(txtDenary.Text);
                    txtBinary.Text = Convert.ToString(denaryValue, 2);
                }
                catch (FormatException)
                {
                    // Handle invalid denary format
                    txtBinary.Text = "Invalid";
                }
            }
        }

        // Method to initialize digit buttons

     

        // Method to check if a string is a valid binary number
        private bool IsBinary(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }

        // Method to check if a string is a valid denary number
        private bool IsDenary(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        // Method to check if a string is a valid hexadecimal number
        private bool IsHexadecimal(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && !(c >= 'A' && c <= 'F') && !(c >= 'a' && c <= 'f'))
                    return false;
            }
            return true;
        }

        private void txtDenary_TextChanged_1(object sender, EventArgs e)
        {
            PerformConversions();
        }

        private void txtDenary_TextChanged_2(object sender, EventArgs e)
        {
            PerformConversions();
        }

        private void txtHexadecimal_TextChanged(object sender, EventArgs e)
        {
            PerformConversions();
        }
        // Event handler for digit buttons
        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string digit = button.Text;

            // Append the clicked digit to the text box that currently has focus
            if (ActiveControl is TextBox textBox)
            {
                textBox.Text += digit;
            }

            // Update other fields based on the entered value
            PerformConversions();
        }

        // Method to initialize digit buttons
        private void InitializeDigitButtons()
        {
            // Add digit buttons
            for (int i = 0; i <= 9; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Name = "btn" + i.ToString(); // Assign names to buttons
                button.Size = new System.Drawing.Size(40, 40);
                button.Location = new System.Drawing.Point(20 + (i % 5) * 50, 230 + (i / 5) * 50);
                button.Click += new System.EventHandler(this.DigitButton_Click); // Wire up the event handler
                this.Controls.Add(button);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDigitButtons();
            txtBinary.Enabled = true;
            txtDenary.Enabled = false;
            txtHexadecimal.Enabled = false;

            numUpDownBits.Enabled = true;
            btnLeftShift.Enabled = true;
            btnRightShift.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerformConversions("0");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PerformConversions("1");

        }

        private void two_Click(object sender, EventArgs e)
        {
            PerformConversions("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            PerformConversions("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            PerformConversions("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            PerformConversions("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            PerformConversions("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            PerformConversions("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            PerformConversions("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            PerformConversions("9");
        }

        private void A_Click(object sender, EventArgs e)
        {
            PerformConversions("A");
        }

        private void B_Click(object sender, EventArgs e)
        {
            PerformConversions("B");
        }

        private void C_Click(object sender, EventArgs e)
        {
            PerformConversions("C");
        }

        private void D_Click(object sender, EventArgs e)
        {
            PerformConversions("D");
        }

        private void E_Click(object sender, EventArgs e)
        {
            PerformConversions("E");
        }

        private void F_Click(object sender, EventArgs e)
        {
            PerformConversions("F");
        }
    }
}
