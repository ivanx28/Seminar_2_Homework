// Программа, отображающая вторую цифру трёхзначного числа

string secondNumber(int number)
{
    if (number >= 100 && number <= 999)
    {
        int second = (number%100)/10;
        return ("Вторая цифра: " + second);
    }
    else
        return "Введённое число не является трехзначным";
}

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(secondNumber(num));