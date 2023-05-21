using System.Security.Cryptography.X509Certificates;

namespace Kodetime_med_terje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var tiere = new Pengebox
            //{
            //    Value = 10,
            //    Count = 10
            //};
            int NoOfCharacters = CountCharacters("Jeg er en string.", 'e');
            Console.WriteLine(NoOfCharacters);
        }

        static int CountCharacters(string inputString, char inputChar)
        {
            
            int count = 0;
            foreach (var c in inputString)
            {
                if (c == inputChar)
                {
                    count++;
                }
            }
            return count;
        }
    }
}