using System.Collections;

namespace Studentpåkurs;

public class CourseList
{
    public int length;
    public List<Student> Students { get; set; }
    public Course Course { get; set; }

    public CourseList(Course course)
    {
        Course = course;
        Students = new List<Student>();
    }

    public void AddStudentToCourse(Student studentToAdd)
    {
        Students.Add(studentToAdd);
        studentToAdd.Courses?.Add(Course);
    }
}