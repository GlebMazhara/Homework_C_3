// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("введите 5 значное число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n%10;
int b = (n/10)%10;
int n1 = n/1000;
int n2 = a*10+b;
if(n1==n2)
    Console.WriteLine($"число полиндром: {n}");
else
 Console.WriteLine($"число не полиндром: {n}");