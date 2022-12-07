int N = new Random().Next(100, 999); // Выводит случайное число от 100 до 999
int N2 = N % 100 / 10;
Console.WriteLine(N);
Console.WriteLine("Вторая цифра заданного числа это - " + N2);
