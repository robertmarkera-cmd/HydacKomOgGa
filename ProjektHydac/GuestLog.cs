using System;
using System.Collections.Generic;

namespace Hydac123
{
    public class GuestLog
    {
        static List<GuestLog> guests = new List<GuestLog>();

        public DateTime Date;
        public string Name;
        public string Company;
        public string Responsible;
        public string Departure;
        public string SafetyFolder;
        public string Conferenceroom;

        public GuestLog() { }

        public GuestLog(string name, string company, string responsible, string departure, string conferenceroom, string safetyFolder, DateTime date)
        {
            Name = name;
            Company = company;
            Responsible = responsible;
            Departure = departure;
            Conferenceroom = conferenceroom;
            SafetyFolder = safetyFolder;
            Date = date;
        }

        public void Guestlog()
        {
            Console.WriteLine("\n---Gæst---");
            Console.WriteLine($"Navn: {Name}");
            Console.WriteLine($"Firma: {Company}");
            Console.WriteLine($"Ansvarlig: {Responsible}");
            Console.WriteLine($"Ankomst: {Date:HH:mm}");
            Console.WriteLine($"Afgang: {Departure}");
            Console.WriteLine($"Lokale: {Conferenceroom}");
            Console.WriteLine($"Udleveret sikkerhedsfolder: {SafetyFolder}");
            Console.WriteLine($"Dato: {Date:dd-MM-yyyy}");
        }

        public void AddGuest()
        {
            Console.Write("Navn: ");
            string name = Console.ReadLine();
            Console.Write("Firma: ");
            string company = Console.ReadLine();
            Console.Write("Ansvarlig: ");
            string responsible = Console.ReadLine();
            Console.Write("Afgang: ");
            string departure = Console.ReadLine();
            Console.Write("Lokale: ");
            string conferenceroom = Console.ReadLine();
            Console.Write("Sikkerhedsfolder udleveret (Ja/Nej): ");
            string safetyFolder = Console.ReadLine();
            DateTime date = DateTime.Now;

            GuestLog guest = new GuestLog(name, company, responsible, departure, conferenceroom, safetyFolder, date);
            guests.Add(guest);
        }

        public void ShowGuestlog()
        {
            foreach (var guest in guests)
            {
                guest.Guestlog();
            }
        }

        public void EditGuest(string searchname)
        {
            var guest = guests.Find(g => g.Name == searchname);

            if (guest != null)
            {
                DateTime now = DateTime.Now;
                guest.Departure = now.ToString("HH:mm");
                Console.WriteLine($"Afgang opdateret til: {guest.Departure}");
            }
            else
            {
                Console.WriteLine("Gæst ikke fundet.");
            }

            Console.WriteLine("\nTryk på en tilfældig knap for at komme tilbage til menuen");
        }
    }
}