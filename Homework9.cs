namespace Homework9;
using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8}
        };

        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
    
        }

        double avgGPA = gradebook.Values.Average();
        Console.WriteLine($"The average GPA is: {avgGPA:F2}");

        foreach (Student stu in Student.student_list)
        {
            string name = stu.GetName();
            if (gradebook.ContainsKey(name) && gradebook[name] > avgGPA)
            {
                stu.PrintInfo();
            }
        }
    }
}      