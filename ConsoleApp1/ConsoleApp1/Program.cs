using System;
using BinaryTreeLibrary;

namespace Hlazkova_8
{
    class Program
    {
        static void Main()
        {
            /* 
            var tree = new BinaryTree();
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(10);
            tree.Insert(30);
            tree.Insert(80);
            tree.Insert(29);
            tree.Insert(31);
            tree.Insert(32);
            tree.Insert(70);
            BinaryTreeExtensions.Print(tree);
            tree.Remove(40);
            BinaryTreeExtensions.Print(tree);
            tree.Remove(20);
            BinaryTreeExtensions.Print(tree);
            */

            /*
                        
                BinTree<int> integerTree = new BinTree<int>();

                Random rand = new Random();

                for (int i = 0; i < 20; i++)
                {
                    int value = rand.Next(100);
                    Console.WriteLine("Adding {0}", value);
                    integerTree.Add(value);
                }

                Console.WriteLine("Number of nodes is {0}", integerTree.Count);
                Console.WriteLine("Max value is {0}", integerTree.MaxValue);
                Console.WriteLine("Min value is {0}", integerTree.MinValue);
                Console.WriteLine("Preorder traversal:");
                Console.WriteLine(string.Join(" ", integerTree.Preorder()));
                Console.WriteLine("Inorder traversal:");
                Console.WriteLine(string.Join(" ", integerTree.Inorder()));
                Console.WriteLine("Postorder traversal:");
                Console.WriteLine(string.Join(" ", integerTree.Postorder()));
                Console.WriteLine("Levelorder traversal:");
                Console.WriteLine(string.Join(" ", integerTree.Levelorder()));
                Console.WriteLine("Default traversal (inorder):");
                foreach (int n in integerTree)
                    Console.Write("{0} ", n);
                Console.WriteLine();
                Console.ReadKey(true);
            */

            BinTree<Student> s = new BinTree<Student>();

            Student Student1 = new Student("Ivanov", "Maths", new DateTime(2011, 6, 10), 3);
            Student Student2 = new Student("Petrov", "Chemistry", new DateTime(2011, 6, 10), 5);
            Student Student3 = new Student("Sidorov", "Literature", new DateTime(2011, 6, 10), 4);
            Student Student4 = new Student("Nikolaev", "Maths", new DateTime(2011, 6, 10), 1);
            Student Student5 = new Student("Demin", "Maths", new DateTime(2011, 6, 10), 2);

            s.Add(Student1);
            s.Add(Student2);
            s.Add(Student3);
            s.Add(Student4);
            s.Add(Student5);

            foreach (Student n in s)
                Console.WriteLine("{0} ", n);
            Console.WriteLine();
            Console.ReadKey(true);

        }
    }
}
