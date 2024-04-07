using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3
{
    internal class Menu
    {
        public static string GetCommand()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.Write("(1): Print assets\n(2): Add asset\n(3): Quit\n\nChoose command: ");
            string? command = Console.ReadLine();
            return command ?? "";
        }

        public static string GetName()
        {
            Console.Write("Available product types:\n* Computer\n* Phone\nEnter type of product: ");
            string? name = Console.ReadLine();
            return name ?? "";
        }

        public static string GetBrand()
        {
            Console.Write("Enter brand: ");
            string? brand = Console.ReadLine();
            return brand ?? "";
        }

        public static string GetModel()
        {
            Console.Write("Enter model: ");
            string? model = Console.ReadLine();
            return model ?? "";
        }

        public static string GetPrice()
        {
            Console.Write("Enter price in USD (integer): ");
            string? price = Console.ReadLine();
            return price ?? "";
        }

        public static string GetCountry()
        {
            Console.Write("Available offices are:\n* Denmark\n* Sweden\n* USA\nEnter country/office: ");
            string? country = Console.ReadLine();
            return country ?? "";
        }

        public static void PrintError(string error)
        {
            Console.WriteLine("Invalid input: " + error);
        }
        public static void PrintAll(List<Asset> list, List<Asset> old)
        {
            Console.WriteLine("\nType".PadRight(15) + "Brand".PadRight(15) + "Model".PadRight(15) + "Office".PadRight(15) 
                + "Purchase Date".PadRight(15) + "Price in USD".PadRight(15) + "Currency".PadRight(15) + "Local price today".PadRight(15));
            Console.WriteLine("----".PadRight(14) + "------".PadRight(15) + "------".PadRight(15) + "------".PadRight(15)
                + "----------".PadRight(15) + "----------".PadRight(15) + "--------".PadRight(15) + "----------".PadRight(15));
            
            foreach (var l in list)
            {
                if (old.Any(o => o.Equals(l)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(l);
                    Console.ResetColor();
                } else
                {
                    Console.WriteLine(l);
                }
            }
        }
        public static void PrintAdded()
        {
            Console.WriteLine("\nThe asset was added successfully!");
        }
        public static void Quit()
        {
            Console.WriteLine("\nGood bye!");
        }

    }
}
