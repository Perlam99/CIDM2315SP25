namespace Homework9;
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public static List<Student> student_list = new List<Student>();
    private int studentID { get; set; }
    private string studentName { get; set; }
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    
    public string GetName()
    {
        return studentName;
    }

    public int GetID()
    {
        return studentID;
    }
        public Student(int inputID, string inputName)
        {
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
    }

}



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
