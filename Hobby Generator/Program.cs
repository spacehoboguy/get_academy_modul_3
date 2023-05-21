
string[] hobbies = {"Fishing","Daencing", "Singing", "Playing video-games"};
Console.WriteLine("Enter name to receive new hobby! : ");
var person = Console.ReadLine() ?? throw new ArgumentNullException($"{nameof(Console)}.ReadLine()");
Console.WriteLine($"Your name is {person}");

var rand = new Random();
int randomNumber = rand.Next(hobbies.Length);

Console.WriteLine($"{person} has picked up a new hobby! {hobbies[randomNumber]}");