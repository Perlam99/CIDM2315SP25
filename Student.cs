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