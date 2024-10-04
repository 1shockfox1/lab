try
{
    Console.Write("Введите число (1 до 99): ");
    double x = double.Parse(Console.ReadLine());

    if (x < 1 || x > 99)
    {
        Console.WriteLine("Я же сказал вести число от 1 до 99.");
        return;
    }

    string z;
    double y = x % 10;

    if (y == 1 && x != 11)
    {
        z = "копейка";
    }
    else if (y >= 2 && y <= 4 && (x < 10 || x >= 20))
    {
        z = "копейки";
    }
    else
    {
        z = "копеек";
    }

    Console.WriteLine($"{x} {z}");
}

catch
{
    Console.WriteLine("не правильное значение ");
}