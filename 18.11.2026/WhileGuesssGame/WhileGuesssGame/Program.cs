using System.Reflection.Metadata.Ecma335;

namespace WhileGuesssGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            //numbri arvamise mäng

            Random random = new Random();
            int secretnumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            //tuleb kasutada while, kus öeldakse, kas sinu
            //pakutud nuber oli suurem või väikesm 
            while (guess != secretnumber)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;
                if (guess < secretnumber)
                {
                    Console.WriteLine("Vale! number mida ma mõtlen on suurem kui " + guess + "");
                }
                else if (guess > secretnumber)
                {

                    Console.WriteLine("Vale! number mida ma mõtlen on väiksem kui " + guess + "");
                }
                else if (guess == secretnumber) ;
            }
            Console.WriteLine("Tubli see on õige vastus");
            Console.ReadLine();
        }
    }
}
