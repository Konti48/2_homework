Console.WriteLine("Опишите первую прямую y = k1*x + b1, задав значения k1 и b1");
Thread.Sleep(1000);
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Опишите вторую прямую y = k2*x + b2, задав значения k2 и b2");
Thread.Sleep(1000);
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
/* если  k1 = k2 && b1 != b2 => прямые параллельны
если  k1 = k2 && b1 == b2 => прямые совпадают
если  k1 = - 1/k2 => прямые перпендикулярны
координаты пересечения вычисляются путём решения системы двух уравнений (из одного вычитается другое)
*/
double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны");
else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
else if (k1 == -1 / k2) Console.WriteLine($"Прямые перпендикулярны и пересекаются в точке с координатами [ {x}; {y}]");
else Console.WriteLine($"Точка пересечения прямых имеет координаты [ {x}; {y}]");


