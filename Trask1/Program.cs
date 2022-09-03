Console.Write("Введите натуральное число N,\nчтобы вывести все натуральные числа от N до 1: ");
string n = Console.ReadLine();

var count = ExceptionHandling(n);

if (count.exception && count.number >= 0)
{
    Numbers(count.number);
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"{n} -> Некорректный ввод!");
}

void Numbers(int last)
{
    if (last == 0)
    {
        return;
    }
    Console.Write($"{last} ");
    Numbers(last - 1);
}

(bool exception, int number) ExceptionHandling(string number)
{
    bool yesInt = int.TryParse(number, out int d);
    if (!yesInt)
    {
        return (false, d);
    }
    return (true, d);
}