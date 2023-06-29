using DemoBDConnect.DAL;
using DemoBDConnect.Model;
using Lab2.DAL;
using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Web;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load info DataGridView
            dataGridView1.DataSource = StudentDao.GetAllStudents();

            //Load info Majors combo box and in table
            comboBox_Major.DataSource = MajorDao.GetAllMajors();
            comboBox_Major.DisplayMember = "MajorTitle";

            comboBox_MajorInTable.DataSource = MajorDao.GetAllMajors();
            comboBox_MajorInTable.DisplayMember = "MajorTitle";

            //Load info Scholarships list box
            List<float> scholarshipTypes = new List<float> { 0.0f, 30.0f, 50.0f, 80.0f, 100.0f };
            foreach (float value in scholarshipTypes)
            {
                listBox_Scholarship.Items.Add(value);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Make sure a valid row index is selected
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // Assuming your ID column is at index 0, change it accordingly if needed
                textBox_ID.Text = selectedRow.Cells[0].Value.ToString();
                textBox_Name.Text = selectedRow.Cells[1].Value.ToString();
                string gender = selectedRow.Cells[2].Value.ToString();
                if (gender.Equals("Female"))
                {
                    radioButton_Female.Checked = true;
                    radioButton_Male.Checked = false;
                }
                else
                {
                    radioButton_Male.Checked = true;
                    radioButton_Female.Checked = false;
                }
                dateTimePicker_DOB.Value = Convert.ToDateTime(selectedRow.Cells[3].Value);

                //
                List<Major> majors = MajorDao.GetAllMajors();
                Major choosenMajor = null;
                foreach (Major major in majors)
                {
                    //MessageBox.Show(major.MajorCode);
                    if (major.MajorCode.Equals(selectedRow.Cells[4].Value.ToString()))
                    {
                        choosenMajor = major;
                        //Can choose right. MessageBox.Show(choosenMajor.MajorTitle.ToString());
                    }
                }

                for (int i = 0; i < comboBox_MajorInTable.Items.Count; i++)
                {
                    Major currentMajor = (Major)comboBox_MajorInTable.Items[i];
                    if (choosenMajor != null && currentMajor.MajorCode.Equals(choosenMajor.MajorCode))
                    {
                        comboBox_MajorInTable.SelectedIndex = i;
                    }
                }



                // Fetch the student's scholarship value
                float studentScholarship = Convert.ToSingle(selectedRow.Cells[5].Value);

                // Find the index of the matching scholarship value in listBox_Scholarship
                int scholarshipIndex = -1;
                for (int i = 0; i < listBox_Scholarship.Items.Count; i++)
                {
                    float listItem = Convert.ToSingle(listBox_Scholarship.Items[i]);
                    if (studentScholarship == listItem)
                    {
                        scholarshipIndex = i;
                        break;
                    }
                }

                // Set the selected index in listBox_Scholarship
                if (scholarshipIndex >= 0)
                {
                    listBox_Scholarship.SelectedIndex = scholarshipIndex;
                }

                if (Convert.ToBoolean(selectedRow.Cells[6].Value))
                {
                    checkBox_Active.Checked = true;
                }
                else
                {
                    checkBox_Active.Checked = false;
                }
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            //Ma thuat hac am
            Thread.Sleep(1);
            Form1_Load(null, null);

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text != null && textBox_Name.Text != null || comboBox_Major.Text != null || listBox_Scholarship.Text != null )
            {
                string id = textBox_ID.Text;
                string name = textBox_Name.Text;
                string gender;
                if (radioButton_Male.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                DateTime dob = dateTimePicker_DOB.Value;
                string major = ((Major)comboBox_MajorInTable.SelectedItem).MajorCode;
                float scholarship = (float)listBox_Scholarship.SelectedItem;
                bool active = checkBox_Active.Checked;
                Student std = new Student(id, name, gender, dob, major, scholarship, active);

                if (MessageBox.Show("Do you really want to update this student?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StudentDao.UpdateStudent(std);
                    MessageBox.Show("Student " + id + "update successfully");
                }

            }

            Form1_Load(null, null);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            //get studentId from text box and Delete in database
            if (textBox_ID.Text != null)
            {
                if (MessageBox.Show("Do you really want to delete student " + textBox_ID.Text,
                    "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StudentDao.DeleteStudent(textBox_ID.Text);

                }
            }
            Form1_Load(null, null);
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            textBox_ID.Clear();
            textBox_Name.Clear();
            radioButton_Female.Checked = false;
            radioButton_Male.Checked = false;

            dateTimePicker_DOB.Value = DateTime.Now;
            comboBox_MajorInTable.Text = "";
            listBox_Scholarship.SelectedIndex = -1;
            checkBox_Active.Checked = false;
        }

        private void comboBox_Major_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Major major = (Major)comboBox.SelectedItem;

            List<Student> students = StudentDao.GetStudentByMajor(major);
            dataGridView1.DataSource = students;

        }
    }
}