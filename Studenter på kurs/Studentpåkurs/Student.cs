namespace Studentpåkurs;

public class Student
{
    public static string Name { get; set; }
    public int Age { get; set; }

    public List<Course>? Courses { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        Courses = new List<Course>();
    }

    public static void DisplayMyName()
    {
        Console.WriteLine($"{Student.Name}");
    }
}