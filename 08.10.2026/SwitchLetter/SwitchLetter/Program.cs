namespace SwitchLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meedoti valimine");
            //Tee kolm meétodit, mis teevad järgmist:
            //esimene ütleb auh
            //teine ütleb tahan magada
            //kolmas ütleb  tahan õppida
            //need tuleb esile kutsuda numbri valikuga
            //tuleb kasutada switchi 
            //tuleb teha menüü, kus kasutaja saab valida,
            //millist meetodit ta tahab esile kutsuda
            Console.WriteLine("Tee valik");
            Console.WriteLine("1. Auh");
            Console.WriteLine("2. Tahan magada");
            Console.WriteLine("3. Tahan õppida");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Auh();
                    break;
                case 2:
                    Sleep();
                    break;
                case 3:
                    Study();
                    break;
                default:
                    Console.WriteLine("Vale valik");
                    break;

            }
        }

        static void Auh()
        {
            Console.WriteLine("Auh");
        }
        static void Sleep()
        {
            Console.WriteLine("Tahan magada");
        }
        static void Study()
        {
            Console.WriteLine("Tahan õppida");
        }
    }
}

