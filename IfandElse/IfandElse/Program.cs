namespace IfandElse
{
    internal class Program
    {
        //projekt nimetusega IfandElse, mille sees asub class nimega program. 
        //See klass sisaldab Main meetodit,
        //mis on programmi sisenemispunkt. 
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta enda nimi");

            //muutuja nimega name, kuhu salvestatakse kasutaja
            //sisestatud tekst
            string name = Console.ReadLine();

            //! tähendab "ei ole" ja == tähendab "on võrdne"
            if (name != "")
            {
                //Kui kasutaja sisestab midagi, siis muudetakse taustavärv
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine( "Sisestasid enda nime");
                Console.WriteLine(name);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ERROR.Nime ei sisestanud");
                //Kui kasutaja ei sisesta midagi, siis kostub 2 piiksu
                Console.Beep();
                // ja oodatakse 1 sekund enne programm lõppu
                Thread.Sleep(1000);
                Console.Beep();
                
            }

       }
             
    }
                 
}
