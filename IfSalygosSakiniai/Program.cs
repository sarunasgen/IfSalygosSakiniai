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

            if(a > b)
            {
                Console.WriteLine("A daugiau uz B");
            }
            else if(a < b)
            {
                Console.WriteLine("A maziau uz B");
            }
            else
            {
                Console.WriteLine("A yra lygu B");
            }
            
        }
    }
}