//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите число a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
string v = Console.ReadLine();
double b = Convert.ToDouble(v);

Console.Write("Введите число c: ");
double.TryParse(Console.ReadLine(), out double c);

Console.Write("max = ");

if ((a > b) & (a > c))
{
    Console.WriteLine(a);
}
else if ((b > a) & (b > c))
{
    Console.WriteLine(b);
}
else 
{
    Console.WriteLine(c);
}