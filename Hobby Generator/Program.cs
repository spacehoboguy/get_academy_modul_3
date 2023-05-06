
namespace Hobby_Generator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] hobbies = {"Fishing","Dancing", "Singing", "Playing video-games"};
            Console.WriteLine("Enter name to receive new hobby! : ");
            var person = Console.ReadLine() ?? throw new ArgumentNullException("Console.ReadLine()");
            Console.WriteLine($"Your name is {person}");

                var rand = new Random();
                int randomNumber = rand.Next(hobbies.Length);
                Console.WriteLine($"Dette er randomNumber ->{randomNumber}");
                Console.WriteLine($"{person} has picked up a new hobby! {hobbies[randomNumber]}");
        }
    }
}