using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("پر کردن آرایه با اعداد رندوم (تصادفی)");
        Console.WriteLine("========================================");

        Random rnd = new Random();   // اینو یادمه باید بسازیمش

        Console.Write("چند تا عضو می‌خوای آرایه داشته باشه؟ ");
        int tedad = int.Parse(Console.ReadLine());

        // آرایه رو ساختم
        int[] array = new int[tedad];

        Console.WriteLine("\nدارم آرایه رو پر می‌کنم...");

        // پر کردن آرایه با اعداد تصادفی بین 1 تا 100
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(1, 101);   // از 1 تا 100 (101 نمیاد)
        }

        // نمایش آرایه
        Console.WriteLine("\nآرایه پر شد! اینا شدن عناصرا:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "   ");
            // هر 10 تا یه خط جدید که قشنگ بشه
            if ((i + 1) % 10 == 0)
                Console.WriteLine();
        }

        Console.WriteLine("\n\nتموم شد رفیق! یه کلید بزن بره...");
        Console.ReadKey();
    }
}