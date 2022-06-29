// Отображение третьей цифры любого числа 
// математический вариант решения

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int numberOfNumbers (int number)            // Метод для определения количества цифр в введёном числе
{
    int d = 1;
    while ((number /= 10) > 0)
        d++;
    return d;
}

Console.WriteLine("Количество цифр в введённом числе: " + numberOfNumbers(num));

                                            // Так как решение с помощью математики, то третье число ищется по формуле:
                                            // thrird = num % 10(в степени d-2) / 10(в степени d-3), где d - количество цифр в введёном числе.
                                            // Следующие два метода для возведения 10 в нужные степени, в зависимотси от введённого числа

int degree1 ()
{
    int y = numberOfNumbers(num) - 2;
    double d1 = Math.Pow(10,y);
    int r1 = Convert.ToInt32(d1);
    return r1;
}

int degree2 ()
{
    int z = numberOfNumbers(num) - 3;
    double d2 = Math.Pow(10,z);
    int r2 = Convert.ToInt32(d2);
    return r2;
}
int thirdNumber ()                           // Метод поиска третьего числа по указанной выше формуле
{
    int third = num % (degree1()) / (degree2());
    return third;
}

if (numberOfNumbers(num) < 3)
{
    Console.WriteLine("Третья цифра в введённом числе отсутствует");
}
else if (numberOfNumbers(num) == 3)
{
    int thirdNum = num%10;
    Console.WriteLine("Третья цифра в введённом числе: " + thirdNum);
}
else 
{
    Console.WriteLine("Третья цифра в введённом числе: " + thirdNumber());
}
