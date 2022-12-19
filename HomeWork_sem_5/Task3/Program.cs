double FindDiffWithMaxMinElementsArray(double[] array)
{
    int iMax = 0;
    int iMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[iMax]) iMax = i;
        else if (array[i] < array[iMax]) iMin = i;
    }
    double diff = array[iMax] - array[iMin];
    Console.WriteLine(diff);
    return diff;
}
double[] arr = new double[] { 12, 4.13, 2.95, 15.98, 16, 17.47 };
FindDiffWithMaxMinElementsArray(arr);