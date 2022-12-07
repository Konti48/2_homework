int N = new Random().Next(1, 65536);
Console.WriteLine(N);
// string arr = N.ToString(); // С помощью перевода числа в однострочный массив
// if (arr.Length > 2)
// {
// Console.WriteLine(arr[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

if (N < 100) Console.WriteLine("Третьей цифры нет"); // С помощью математических выражений
else if (N < 1000) Console.WriteLine(N %100 % 10);
else if (N < 10000) Console.WriteLine(N %1000 % 100 /10);
else if (N < 100000) Console.WriteLine(N %10000 % 1000 /100);