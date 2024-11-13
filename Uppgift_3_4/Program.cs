using System;
namespace uppgift_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string tboi;
            do
            {
                Console.WriteLine("För att skicka in en låt till CrabRadio måste du ange längd på låt.");
                Console.WriteLine("Börja med att skriva antal hela minuter nedan:");
                int min = int.Parse(Console.ReadLine());
                Console.WriteLine("Skriv nu antal övriga sekunder:");
                int sec = int.Parse(Console.ReadLine());

                if (min >= 4 && sec > 20 || min <= 2 && sec < 45)
                {
                    Console.WriteLine("Denna låte var tyvärr inte giltig för att spela på radion, därmed kommer den inte läggas med i listan.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Vi lägger gärna till denna låt i listan, lyssna noga ifall den spelas! Tack för medverkan.");
                    Console.ReadKey();
                }
                Console.WriteLine("Vill du rekommendera en till låt? (y/n)");
                tboi = Console.ReadLine();
            }
            while (tboi == "Y" || tboi == "y");
        }
    }
}