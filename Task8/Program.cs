

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");

if ( (double.TryParse(Console.ReadLine(), out double n) ) == false)
{
    Console.Write("Вы ввели НЕ число!");  
    return;  
};

int i=1;

while (i<=n)
{
    if ((i % 2) == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}