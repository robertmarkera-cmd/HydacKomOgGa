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
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("|           HYDAC LOGIN            |");
                Console.WriteLine("|----------------------------------|");
                Console.WriteLine("|  Indtast venligst kodeordet      |");
                Console.WriteLine("|  for at få adgang til systemet.  |");
                Console.WriteLine("+----------------------------------+");
                Console.Write("Kodeord: ");
                string kodeord = Console.ReadLine();
                Console.Clear();

                if (kodeord == "123")
                {
                    while (kør)
                    {
                        Console.WriteLine("+--------------------------+");
                        Console.WriteLine("|      HYDAC GÆSTELOG      |");
                        Console.WriteLine("|--------------------------|");
                        Console.WriteLine("|  1. Tilføj ny gæst       |");
                        Console.WriteLine("|  2. Vis alle gæster      |");
                        Console.WriteLine("|  3. Tjek gæst ud         |");
                        Console.WriteLine("+--------------------------+");
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
                                Console.WriteLine("\nTryk på en tilfældig knap for at komme tilbage til menuen");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "3":
                                Console.Write("Indtast navn på gæst der skal tjekkes ud: ");
                                string name = Console.ReadLine();
                                guestlog.EditGuest(name);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine("Ugyldigt valg. Prøv igen.");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Forkert kodeord :/");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}