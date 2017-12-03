using System;
using BinaryTreeLibrary;
using System.Collections.Generic;
using System.Collections;

namespace Hlazkova_8
{
    class Program
    {
        static void Main()
        {  
            // Collection List is an input for Binary Tree
            Student Student1 = new Student("Ivanov", "Maths", new DateTime(2011, 6, 10), 3);
            Student Student2 = new Student("Petrov", "Chemistry", new DateTime(2011, 6, 10), 5);
            Student Student3 = new Student("Sidorov", "Literature", new DateTime(2011, 6, 10), 4);
            Student Student4 = new Student("Nikolaev", "Maths", new DateTime(2011, 6, 10), 1);
            Student Student5 = new Student("Demin", "Maths", new DateTime(2011, 6, 10), 2);

            List<Student> StudentList = new List<Student>
            {
                Student1,
                Student2,
                Student3,
                Student4,
                Student5
            };

            BinTree<Student> s = new BinTree<Student>(StudentList);

            foreach (Student n in s)
                Console.WriteLine("{0} ", n);
            Console.WriteLine();

            // Several Stusent structures are inputs values for Binary Tree
            BinTree<Student> StudentTree = new BinTree<Student>
            {
                new Student("Ivanov", "Maths", new DateTime(2011, 6, 10), 3),
                new Student("Petrov", "Chemistry", new DateTime(2011, 6, 10), 5),
                new Student("Sidorov", "Literature", new DateTime(2011, 6, 10), 4),
                new Student("Nikolaev", "Maths", new DateTime(2011, 6, 10), 1),
                new Student("Demin", "Maths", new DateTime(2011, 6, 10), 2)
            };

            foreach (Student n in StudentTree)
                Console.WriteLine("{0} ", n);
            Console.WriteLine();

            // Data of primitive type is an input for Binary Tree
            BinTree<int> IntTree = new BinTree<int>
            {
                76,
                6,
                7,
                7,
                54,
                -5
            };

            foreach (int n in IntTree)
                Console.WriteLine("{0} ", n);
            Console.WriteLine();

        }           
        
    }
}
