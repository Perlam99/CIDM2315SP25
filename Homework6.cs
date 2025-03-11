namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //Answer Q1 Q2
        Professor Professor1 = new Professor("Alice", "Java", 9000);
        Professor Professor2 = new Professor("Bob", "Math", 8000);

        
        Student Student1 = new Student("Lisa", "Java", 90);
        Student Student2 = new Student("Tom", "Math", 80);

        
        Console.WriteLine($"Professor {Professor1.ProfName} teaches {Professor1.ClassTeach}, and the salary is: {Professor1.GetSalary()}");
        Console.WriteLine($"Professor {Professor2.ProfName} teaches {Professor2.ClassTeach}, and the salary is: {Professor2.GetSalary()}");

        
        Console.WriteLine($"Student {Student1.StudentName} enrolls {Student1.ClassEnroll}, and the grade is: {Student1.GetGrade()}");
        Console.WriteLine($"Student {Student2.StudentName} enrolls {Student2.ClassEnroll}, and the grade is: {Student2.GetGrade()}");

        
        double salaryDifference = Professor1.GetSalary() - Professor2.GetSalary();
        Console.WriteLine($"The salary difference between {Professor1.ProfName} and {Professor2.ProfName} is: {salaryDifference}");

        
        double totalGrade = Student1.GetGrade() + Student2.GetGrade();
        Console.WriteLine($"The total grade of {Student1.StudentName} and {Student2.StudentName} is: {totalGrade}");
    }
}

class Professor
{
    //Code for Professor class
    public string ProfName { get; set; }
    public string ClassTeach { get; set; }
    private double salary;

    public Professor(string name, string classTeach, double salaryAmount)
    {
        ProfName = name;
        ClassTeach = classTeach;
        salary = salaryAmount;
    }

    public void SetSalary(double salaryAmount)
    {
        salary = salaryAmount;
    }

    public double GetSalary()
    {
        return salary;
    }
}

class Student
{
    //Code for Student class
    public string StudentName { get; set; }
    public string ClassEnroll { get; set; }
    private double studentGrade;

    public Student(string name, string classEnroll, double grade)
    {
        StudentName = name;
        ClassEnroll = classEnroll;
        studentGrade = grade;
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}
