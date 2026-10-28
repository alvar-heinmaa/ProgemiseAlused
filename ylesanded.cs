using System;

class Program
{
    static void Main()
    {
        // 1. Küsi kaks arvu ja lahuta
        Console.Write("Sisesta esimene arv: ");
        int arv1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Sisesta teine arv: ");
        int arv2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Vastus: " + (arv1 - arv2));

        // 2. Kuvab teksti
        Tervitus();

        // 3. Küsi lemmiktoitu
        Console.Write("Mis on sinu lemmiktoit? ");
        string toit = Console.ReadLine();

        Console.WriteLine("Sinu lemmiktoit on " + toit);
    }

    static void Tervitus()
    {
        Console.WriteLine("Tere tulemast!");
    }
}
