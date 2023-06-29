using ADOApp.DAL;

namespace ADOApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = StudentDao.GetAllStudent();
            dataGridView1.DataSource = StudentDao.GetStudent(Convert.ToInt32(5));
        }
    }
}