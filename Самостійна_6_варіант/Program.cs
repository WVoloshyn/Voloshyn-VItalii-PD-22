using System;
namespace voloshyn
{
    class Program
    {
        static void Main(string[] args)
        {
            Vodka myxioami = new xioami();
            int choice;
            do
            {
                Console.WriteLine();
                if (myxioami.nap.Count == 0)
                {
                    Console.WriteLine("[1] - add a new smartphones");
                    Console.WriteLine("[0] - i don't have money enough");
                }
                else
                {
                    Console.WriteLine("[1] - add a new smartphones");
                    Console.WriteLine("[2] - show all smartphones");
                    Console.WriteLine("[3] - find smartphones by one characteristic");
                    Console.WriteLine("[0] - i don't have money enough");
                }
                Console.Write("Chose an option:");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Enter a correct option: ");
                }
                switch (choice)
                {
                    case 1:
                        myxioami.AddNewsmartphones();
                        Console.WriteLine("smartphones was added");
                        Console.WriteLine(myxioami.nap.Count);
                        break;
                    case 2:
                        myxioami.DisplayAllsmartphones();
                        break;
                    case 3:
                        Console.WriteLine("Okay, which characteristic would you like to find?");
                        char characteristic;
                        Console.WriteLine("[e] - camera");
                        Console.WriteLine("[m] - Country_made");
                        Console.WriteLine("[c] - Cost");
                        Console.WriteLine("[v] - display");
                        characteristic = Convert.ToChar(Console.ReadLine());
                        myxioami.SearchByOneCharacteristic(characteristic);
                        break;
                    case 0:
                        Console.WriteLine( OK, it is your choice. Have a nice day!");
                        return;
                    default:
                        Console.WriteLine("INCORRECT OPTION!");
                        break;
                }
            } while (choice != 0);
        }
    }
}
