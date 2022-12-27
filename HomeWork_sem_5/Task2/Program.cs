int SumOddElementOfRandomArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0, 100);
        Console.WriteLine(array[i]);
        if (i % 2 == 1) sum += array[i];
    }
    Console.WriteLine();
    Console.WriteLine(sum);
    return sum;
}
SumOddElementOfRandomArray(5);
