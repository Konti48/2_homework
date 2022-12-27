int CountingEvenElementOfRandomArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
        Console.WriteLine(array[i]);
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine(count);
    return count;

}
CountingEvenElementOfRandomArray(7);
