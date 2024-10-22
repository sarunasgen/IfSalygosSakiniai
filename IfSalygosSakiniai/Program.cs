using System;

namespace IfSalygosSakiniai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite A reiksme: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite B reiksme: ");
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine("Iveskite C reiksme: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && c < a && c < b)
            {
                Console.WriteLine("A daugiau uz B ir C maziau uz A ir B");
            }
            else if(a < b && a < c)
            {
                Console.WriteLine("A maziau uz B ir C");
            }
            else if(c > a && c > b)
            {
                Console.WriteLine("C daugiau uz A ir B");
            }
            else if (c == a || c == b)
            {
                Console.WriteLine("C lygus A arba B");
            }
            else
            {
                Console.WriteLine("A yra lygu B");
            }
            
        }
    }
}