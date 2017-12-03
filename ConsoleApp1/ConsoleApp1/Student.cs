using System;
using System.Collections.Generic;
using System.Text;

namespace Hlazkova_8
{ 
    public struct Student : IComparable<Student>
    {
        public String Name; //name of Student
        public String Test; //Test name
        public DateTime DateOfTest; //Test date 
        public byte Mark; //Mark for test

        public Student(String name, String test, DateTime date, byte mark)
        {
            Name = name;
            Test = test;
            DateOfTest = date;
            Mark = mark;
        }

        // To compare structure items by Mark
        public int CompareTo(Student other)
        {
            return Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            String str = Name + " " + Test + " [" + DateOfTest.Date.ToString("d") + "] Mark = " + Mark;
            return str;
        }
    }
}
