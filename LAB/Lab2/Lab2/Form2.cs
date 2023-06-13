using DemoBDConnect.DAL;
using DemoBDConnect.Model;
using Lab2.DAL;
using Lab2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Load info Majors combo box and in table
            comboBox_MajorInTable.DataSource = MajorDao.GetAllMajors();
            comboBox_MajorInTable.DisplayMember = "MajorTitle";

            //Load info Scholarships list box
            List<float> scholarshipTypes = new List<float> { 30.0f, 50.0f, 80.0f, 100.0f };
            foreach (float value in scholarshipTypes)
            {
                listBox_Scholarship.Items.Add(value);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text != null && textBox_Name != null && (radioButton_Female.Checked || radioButton_Male.Checked)
                 && comboBox_MajorInTable.SelectedItem != null && listBox_Scholarship.SelectedItem != null)
            {
                string studentId = textBox_ID.Text;
                string name = textBox_Name.Text;
                string gender = "";
                if (radioButton_Female.Checked)
                {
                    gender = "Female";
                }
                else if (radioButton_Male.Checked)
                {
                    gender = "Male";
                }
                DateTime dob = dateTimePicker_DOB.Value;
                string major = ((Major)comboBox_MajorInTable.SelectedItem).MajorCode;
                float scholarship = (float)listBox_Scholarship.SelectedItem;
                bool isActive = checkBox_Active.Checked;

                Student studentToInsert = new Student(studentId, name, gender, dob, major, scholarship, isActive);

                if (MessageBox.Show("Do you really want to insert student " + textBox_ID.Text,
                    "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StudentDao.AddStudent(studentToInsert);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Add failed");
            }
        }
    }
}
