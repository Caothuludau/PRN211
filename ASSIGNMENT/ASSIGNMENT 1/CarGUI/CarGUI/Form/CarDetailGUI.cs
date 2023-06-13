using CarGUI.DAL;
using CarGUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGUI
{
    public partial class CarDetailGUI : Form
    {
        public Car SelectedCar { get; set; }
        public string DisplayMode { get; set; }
        public CarDetailGUI(Car selectedCar, string displayMode)
        {
            InitializeComponent();
            SelectedCar = selectedCar;
            DisplayMode = displayMode;
        }

        private void CarDetailGUI_Load(object sender, EventArgs e)
        {
            if (DisplayMode.Equals("View Details"))
            {
                button_Cancel.Visible = false;
                button_Save.Visible = false;

                textBox_CarID.Text = SelectedCar.CarID.ToString();
                textBox_Color.Text = SelectedCar.Color;
                textBox_Make.Text = SelectedCar.Make;
                textBox_Petname.Text = SelectedCar.Petname;
                label_ColorBox.BackColor = Color.FromName(SelectedCar.Color.Trim());

            }
            else if (DisplayMode.Equals("Edit") && Authentication.isAdmin)
            {
                button_Back.Visible = false;

                textBox_CarID.Text = SelectedCar.CarID.ToString();
                textBox_Color.Text = SelectedCar.Color;
                textBox_Make.Text = SelectedCar.Make;
                textBox_Petname.Text = SelectedCar.Petname;

                textBox_Make.ReadOnly = false;
                textBox_Petname.ReadOnly = false;
                label_ColorBox.BackColor = Color.FromName(SelectedCar.Color.Trim());



            }
            else if (DisplayMode.Equals("Add") && Authentication.isAdmin)
            {

                button_Back.Visible = false;

                textBox_CarID.Text = SelectedCar.CarID.ToString();
                textBox_Color.ReadOnly = false;
                textBox_Make.ReadOnly = false;
                textBox_Petname.ReadOnly = false;
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (DisplayMode.Equals("Edit"))
            {
                if (textBox_Color.Text == null || textBox_Make.Text == null || textBox_Petname.Text == null)
                {

                    DialogResult result = MessageBox.Show("There exists empty field(s). Do you still want to make this change to the car?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        textBox_Color.Text = "";
                        textBox_Make.Text = "";
                        textBox_Petname.Text = "";
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                }

                this.SelectedCar.Color = textBox_Color.Text;
                this.SelectedCar.Make = textBox_Make.Text;
                this.SelectedCar.Petname = textBox_Petname.Text;
                DAOCar.UpdateCar(SelectedCar);
                MessageBox.Show("This car is updated!", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (DisplayMode.Equals("Add"))
            {

                if (textBox_Color.Text == null || textBox_Make.Text == null || textBox_Petname.Text == null)
                {

                    DialogResult result = MessageBox.Show("There exists empty field(s). Do you still want to add new car?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        textBox_Color.Text = "";
                        textBox_Make.Text = "";
                        textBox_Petname.Text = "";
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                this.SelectedCar.Color = textBox_Color.Text;
                this.SelectedCar.Make = textBox_Make.Text;
                this.SelectedCar.Petname = textBox_Petname.Text;
                DAOCar.AddNewCar(SelectedCar);
                MessageBox.Show("A new car is added!", "", MessageBoxButtons.OK);

                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_ColorBox_Click(object sender, EventArgs e)
        {
            if (colorDialog_CarColor.ShowDialog() == DialogResult.OK)
            {
                Color carColor = colorDialog_CarColor.Color;
                textBox_Color.Text = carColor.Name.ToString();
            }
        }
    }
}
