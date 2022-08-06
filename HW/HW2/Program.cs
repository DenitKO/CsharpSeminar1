Console.WriteLine("Введите a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c = ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
//int count = 1;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.Write("max = ");
Console.Write(b);