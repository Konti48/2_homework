﻿Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int digit1, digit2, digit4, digit5;   // Использование математических функций
digit1 = num / 10000;
digit2 = num % 10000 / 1000;
digit4 = num % 10000 % 1000 % 100 / 10;
digit5 = num % 10000 % 1000 % 100 % 10;
if (digit1 == digit5 && digit2 == digit4)
{
    Console.WriteLine("Введённое число является палиндромом");
}
else Console.WriteLine("Введённое число не является палиндромом");
