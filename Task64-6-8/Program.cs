// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void fprintnatur(int N)
{
    Console.WriteLine($"{N}");
    N = N-1;
    if (N == 0)
    {
        return;
    };
    fprintnatur(N);
};

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()); 
fprintnatur(N);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void fprintnatur(int M, int N, int S)
{
    
    S = S + M;
    M = M+1;
    if (M > N)
    {
        Console.WriteLine($"{S}");
        return;
    };

    fprintnatur(M,N,S);
};

Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine()); 

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()); 

if (M > N)
{
    (M, N) = (N, M); // меняем значения переменных местами
}

int S = 0; // для накопления суммы

fprintnatur(M,N,S);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }else if (n == 0)
    {
        return A(m - 1, 1);
    }else
    {
        return A(m - 1, A(m, n - 1));
    }

}

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()); 

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()); 

Console.WriteLine($"{ A(m,n) }");