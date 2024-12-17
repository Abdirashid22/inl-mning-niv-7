using System;

class Program
{
    static void Main()
    {
        

        Console.WriteLine("Mata in positiva tal. Avsluta genom att mata in ett negativt tal.");
        int tal;
        
        while (true)
        {
            Console.Write("Ange ett tal: ");
            tal = int.Parse(Console.ReadLine());

            if (tal < 0)
            {
                
                break;
            }
        }

        Console.WriteLine("Du matade in ett negativt tal. Programmet avslutas.");
    }
}
