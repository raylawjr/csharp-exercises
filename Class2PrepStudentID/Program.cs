using System;
using System.Collections.Generic;

namespace Class2PrepStudentID
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;
            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.WriteLine("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    Console.WriteLine("ID: ");
                    int newID = int.Parse(Console.ReadLine());

                    students.Add(newID, newStudent);
                }
            }
            while (newStudent != "");

            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }
            Console.ReadLine();
        }
    }
}
