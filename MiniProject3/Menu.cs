using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject3
{
    internal class Menu
    {
        public static string GetCommand()
        {
            Console.Write("(1): Print assets\n(2): Add asset\n(3): Quit\n\nChoose command: ");
            string? command = Console.ReadLine();
            return command ?? "";
        }

        public static string GetName()
        {
            Console.Write("");
            string? name = Console.ReadLine();
            return name ?? "";
        }

        public static void PrintError(string error)
        {
            Console.WriteLine("Invalid input: " + error);
        }
        public static void PrintAll(List<Asset> list, List<Asset> old)
        {
            
            foreach (var o in old)
            {
                Console.WriteLine(o.GetType().Name + "   " + o.Office.Country + "   " + o.Date);
            }
        }
        public static void PrintAdded()
        {

        }
        public static void Quit()
        {

        }

    }
}
