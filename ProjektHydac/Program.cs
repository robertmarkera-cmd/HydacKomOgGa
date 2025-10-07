using System;

namespace Hydac123
{
    public class Program
    {
        static void Main()
        {
            GuestLog guestlog = new GuestLog();
            bool kør = true;








            while (kør)
            {
                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine("║        HYDAC GÆSTELOG          ║");
                Console.WriteLine("╠════════════════════════════════╣");
                Console.WriteLine("║ 1. Tilføj ny gæst              ║");
                Console.WriteLine("║ 2. Vis alle gæster             ║");
                Console.WriteLine("║ 3. Rediger afgang              ║");
                Console.WriteLine("╚════════════════════════════════╝");
                Console.Write("Vælg en mulighed (1-3): ");
                string valg = Console.ReadLine();
                Console.Clear();


                switch (valg)
                {
                    case "1":
                        guestlog.AddGuest();
                        Console.Clear();
                        break;


                    case "2":
                        guestlog.ShowGuestlog();
                        Console.WriteLine("\n" + "Tryk på en tilfældig knap for at komme tilbage til menuen");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Write("Indtast navn på gæst der skal redigeres: ");
                        string name = Console.ReadLine();
                        guestlog.EditGuest(name);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                }
            }
        }


    }
}