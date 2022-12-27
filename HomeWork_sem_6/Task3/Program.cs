int[] CreateRandomArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0, 10);
        Console.Write($"{array[i]}   ");
    }
    return array;
}
Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Случайный массив: [   ");
int[] arr = CreateRandomArray(size);
Console.Write("]");

int result = 0, iLeft = 0, iRight = size - 1;
while (iLeft < iRight)
{
    result += arr[iLeft] * arr[iRight];
    iLeft++;
    iRight--;
}
Console.WriteLine();
Console.WriteLine($"Сумма произведений пар чисел равна: {result}");