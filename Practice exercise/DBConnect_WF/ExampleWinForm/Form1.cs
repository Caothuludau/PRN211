using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleWinForm
{
    public partial class Form1 : Form
    {
        private int buttonCount = 1;
        private int rowButtonCount = 1;
        private int columnButtonCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new Button control
            Button newButton = new Button();
            newButton.Text = "Button " + buttonCount;
            newButton.Size = new Size(105,88);
            int formWidth = this.Size.Width; // Get the width of the form
            int formHeight = this.Size.Height; // Get the height of the form

            // Reset RowButtonCount and move to a new Row
            if (rowButtonCount * 200 - 400 > formHeight)
            {
                rowButtonCount = 0;
                columnButtonCount++;
            }

            //When reach the formWidth, stop generate Button
            if (columnButtonCount * 200 + 88 <= formWidth)
            {
                newButton.Location = new Point(columnButtonCount * 200 + 40, rowButtonCount * 100 + 100);
                buttonCount++;
                rowButtonCount++;

                // Add the new button to the form's Controls collection
                this.Controls.Add(newButton);
            }

            // Update the TextBox with the current count of buttons
            buttonCountTextBox.Text = buttonCount.ToString();
        }
    }
}
