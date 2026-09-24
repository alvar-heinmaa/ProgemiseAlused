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
                //% jagab muutjuat number 2
                //kui 2 asemele panna 3, siis jagab 3-ga
                if (nr % 2 == 0)
                {
                    Console.WriteLine($"number {nr} on Paaris");
                    //siia tuleb välja kutsuda meetod,
                    //mis ütleb, et see on paarisarv

                }
                else
                {
                    Console.WriteLine($"number {nr} on Paaritu");
                    //siia tuleb välja kutsuda meetod,
                    //mis ütleb, et see on paarituarv
                }
         static void EvenNumberMethod()

                }
                    {
                    
                }
               

            } 
            //konsool küsib numbrit
            //number tuleb ära parsida

            //if ja else juures toimub kontroll 
            //kas on parris või paaritu nr
        }
    }
}
