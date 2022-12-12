Console.WriteLine("Введите поочередно координаты x1 y1 z1 первой точки: ");// Метод создания массива с ручным вводом
void FillArrayManual(int[] arr) 
{
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
}
int[] arr1 = new int[3];
FillArrayManual(arr1);
Console.WriteLine("Введите поочередно координаты x2 y2 z2 второй точки: ");
int[] arr2 = new int[3];
FillArrayManual(arr2);
double sqrDifference = 0;
double sum = 0;
for (int i = 0; i < 3; i++)
{
sqrDifference = Math.Pow(arr2[i] - arr1[i], 2);
sum += sqrDifference;
}
double distance = Math.Sqrt(sum);
Console.WriteLine($"Расстояние между двумя точками равно {distance}");
