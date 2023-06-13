using CarGUI.DAL;
using CarGUI.Model;
using System.Data;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CarGUI
{
    public partial class CarGUI : Form
    {
        public CarGUI()
        {
            InitializeComponent();
        }

        public void CarGUI_Load(object sender, EventArgs e)
        {
            //dataGridView_Car.Rows.Clear();
            List<Car> cars = DAOCar.GetAllCars();
            dataGridView_Car.DataSource = cars;

            //hide CarID column
            dataGridView_Car.Columns[0].Visible = false;

            //display a Detail view button for each row
            AddButton(dataGridView_Car, "carDetailButton", "Car Detail", "View Details");

            //display total number of cars
            label_TotalCar.Text = cars.Count.ToString();
        }

        private static void AddButton(DataGridView dataGridView, string columnName, string columnHeaderText, string columnText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = columnName;
            buttonColumn.HeaderText = columnHeaderText;
            buttonColumn.Text = columnText;
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(buttonColumn);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Authentication.isAdmin)
            {
                Authentication.isAdmin = false;
                Reload();
            }
            else
            {
                LoginGUI loginGUI = new LoginGUI(this);
                loginGUI.Show();
            }
        }

        private void dataGridView_Car_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Check if the clicked column is the detail button column
            if (e.ColumnIndex == dataGridView_Car.Columns["carDetailButton"].Index && e.RowIndex >= 0)
            {
                Car car = (Car)dataGridView_Car.Rows[e.RowIndex].DataBoundItem;

                CarDetailGUI carDetailGUI = new CarDetailGUI(car, "View Details");
                carDetailGUI.Show();
            }
            //If user is admin, Check if the clicked column is the Edit/ Delete button column
            else if (Authentication.isAdmin)
            {
                if (e.ColumnIndex == dataGridView_Car.Columns["carEditButton"].Index && e.RowIndex >= 0)
                {
                    Car car = (Car)dataGridView_Car.Rows[e.RowIndex].DataBoundItem;
                    CarDetailGUI carDetailGUI = new CarDetailGUI(car, "Edit");
                    carDetailGUI.Show();
                    Thread.Sleep(1);
                    Reload();
                }

                if (e.ColumnIndex == dataGridView_Car.Columns["carDeleteButton"].Index && e.RowIndex >= 0)
                {
                    Car car = (Car)dataGridView_Car.Rows[e.RowIndex].DataBoundItem;
                    if (DAOOrder.isCarOrdered(car))
                    {
                        MessageBox.Show("This car has been ordered. Cannot delete!");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            DAOCar.DeleteCar(car);
                            MessageBox.Show("This car is deleted", "", MessageBoxButtons.OK);
                            Thread.Sleep(1);
                            Reload();
                        }
                    }
                }
            }
        }

        public void Reload()
        {
            // Clear DataSource, clear existing columns and rows
            dataGridView_Car.DataSource = null;
            dataGridView_Car.Columns.Clear();
            dataGridView_Car.Rows.Clear();

            List<Car> cars = DAOCar.GetAllCars();
            dataGridView_Car.DataSource = cars;

            //hide CarID column
            dataGridView_Car.Columns[0].Visible = false;

            //display a Detail view button for each row
            AddButton(dataGridView_Car, "carDetailButton", "Car Detail", "View Details");

            //display total number of cars
            label_TotalCar.Text = cars.Count.ToString();

            //if user is admin, display Edit and Delete button for each row
            if (Authentication.isAdmin)
            {
                button_AddCar.Visible = true;
                button_AddCar.Enabled = true;
                loginToolStripMenuItem.Text = "Logout (admin)";
                //display a Detail view button for each row
                AddButton(dataGridView_Car, "carEditButton", "Car Edit", "Edit");
                AddButton(dataGridView_Car, "carDeleteButton", "Car Delete", "Delete");
            }
            else
            {
                button_AddCar.Enabled = false;
                button_AddCar.Visible = false;
                loginToolStripMenuItem.Text = "Login";
            }
        }

        private void button_AddCar_Click(object sender, EventArgs e)
        {
            Car car = new Car(-1, "", "", "");
            CarDetailGUI carDetailGUI = new CarDetailGUI(car, "Add");
            carDetailGUI.Show();
            Thread.Sleep(1);
            Reload();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}