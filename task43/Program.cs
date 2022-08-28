Console.Write("Введите k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k2 - k1);
double y = k1 * (b2 - b1) / (k2 - k1) + b1;
if (k1 == k2) Console.WriteLine("Прямые не пересекаются");
else Console.WriteLine($"Точка пересечения двух прямых ({x}; {y})");