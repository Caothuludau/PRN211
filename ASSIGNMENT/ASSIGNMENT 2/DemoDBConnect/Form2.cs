using DemoBDConnect.DAL;
using DemoBDConnect.Model;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.Common;

namespace DemoBDConnect
{
    public partial class Form2 : Form
    {

        private List<RollCallBook> formRollCallBooks = new List<RollCallBook>();
        private List<Student> formStudents = new List<Student>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView_StudentCourse.DataSource = StudentDao.GetAllStudent();

            //Get info for comboBox_Course
            comboBox_Course.DataSource = CourseDao.GetAllCourses();
            comboBox_Course.DisplayMember = "courseCode";
        }

        private void comboBox_CourseDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            CourseSchedule cs = (CourseSchedule)comboBox.SelectedItem;

            //Get info for dataGridView
            List<RollCallBook> rcbs = new List<RollCallBook>();
            foreach (RollCallBook rcb in RollCallBookDao.GetAllRollCallBooks())
            {
                if (rcb.teachingScheduleId == cs.teachingScheduleId)
                {
                    rcbs.Add(rcb);
                }
            }

            //Init the rcb to the form attribute
            formRollCallBooks = rcbs;

            List<Student> students = new List<Student>();
            foreach (Student std in StudentDao.GetAllStudent())
            {
                foreach (RollCallBook rcb in rcbs)
                {
                    if (std.StudentId == rcb.studentId)
                    {
                        students.Add(std);
                        break;
                    }
                }
            }

            dataGridView_StudentCourse.DataSource = students;
            formStudents = students;

            //For each student in the list, add isAbsent attribute
            List<Boolean> isAbsents = students
                .Select(std => rcbs.Any(rcb => std.StudentId == rcb.studentId && rcb.isAbsent))
                .ToList();

            for (int i = 0; i < dataGridView_StudentCourse.Rows.Count; i++)
            {
                // Check if there is a corresponding 'isAbsent' value for the current row
                if (i < isAbsents.Count)
                {
                    // Set the 'isAbsent' value for the current row in the 'IsAbsent' column
                    dataGridView_StudentCourse.Rows[i].Cells["column_IsAbsent"].Value = isAbsents[i];
                }
                else
                {
                    // If there is no corresponding 'isAbsent' value, you can set a default value or leave it blank
                    dataGridView_StudentCourse.Rows[i].Cells["column_IsAbsent"].Value = DBNull.Value;
                }
            }
        }
        private void comboBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            //From comboBox, get courseI
            ComboBox comboBox = (ComboBox)sender;
            Course c = (Course)comboBox.SelectedItem;

            //Get info for comboBox_CourseDate
            List<CourseSchedule> courseSchedules = new List<CourseSchedule>();
            foreach (CourseSchedule cs in CourseScheduleDao.GetAllCourseSchedules())
            {
                if (cs.courseId == c.courseId)
                {
                    courseSchedules.Add(cs);
                }
            }
            comboBox_CourseDate.DataSource = courseSchedules;
            comboBox_CourseDate.DisplayMember = "teachingDate";
            comboBox_CourseDate.FormatString = "dd/MM/yyyy";
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            dataGridView_StudentCourse.EndEdit();

            for (int i = 0; i < dataGridView_StudentCourse.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell cell = dataGridView_StudentCourse.Rows[i].Cells["column_IsAbsent"] as DataGridViewCheckBoxCell;
                bool isAbsent = Convert.ToBoolean(cell.Value);
                RollCallBookDao.UpdateAttendance(isAbsent, formRollCallBooks[i]);
            }
            MessageBox.Show("Attendance Changed Successfully", "Notification", MessageBoxButtons.OK);
            Reload();
        }

        private void Reload()
        {
            //Get info for dataGridView
            List<RollCallBook> rcbs = new List<RollCallBook>();
            foreach (RollCallBook formRcb in formRollCallBooks)
            {
                foreach (RollCallBook rcb in RollCallBookDao.GetAllRollCallBooks())
                {
                    if (formRcb.teachingScheduleId == rcb.teachingScheduleId)
                    {
                        rcbs.Add(rcb);
                    }
                }
            }

            formRollCallBooks = rcbs;

            List<Boolean> isAbsents = formStudents
                .Select(std => rcbs.Any(rcb => std.StudentId == rcb.studentId && rcb.isAbsent))
                .ToList();

            for (int i = 0; i < dataGridView_StudentCourse.Rows.Count; i++)
            {
                // Check if there is a corresponding 'isAbsent' value for the current row
                if (i < isAbsents.Count)
                {
                    // Set the 'isAbsent' value for the current row in the 'IsAbsent' column
                    dataGridView_StudentCourse.Rows[i].Cells["column_IsAbsent"].Value = isAbsents[i];
                }
                else
                {
                    // If there is no corresponding 'isAbsent' value, you can set a default value or leave it blank
                    dataGridView_StudentCourse.Rows[i].Cells["column_IsAbsent"].Value = DBNull.Value;
                }
            }

        }
    }
}
