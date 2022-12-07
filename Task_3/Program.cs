Console.WriteLine("Введите число для проверки:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0)
{
    if (num % 23 == 0)
    {
       Console.WriteLine("Число " + num +" одновременно кратно 7 и 23");
 
    }
}
else Console.WriteLine("Число " + num +" не кратно 7 и 23");
