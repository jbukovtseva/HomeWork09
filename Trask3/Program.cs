Console.Write("Введите неотрицательное число M: ");
string a = Console.ReadLine();

Console.Write("Введите неотрицательное число N: ");
string b = Console.ReadLine();

var numberM = ExceptionHandling(a);
var numberN = ExceptionHandling(b);

if (numberM.exception && numberN.exception && numberM.number >= 0 && numberN.number >= 0)
{
    Console.WriteLine($"A({numberM.number}, {numberN.number}) = {Akkerman(numberM.number, numberN.number)}");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"{a}, {b} -> Некорректный ввод!");
}




int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return 0;
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