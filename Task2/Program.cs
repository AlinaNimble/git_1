//Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите число a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
string v = Console.ReadLine();
double b = Convert.ToDouble(v);

Console.Write("max = ");

if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}