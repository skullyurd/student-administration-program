///
///     Class:          student_Administration.cs
///     decription:     In this file the student administration form and all it's UI is created.
/// 
///     Name:           Baris Buba
///     StudentNumber:  4953347
///     date:           19-02-2023
///     
///     Version:        Version 1.0 - Final verstion
///                     All requested features are added and tested.
///                     
///

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp_Starter_Assignment
{
    public partial class StudentAdministrationForm : Form
    {
        Course thisCourse;

        public StudentAdministrationForm()
        {
            InitializeComponent();
        }

        private void StudentAdministrationForm_Load(object sender, EventArgs e)
        {
            groupBoxInformation.Visible = false;
            groupBoxNewStudent.Visible = false;
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            if (textBoxCourseName.Text != "" && String.IsNullOrWhiteSpace(textBoxCourseName.Text) == false && String.IsNullOrEmpty(textBoxCourseName.Text) == false)
            {
                thisCourse = new Course(textBoxCourseName.Text);
                StudentAdministrationForm.ActiveForm.Text = "Student Administration - " + textBoxCourseName.Text;

                groupBoxInformation.Visible = true;
                groupBoxNewStudent.Visible = true;
                groupBoxNewCourse.Visible = false;
            }
            else
            {
                MessageBox.Show("Please enter a course name");
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (textBoxStudentName.Text != "" && String.IsNullOrWhiteSpace(textBoxStudentName.Text) == false && String.IsNullOrEmpty(textBoxStudentName.Text) == false)
            {
                if (textBoxStudentNumber.Text != "" && String.IsNullOrWhiteSpace(textBoxStudentNumber.Text) == false && String.IsNullOrEmpty(textBoxStudentNumber.Text) == false)
                {
                    if (Convert.ToInt32(textBoxStudentNumber.Text) > 0)
                    {
                        if (thisCourse.AddStudent(textBoxStudentName.Text, Convert.ToInt32(textBoxStudentNumber.Text)))
                        {
                            MessageBox.Show("Student added");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a positive studentnumber");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a studentnumber");
                }
            }
            else
            {
                MessageBox.Show("Please enter a student name");
            }
        }

        private void buttonShowAllStudent_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            if (thisCourse.students != null)
            {
                foreach (Student a in thisCourse.students)
                {
                    if (a != null)
                    {
                        listBoxInfo.Items.Add(a.name + " " + a.studentNumber + " " + a.groupName);
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no students in this course");
            }

        }

        private void allGroupsBttn_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();

            foreach (string a in thisCourse.groups)
            {
                listBoxInfo.Items.Add(a);
            }
        }

        private void buttonSearchStudent_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            Student resultStudent;

            if (!int.TryParse(textBoxSearch.Text, out int result))
            {
                MessageBox.Show("Please enter a number");
                return;
            }
            else
            {
                resultStudent = thisCourse.SearchByStudentNumber(Convert.ToInt32(textBoxSearch.Text));
            }

            if (resultStudent != null)
            {
                listBoxInfo.Items.Add(resultStudent.name + " " + resultStudent.studentNumber + " " + resultStudent.groupName);
            }
            else
            {
                MessageBox.Show("Student not found");
            }


        }

        private void buttonSearchGroup_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();

            Student[] groupedStudentResult = new Student[3];
            groupedStudentResult = thisCourse.SearchByGroup(textBoxSearch.Text);

            if (groupedStudentResult != null)
            {
                foreach (Student a in groupedStudentResult)
                {
                    if (a != null)
                    {
                        listBoxInfo.Items.Add(a.name + " " + a.studentNumber + " " + a.groupName);
                    }
                }
            }

            if (listBoxInfo.Items.Count == 0)
            {
                MessageBox.Show("Group not found");
            }

        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            int minus = 0;
            foreach (Student a in thisCourse.students)
            {
               if (a == null)
                {
                    minus++;
                }
            }

            MessageBox.Show("Course name: " + thisCourse.name + ", amount of students: " + (thisCourse.studentCount - minus) + ", amount of groups: " + thisCourse.groupCount);

        }
    }
}