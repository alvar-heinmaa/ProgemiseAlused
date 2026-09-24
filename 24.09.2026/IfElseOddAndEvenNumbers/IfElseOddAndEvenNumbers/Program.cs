namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta nr!");
            string sisend = Console.ReadLine();

            if (int.TryParse(sisend, out int nr))
            {
                if (nr % 2 == 0)
                {
                    Console.WriteLine($"number {nr} on Paaris");

                }
                else
                {
                    Console.WriteLine($"number {nr} on Paaritu");
                }

            } 
            //konsool küsib numbrit
            //number tuleb ära parsida

            //if ja else juures toimub kontroll 
            //kas on parris või paaritu nr
        }
    }
}
