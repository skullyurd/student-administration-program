///
///     Class:          Student.cs
///     decription:     This class creates and manages information about a student.
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
using System.Reflection;

namespace cSharp_Starter_Assignment
{
    internal class Student
    {
        public string name;
        public int studentNumber;
        public string groupName;
        private string Name { get { return this.name; } set { this.name = value; } }
        private int StudentNumber { get; }

        public Student(string name, string groupName, int studentNumber)
        {
            this.name = name;
            this.studentNumber = studentNumber;
            this.groupName = groupName;
        }

        public Student(string name, int studentNumber, string groupName)
        {
            this.name = name;
            this.studentNumber = studentNumber;
            this.groupName = groupName;
        }

        private string GetInfo()
        {
            return (this.name + " (" + this.studentNumber + ") - " + this.groupName);
        }
    }
}
