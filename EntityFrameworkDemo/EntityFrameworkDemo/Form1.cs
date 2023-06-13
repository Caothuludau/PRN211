using EntityFrameworkDemo.Models;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        private CarsContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new CarsContext();
            bindGridView();
        }

        public void bindGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = _context.Cars.ToList();

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Text = "Edit",
                Name = "Edit",
                UseColumnTextForButtonValue = true,
            };
            dataGridView1.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                Text = "Delete",
                Name = "Delete",
                UseColumnTextForButtonValue = true,
            };
            dataGridView1.Columns.Add(btnDelete);
        }
    }
}