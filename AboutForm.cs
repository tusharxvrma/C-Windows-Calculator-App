using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPRG
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }


        private void AboutForm_Load(object sender, EventArgs e)
        {
            txtBoxAbout1.Text = "1. Digits (0-9): Enter numerical values from 0 to 9 to build the numbers for calculations.\r\n\r\n2. Decimal Point (.): Allows inputting decimal numbers for more precise calculations.\r\n\r\n3. Operators (+, -, x, /): Perform addition, subtraction, multiplication, and division operations between numbers.\r\n\r\n4. Equals (=): Computes the result of the operation displayed on the screen.\r\n\r\n5. Clear Entry (CE): Clears the last digit entered without clearing the entire calculation.\r\n\r\n6. Clear (C): Resets the calculator, clearing all entries and resetting any ongoing operations.\r\n\r\n7. Sign (+/-): Changes the sign of the number currently displayed in the calculator, toggling between positive and negative.\r\n\r\n8. Square (x²): Computes the square of the number currently displayed.\r\n\r\n9. Square Root (√): Computes the square root of the number currently displayed. Handles non-negative inputs.\r\n\r\n10. Comparison (<=): Prepares the calculator to compare two numbers. Displays the first number and the comparison operator for input. After entering the second number and pressing =, it evaluates whether the first number is less than or equal to the second.\r\n\r\n11. Menu Items (Copy, Paste): From the menu, Copy copies the current calculator display value to the clipboard and Paste pastes any copied value into the calculator display\r\n\r\n12. The reciprocal button (1/x): Calculates the multiplicative inverse of the number currently displayed. For a number ( x ), pressing `1/x` displays ( 1/x ). It's useful for quickly finding the reciprocal of a number, ensuring the calculator can handle operations like division more effectively.";
        }
    }
}
