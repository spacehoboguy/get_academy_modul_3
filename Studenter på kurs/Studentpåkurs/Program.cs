namespace Studentpåkurs
{
    internal class Program
    {
        static void Main()
        {
            Student theodor = new Student("Theodor", 26);
            Student adam = new Student("Adam", 32);
            Student marie = new Student("Marie", 29);


            Course matlaging = new Course("Matlaging");
            Course dansing = new Course("Dansing");
            Course regnskap = new Course("Regnskap");

            CourseList matlagingsKurs = new CourseList(matlaging);
            CourseList danseKurs = new CourseList(dansing);
            CourseList regnskapsKurs = new CourseList(regnskap);

            matlagingsKurs.AddStudentToCourse(theodor);
            danseKurs.AddStudentToCourse(theodor);
            matlagingsKurs.AddStudentToCourse(adam);
            danseKurs.AddStudentToCourse(marie);
            regnskapsKurs.AddStudentToCourse(marie);

            bool isRunning = true;

            

            while (isRunning)
            {
                PrintMenu();
                string? input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Dette er matlaging");
                    
                }
                if (input == "2")
                {
                    Console.WriteLine("Dette er dansing");
                    for (int i = 0; i < danseKurs.length; i++)
                    {
                        
                        Console.WriteLine($"{danseKurs.Students}");
                            Console.WriteLine("Kjørt");
                        
                    }
                }
                if (input == "3")
                {
                    Console.WriteLine("Dette er regnskap");
                }
                else
                {
                    isRunning=false;
                }
            }

            /*Console.WriteLine($"Mitt navn er {theodor.Name}");
            foreach (var course in theodor.Courses)
            {
                Console.WriteLine($"{course.CourseName}");
            }*/

            static void PrintMenu()
            {
                Console.WriteLine("1. Matlaging");
                Console.WriteLine("2. Dansing");
                Console.WriteLine("3. Regnskap");
            }
        }
    }
}