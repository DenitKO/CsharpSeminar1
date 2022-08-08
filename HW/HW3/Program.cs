Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
if ((a % 2) == 0) 
{
    Console.Write(a);
    Console.Write(" = Четное");
}
else 
{
    Console.Write(a);
    Console.Write(" = Нечетное");
}