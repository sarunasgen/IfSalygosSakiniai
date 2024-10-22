Console.WriteLine("Pagrindinis meniu");

Console.WriteLine("1. Skaiciuoti Amziu");
Console.WriteLine("2. Skaiciuoti Mokescius");
Console.WriteLine("3. Skaiciuoti Vidurki");

int a = int.Parse(Console.ReadLine());

switch(a)
{
    case 1:
        Console.WriteLine("Iveskite amziu");
        int amzius = int.Parse(Console.ReadLine());
        if (amzius >= 18)
        {
            Console.WriteLine("esate pilnametis");
        }
        else if (amzius >= 16)
        {
            Console.WriteLine("jusu amzius yra 16 arba 17");
        }
        else if (amzius >= 10)
        {
            Console.WriteLine("jus esate desimties arba vyresnis, ");
            Console.WriteLine("taciau ne vyresnis nei 16");
        }
        break;
    case 2:
        Console.WriteLine("Pasirinkote 2 punkta");
        break;
    case 3:
        Console.WriteLine("Pasirinkote 3 punkta");
        break;
    default :
        Console.WriteLine("Pasirinktas punktas nerastas");
        break;
}