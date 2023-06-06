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
        public CarDetailGUI(Car selectedCar)
        {
            InitializeComponent();
            SelectedCar = selectedCar;
        }

        private void CarDetailGUI_Load(object sender, EventArgs e)
        {
            textBox_CarID.Text = SelectedCar.CarID.ToString();
            textBox_Color.Text = SelectedCar.Color;
            textBox_Make.Text = SelectedCar.Make;
            textBox_Petname.Text = SelectedCar.Petname;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
