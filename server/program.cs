using System.Runtime.CompilerServices;

bool exit = false;
while (!exit)
{
    Console.WriteLine("Меню");
    Console.WriteLine("1 - показать фио");
    Console.WriteLine("2 - показать группу");
    Console.WriteLine("3 - показать дату");
    Console.WriteLine("4 - выход");

    string intput = Console.ReadLine();
    switch (intput)
    {
        case "1":
            Console.WriteLine("Уютов Павел Александрович");
            break;
        case "2":
            Console.WriteLine("ИСП-231");
            break;
        case "3":
            Console.WriteLine(DateTime.Now);
            break;
        case "4":
            Console.WriteLine("выход...");
            exit = true;
            break;
        default:
            Console.WriteLine("error");
            break;
    }
    Console.WriteLine();
}

Console.WriteLine("Привет");
Console.WriteLine("Уютов Павел Александрович");
Console.WriteLine("ИСП-231");
Console.WriteLine(DateTime.Now);