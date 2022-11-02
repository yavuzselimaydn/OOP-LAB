using week3_lab;

internal class Program
{
    private static void Main(string[] args)
    {
        Student std = new Student(5, "Ahmet", "Bahadır");
        List<Student> students = new List<Student>()
        {
            new Student(0, "Murat", "Efendioğlu"),
            new Student(1, "Yavuz", "aydın"),
            new Student(2, "Abdullah", "Efendioğlu"),
            new Student(3, "Murat", "Efendioğlu"),
            new Student(4, "Murat", "Efendioğlu")
        };

        StudentManager studentManager = new StudentManager(students);
        studentManager.ReadAll();
        Console.WriteLine("------------------");
        studentManager.CreateStudents(std);
        studentManager.ReadAll();
        Console.WriteLine("--------------------");
        studentManager.StudentDelete(4);
        studentManager.UpdateStudent(1, null, "Veli");
        studentManager.ReadAll();
    }
}