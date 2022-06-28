// Программа, которая принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным

string dayOfWeek (int dayNumber)
{
    if (dayNumber >= 1 && dayNumber <= 5)
    {
        return "Введенный день не является выходным";
    }
    else if (dayNumber >= 6 && dayNumber <= 7)
    {
        return "Введенный день является выходным";
    }
    else
        return "Введенное число не является днём недели";
}

Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(dayOfWeek(day));