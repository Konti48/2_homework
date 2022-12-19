/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, 
которые являются делителями этого числа.

452 -> 6

1. Сгенерировать число
2.узнать длинну числа
3. Разбить число на цифры этого числа
4. Поделить число на каждую цифру, в случае деления без остатка поместить в сумму

*/

int num = new Random().Next(1, int.MaxValue);
int length = (int) Math.Log10 (num)+1; //Длинна числа с помощью десятичного логорифма
Console.WriteLine(num);
int [] digitsOfNumber = new int[length];
int sum = 0;
int val = num;
for(int i = 0; i < length; i++)
{
    digitsOfNumber[i] = val % 10;
    val = val / 10;
    if(digitsOfNumber[i] > 0 && num % digitsOfNumber[i] == 0) sum += digitsOfNumber[i];
}
Console.WriteLine(sum);
