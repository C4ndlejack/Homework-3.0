using System;
{
    Console.WriteLine("Введите число: ");
    double n = Convert.ToDouble(Console.ReadLine());
    double i = 1;
    double expo = 3;
    Console.WriteLine("Таблица кубов от 1 до введенного числа: ");
    while (i<=n)
    {
        double result = Math.Pow(i, expo);
        Console.Write(result + " ");
        i++;
    }
}