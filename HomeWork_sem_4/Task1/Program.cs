/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Не использовать функцию Math.Pow

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int GetDegreeNumber2 (int number1, int number2)  // Возводит в степень числа 2
{
int count = 0;
int result = 1;
while(count < number2)
{
result *= number1;
count++;
}
return result;
}
Console.WriteLine(GetDegreeNumber2 (num1, num2));