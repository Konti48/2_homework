
Console.WriteLine("Введите количество числе для проверки:");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i + 1}-е число");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) count++;
}
Console.WriteLine("Количество чисел, которые больше 0, составляет: " + count);
