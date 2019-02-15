using System;

namespace TASK2
{

    class Student
    {
        public string name;
        public string id;
        public Student(string n, string i) //constructor 
        {
            name = n;
            id = i;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"name = {name} id = {id}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           // string n;
            //string k;
            Student s = new Student($"Angel", "0000001");
            Console.WriteLine("Enter the year of study:");
            int y = int.Parse(Console.ReadLine());
            s.PrintInfo();
            Console.WriteLine($"Next year of study is: {y + 1}");
        }
    }
}