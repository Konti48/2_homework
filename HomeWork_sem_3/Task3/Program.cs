Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];
Console.Write("Массив кубов от 1 до N: [ ");
for (int i = 0; i < num; i++)
{
array[i] = Math.Pow(i + 1, 3);
Console.Write(array[i] + " ");
}
Console.Write("]");


