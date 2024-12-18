using System;

namespace GIK299_Labb1_Grupp62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Den berättar flygtider och tidskillnaden mellan New York och Stockholm
            int flightHours = 7;
            int flightMinutes = 25;
            int timeDifference = 6;

            // Den berättar avgångstider New York till Stockholm och från Stockholm till New York
            int departureNYHours = 10;
            int departureNYMinutes = 10;
            int departureSthlmHours = 14;
            int departureSthlmMinutes = 3;


            // Den berättar flygtider och tidskillnaden mellan New York och Stockholm
            int number = flightHours + timeDifference;

            // Här skriver vi ut informationen
            Console.WriteLine($"********************************************\n");
            Console.WriteLine($"Välkommen till flygtidsberäknaren!\n");
            Console.WriteLine("Vilket flyg vill du se information om? (svara med siffra):");
            Console.WriteLine("1. Från New York till Stockholm");
            Console.WriteLine("2. Från Stockholm till New York");
            Console.WriteLine($"3. Avsluta programmet\n");
            Console.WriteLine("Skriv in ditt val här: ");

            // Här läser vi in användarens val
            string choice = Console.ReadLine();
            int choiceInt;

            // Här kollar vi om användaren har skrivit in ett giltigt nummer
            if (int.TryParse(choice, out choiceInt))
            {
                // Detta får använndaren om de skriver in 1
                if (choiceInt == 1)
                {
                    // Här räknar vi ut ankomsttiden
                    int arrivalHours = departureNYHours + flightHours + timeDifference;
                    int arrivalMinutes = departureNYMinutes + flightMinutes;

                    // Justerar timmar och minuter om minuter är mer än 60
                    if (arrivalMinutes >= 60)
                    {
                        arrivalHours = (arrivalHours + 1) % 24;
                        arrivalMinutes -= 60;
                    }
                    // Här skriver vi ut informationen
                    Console.WriteLine($"********************************************\n");
                    Console.WriteLine($"Avgångstid från New York kl {departureNYHours:00} : {departureNYMinutes:00}.");
                    Console.WriteLine($"Anskomstid till Stockholm kl {arrivalHours:00} : {arrivalMinutes:00}. \n");
                    Console.WriteLine("********************************************");
                }
                // Detta får använndaren om de skriver in 2
                else if (choiceInt == 2)
                {
                    // Här räknar vi ut ankomsttiden
                    int arrivalHours = departureSthlmHours + flightHours - timeDifference;
                    int arrivalMinutes = departureSthlmMinutes + flightMinutes;
                    if (arrivalMinutes >= 60)
                    {
                        // Justerar timmar och minuter om minuter är mer än 60
                        arrivalHours = (arrivalHours + 1) % 24;
                        arrivalMinutes -= 60;
                    }
                    // Här skriver vi ut informationen
                    Console.WriteLine($"********************************************\n");
                    Console.WriteLine($"Avgångstid från Stockholm kl {departureSthlmHours:00} : {departureSthlmMinutes:00}.");
                    Console.WriteLine($"Anskomstid till New York kl {arrivalHours:00} : {arrivalMinutes:00}.\n");
                    Console.WriteLine("********************************************");
                }
                // Detta får använndaren om de skriver in 3
                else if (choiceInt == 3)
                {
                    // Här avslutas programmet
                    Console.WriteLine("Programmet avslutas");
                    Environment.Exit(0);
                }
                // Detta får använndaren om de skriver in något annat
                else
                {
                    Console.WriteLine("Förlåt detta har vi inga information om");
                }
                Console.WriteLine("Programmet avslutas");
                Console.ReadKey();
            }


        }
    }
}