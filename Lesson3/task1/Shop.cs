using System.Linq;
using System.Text;
using Les3pr1.Classes.Details;
using Les3pr1;
using System;

namespace Les3pr1.Classes;

class Shop
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Computer computer = new Computer();
        DetailsStock stock = new DetailsStock();
        decimal budget = 999999;
        decimal startPrice = 0;
        decimal endPrice = budget;
        string menu = "Menu" + "\n 1) Enter budget" + "\n 2) Check basket" +
                      "\n 3) Display details" + "\n 4) Add detail" + "\n 5) Remove detail" +
                      "\n 6) Build your configurationBuild PC" + "\n " + "\n menu) Menu" + "\n exit) Exit";
        Console.WriteLine(menu + "\n");

        string input;
        while (true)
        {
            string updatedMenu = "Menu" +
                                 $"\n 1) Enter budget ({budget})" + "\n 2) Check basket" +
                                 "\n 3) Display details" + "\n 4) Add detail" +
                                 "\n 5) Remove detail" + "\n 6) Build your configuration" + "\n " +
                                 "\n menu) Menu" + "\n exit) Exit";
            Console.Write(">");
            input = Console.ReadLine().ToLower();

            string detileType, detileName, result;
            switch (input)
            {
                case "1":
                    Console.Write(">Enter your budget: ");
                    budget = Convert.ToDecimal(Console.ReadLine());
                    break;
                case "2":
                    OutBasket();
                    break;
                case "3":
                    OutDetailsStock(startPrice, endPrice);
                    break;
                case "4":
                    Console.Write("Enter detile category(gpu/cpu/..): ");
                    detileType = Console.ReadLine().ToLower();
                    Console.Write("Enter detile name: ");
                    detileName = Console.ReadLine().ToLower();

                    result = computer.AddElement(detileType, detileName, stock);
                    Console.WriteLine(result == null ? "" : $">>{result}");
                    break;
                case "5":
                    Console.Write("Enter detile category(gpu/cpu/..): ");
                    detileType = Console.ReadLine().ToLower();
                    Console.Write("Enter detile name: ");
                    detileName = Console.ReadLine().ToLower();

                    result = computer.RemoveDetail(detileType, detileName);
                    Console.WriteLine(result == null ? "" : $">>{result}");
                    break;
                case "6":
                    result = computer.Build(budget);
                    Console.WriteLine(result);
                    break;
                case "menu":
                    Console.WriteLine(updatedMenu);
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid command, please try again.");
                    break;
            }
        }


        void OutBasket()
        {
            var details = computer.GetDetails();
            Console.WriteLine("Basket:");
            foreach (KeyValuePair<string, object> entry in details)
            {
                Console.WriteLine($"{entry.Key.ToUpper()}:");

                if (entry.Value is Motherboard mboard)
                {
                    Console.WriteLine($"- {mboard.GetInfo()}");
                }
                else if (entry.Value is List<Detail> detailsList)
                {
                    foreach (var detail in detailsList)
                    {
                        Console.WriteLine($"- {detail.Name}");
                    }
                }
            }
        }

        void OutDetailsStock(decimal startPrice, decimal endPrice)
        {
            Console.WriteLine("Details:");

            Console.WriteLine("Motherboards:");
            foreach (var mboard in stock.Motherboards.Where(x => x.Price >= startPrice && x.Price <= endPrice)
                         .OrderBy(x => x.Price).ToList())
            {
                Console.WriteLine($"- {mboard.GetInfo()}");
            }

            Console.WriteLine("\nRAMs:");
            foreach (var ram in stock.Rams.Where(x => x.Price >= startPrice && x.Price <= endPrice)
                         .OrderBy(x => x.Price).ToList())
            {
                Console.WriteLine($"- {ram.GetInfo()}");
            }

            Console.WriteLine("\nCPUs:");
            foreach (var cpu in stock.Cpus.Where(x => x.Price >= startPrice && x.Price <= endPrice)
                         .OrderBy(x => x.Price).ToList())
            {
                Console.WriteLine($"- {cpu.GetInfo()}");
            }

            Console.WriteLine("\nGPUs:");
            foreach (var gpu in stock.Gpus.Where(x => x.Price >= startPrice && x.Price <= endPrice)
                         .OrderBy(x => x.Price).ToList())
            {
                Console.WriteLine($"- {gpu.GetInfo()}");
            }

            Console.WriteLine("\nDrives:");
            foreach (var drive in stock.Drives.Where(x => x.Price >= startPrice && x.Price <= endPrice)
                         .OrderBy(x => x.Price).ToList())
            {
                Console.WriteLine($"- {drive.GetInfo()}");
            }
        }

    }
}