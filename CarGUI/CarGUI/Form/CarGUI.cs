using CarGUI.DAL;
using CarGUI.Model;
using System.Data;
using System.Windows.Forms;

namespace CarGUI
{
    public partial class CarGUI : Form
    {
        public CarGUI()
        {
            InitializeComponent();
            dataGridView_Car.ScrollBars = ScrollBars.Vertical;
        }

        private void CarGUI_Load(object sender, EventArgs e)
        {
            //dataGridView_Car.Rows.Clear();
            List<Car> cars = DAOCar.GetAllCars();
            dataGridView_Car.DataSource = cars;

            //hide CarID column
            dataGridView_Car.Columns[0].Visible = false;

            //display a detail view button for each row
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "carDetailButton";
            buttonColumn.HeaderText = "Car Detail";
            buttonColumn.Text = "View Details";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView_Car.Columns.Add(buttonColumn);

            //display total number of cars
            label_TotalCar.Text = cars.Count.ToString();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginGUI loginGUI = new LoginGUI();
            loginGUI.Show();
        }

        private void dataGridView_Car_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Check if the clicked column is the detail button column
            if (e.ColumnIndex == dataGridView_Car.Columns["carDetailButton"].Index)//&& e.RowIndex >= 0
            {
                string? CarID = dataGridView_Car[0, e.RowIndex].Value.ToString();
                Car? car = DAOCar.GetCar(CarID);
                CarDetailGUI carDetailGUI;
                if (car != null)
                {
                    carDetailGUI = new CarDetailGUI(car);
                    carDetailGUI.Show();
                }
                else
                {
                    label_TotalCar.Text = CarID.ToString();
                    //this.Close();
                }
            }
        }
    }
}