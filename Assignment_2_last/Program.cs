using Assignment_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //Student[] s = new Student[5];

            //s[0] = new Student() { StudentId = 1, StudentName = "Alice", Marks = new int[] { 85, 90, 78, 92 } };
            //s[1] = new Student() { StudentId = 2, StudentName = "Bob", Marks = new int[] { 65, 70, 72, 68 } };
            //s[2] = new Student() { StudentId = 3, StudentName = "Charlie", Marks = new int[] { 45, 50, 52, 48 } };
            //s[3] = new Student() { StudentId = 4, StudentName = "David", Marks = new int[] { 88, 82, 84, 86 } };
            //s[4] = new Student() { StudentId = 5, StudentName = "Eve", Marks = new int[] { 55, 58, 60, 62 } };




            ////for(int i=0;i<5;i++)
            ////{
            ////    s[i] = new Student();
            ////    Console.WriteLine("Enter Student ID:");
            ////    s[i].StudentId = Convert.ToInt32(Console.ReadLine());
            ////    Console.WriteLine("Enter Student Name:");
            ////    s[i].StudentName = Console.ReadLine();
            ////    Console.WriteLine("Enter 4 Marks:");
            ////    for(int j=0;j<4;j++)
            ////    {
            ////        s[i].Marks[j] = Convert.ToInt32(Console.ReadLine 
            ////    }
            ////}



            //foreach (var student in s)
            //{
            //    student.GetDetails();
            //}

            //Student st = new Student();
            //st.getbyId(s, 3);

            //st.GetFirstClassDet(s);

            //st.GetByChar(s, 'A');


            DerivedCls obj = new DerivedCls(10);

            //// Example usage of polymorphism
            //Shape circle = new Circle(5);
            //Shape rectangle = new Rectangle(4, 6);
            //Shape triangle = new Triangle(3, 7);

            //Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            //Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            //Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
        }
    }
    }
