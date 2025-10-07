using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac123
{

    public class GuestLog
    {
        static List<GuestLog> guests = new List<GuestLog>(); //List laver en liste hvor du kan tilføje og fjerne elementer

        private DateTime date; //DateTime er en datatype til at gemme dato og tid
        private string name;
        private string company;
        private string responsible;
        private string departure;
        private string safteyfolder;
        private string conferenceroom;

        


        public void GuestInformation()
        {

            Console.Write("Navn: ");
            name = Console.ReadLine();

            Console.Write("Firma: ");
            company = Console.ReadLine();

            Console.Write("Ansvarlig: ");
            responsible = Console.ReadLine();

            Console.Write("Afgang: ");
            departure = Console.ReadLine();

            Console.Write("Lokale: ");
            conferenceroom = Console.ReadLine();

            Console.Write("Udleveret sikkerhedsfolder: ");
            safteyfolder = Console.ReadLine();

            date = DateTime.Now;

        }

        public void Guestlog()
        {

            Console.WriteLine("\n---Gæst---");
            Console.WriteLine($"Navn: {name}");
            Console.WriteLine($"Firma: {company}");
            Console.WriteLine($"Ansvarlig: {responsible}");
            Console.WriteLine($"Ankomst: {date:HH:mm}");
            Console.WriteLine($"Afgang: {departure}");
            Console.WriteLine($"Lokale: {conferenceroom}");
            Console.WriteLine($"Udleveret sikkerhedsfolder: {safteyfolder}");
            Console.WriteLine($"Dato: {date:dd-MM-yyyy}");

        }
        public void AddGuest()
        {
            GuestLog guest = new GuestLog(); // opretter et nyt objekt i klassen (GuestLog) og laver en ny kopi af klassen
            guest.GuestInformation(); // gæst er her brugt til at kalde på en metode
            guests.Add(guest);
        }

        public void ShowGuestlog()
        {
            foreach (var guest in guests)
            {
                guest.Guestlog();
            }
        }
        public void EditGuest (string searchname)
        {
            date = DateTime.Now;
            var guest = guests.Find(g => g.name == searchname);

            if (guest != null)
            {
                Console.WriteLine($"Afgang opdateret til: {date:HH:mm}");
                guest.departure = ($"{date:HH:mm}");
                Console.WriteLine("\n" + "Tryk på en tilfældig knap for at komme tilbage til menuen");
            }
            else
            {
                Console.WriteLine("Gæst ikke fundet.");
                Console.WriteLine("\n" + "Tryk på en tilfældig knap for at komme tilbage til menuen");
            }
        }

    }
}











//Tilføj GemTilFil og Gæst søgning