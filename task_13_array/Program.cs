// Отображение третьей цифры любого числа 
// вариант решения без математических действий

Console.WriteLine ("Введите число");

string number = Console.ReadLine();

string thirdNumber()
{
    if (number.Length < 3)
    {
        return "Третья цифра в ведённом числе отсутствует";
    }
    else
    {
        return "Третья цифра введённого числа " + number[2];
    }
}

Console.WriteLine(thirdNumber());
