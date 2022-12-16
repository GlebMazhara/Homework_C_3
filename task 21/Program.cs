// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите кординаты точек");
Console.WriteLine("Введите X1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z1");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите X2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y2");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z2");
double z2 = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
Console.WriteLine($"Расстояние между двумя точками: {result}");