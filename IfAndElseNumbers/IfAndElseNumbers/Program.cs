namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //konsoolis sisetame numbri
            //see number salvestatakse string andemetüüpi
            //toimub kontroll, kes sisestatud väärtus on number
            //kasutada if ja else lauseid

            {
                Console.WriteLine("sisesta number");
                string input = Console.ReadLine();
                //kontrollime, kas sisestatud väärtus on number
                if (int.TryParse(input, out int number))
                {
                    Console.WriteLine("sisestasid numbri");
                }
                else
                {
                    Console.WriteLine("ERROR.Numbrid ei sisestatud");
                }






            


































