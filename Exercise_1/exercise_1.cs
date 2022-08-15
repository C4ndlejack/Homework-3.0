using System;
 
 
 
class Palindr
{
    public static bool Palindromtest (string num)
    {
        for (int i = 0, j = num.Length - 1; i < j; i++, j--)
            if (num[i] != num[j])
            return false;
            return true;
 
    }
    static void Main()
    {   
        string num;
        Console.WriteLine("Введите число:");
        num = Console.ReadLine();
        if (Palindromtest(num))
            Console.WriteLine("Это число - палиндром");
        else Console.WriteLine("Это число - не палиндром");
    }
}