using System;
using System.Collections.Generic;
namespace voloshyn
{
    class xioami
    {
        public List<Napoi> nap = new List<smartphones>();

        public void AddNewsmartphones()
        {
            string camera;
            string Country_made;
            int Cost;
            int display;
            Console.Write("\nEnter a camera of smartphones: ");
            Excerpt = Console.ReadLine();
            Console.Write("Enter a country made of smartphones: ");
            Country_made = Console.ReadLine();
            Console.Write("Enter a smartphones price: ");
            while (!int.TryParse(Console.ReadLine(), out Cost) || Cost <= 0)
            {
                Console.Write("Enter a correct speed value, please: ");
            }
            Console.Write("Enter a display size of smartphones: ");
            while (!int.TryParse(Console.ReadLine(), out size) || size > 10 || size < 0)
            {
                Console.Write("Enter a correct size, please: ");
            }
            smartphones newsmartphones = new smartphones(camera, Country_made, Cost, display);
            nap.Add(newsmartphones);
        }
        public void DisplayAllsmartphones()
        {
            int i = 1;
            foreach (smartphones c in nap)
            {
                DisplayInfoAboutsmartphones(c);
                i++;
            }
        }
        public void SearchByOneCharacteristic(char characteristic)
        {
            int i = 0;
            switch (characteristic)
            {
                case 'n':
                    Console.Write("What camera would you like to find: ");
                    string camera = Console.ReadLine();

                    foreach (smartphones c in nap)
                    {
                        if (c.camera == camera)
                        {
                            DisplayInfoAboutsmartphones(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Sorry, no matches found.");
                    i = 0;
                    break;

                case 'c':
                    Console.Write("What country_made would you like to find: ");
                    string country_name = Console.ReadLine();
                    foreach (smartphones c in nap)
                    {
                        if (c.Country_made == country_name)
                        {
                            DisplayInfoAboutsmartphones(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Sorry, no matches found.");
                    i = 0;
                    break;

                case 's':
                    Console.Write("Which cost would you like to find: ");
                    int cost = Convert.ToInt32(Console.ReadLine());
                    foreach (smartphones c in nap)
                    {
                        if (c.Cost == cost)
                        {
                            DisplayInfoAboutsmartphones(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Sorry, no matches found.");
                    i = 0;
                    break;

                case 'y':
                    Console.Write("What name would you like to find: ");
                    int display = Convert.ToInt32(Console.ReadLine());
                    foreach (smartphones c in nap)
                    {
                        if (c.display == display)
                        {
                            DisplayInfoAboutsmartphones(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Sorry, no matches found.");
                    i = 0;
                    break;

                default:
                    Console.WriteLine("Sorry, no such characteristic.");
                    break;
            }

        }

        public void DisplayInfoAboutsmartphones(smartphones smartphones)
        {
            Console.WriteLine("\ncamera  : {0}\nCountry_made  : {1}\nCost  : {2}\ndispaly  : {3}", smartphones.camera, smartphones.Country_made, smartphones.Cost, smartphones.display);
        }
    }
}