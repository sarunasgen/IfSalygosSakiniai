/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiksmaiSuString
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite Teksta: ");
            string ivestis = Console.ReadLine();
            bool arIvesitsTuscia = string.IsNullOrEmpty(ivestis);
            bool arYraMMazoji = ivestis.Contains("m");
            bool arSkaicius = int.TryParse(ivestis, out int skaicius);
            if (arIvesitsTuscia)
            {
                Console.WriteLine("Tuscias arba nepriskirtas");
            }
            else
            {
                Console.WriteLine("Tekstas nera tuscias arba nepriskirtas");
            }

            if (arYraMMazoji)
            {
                Console.WriteLine("Ivestyje yra m mazoji");
            }
            else
            {
                Console.WriteLine("Ivestyje nera m mazosios");
            }

            if (arSkaicius)
            {
                Console.WriteLine("Ivestis yra sveikasis skaicius");
            }
            else
            {
                Console.WriteLine("Ivestis nera sveikasis skaicius");
            }
        }
    }
}
*/