using System;
using System.Collections.Generic;
using System.Text;

namespace Hlazkova_8
{
    //Информация о студенте может содержать поля, хранящие:
    //имя студента, 
    //название теста, 
    //дату его прохождения 
    //оценку теста для данного студента

    public struct Student
    {
        public String Name;
        public String Test;
        public DateTime DateOfTest;
        public byte Mark;

        public Student(String name, String test, DateTime date, byte mark)
        {
            Name = name;
            Test = test;
            DateOfTest = date;
            Mark = mark;
        }
    }
}
