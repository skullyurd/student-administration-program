///
///     Class:          Course.cs
///     decription:     This class creates the course, creates and manages project groups and manages student however it is needed.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp_Starter_Assignment
{
    internal class Course
    {
        public List<string> groups = new List<string>();

        public string name { get; set; }
        public Student[] students { get; set; }
        public int studentCount { get { return students.Count(); } } // test it before submission
        public int groupCount { get { return groups.Count; } }

        public Course(string name)
        {
            this.name = name;
            groups.Add("PG1_" + name);
        }


        public bool AddStudent(string name, int studentNumber)
        {
            if (students != null)
            {
                foreach (Student a in students)
                {
                    if (a == null)
                    {
                        break;
                    }
                    else if (a.studentNumber == studentNumber)
                    {
                        MessageBox.Show("This studentnumber is already in use. Please select another number.");
                        return false;
                    }
                    
                }
            }

            if (students != null)
            {
                int counter = 3;
                foreach (Student a in students)
                {
                    if (a == null)
                    {
                        break;
                    }
                    else if (a.groupName == "PG" + groupCount.ToString() + "_" + this.name)
                    {
                        counter--;

                        if (counter == 0)
                        {
                            groups.Add("PG" + (groupCount + 1).ToString() + "_" + this.name);
                            break;
                        }
                    }
                }
            }

            Student newStudent = new Student(name, studentNumber, "PG" + groupCount.ToString() + "_" + this.name);
            
            if (students == null)
            {
                students = new Student[400];
                students[0] = newStudent;
            }
            else
            {
                int occupiedSlots = 0;
                foreach (Student a in students)
                {
                    if (a != null)
                    {
                        occupiedSlots++;
                    }
                    else
                    {
                        break;
                    }
                }
                students[occupiedSlots] = newStudent;
            }
            return true;

        }

        public Student SearchByStudentNumber(int query)
        {

            if(students != null)
            {
                foreach (Student a in students)
                {
                    if (a != null)
                    {
                        if (a.studentNumber == query)
                        {
                            return a;
                        }
                    }
                }
            }
            return null;
        }
        
        public Student[] SearchByGroup(string query)
        {

            Student[] groupedStudents = new Student[3];

            if (students != null)
            {
                foreach (Student a in students)
                {
                    if (a != null)
                    {
                        if (a.groupName == query)
                        {
                            int counter = 0;
                            foreach (Student b in groupedStudents)
                            {
                                if (b == null)
                                {
                                    groupedStudents[counter] = a;
                                }
                                else
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            return groupedStudents;
        }

    }
}
