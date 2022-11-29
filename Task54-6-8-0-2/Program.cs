//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void SortMas(int[,] massiv)
{
  for (int i = 0; i < massiv.GetLength(0); i++)
  {
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
      for (int k = 0; k < massiv.GetLength(1) - 1; k++)
      {
        if (massiv[i, k] < massiv[i, k + 1])
        {
          int massiv2 = massiv[i, k + 1];
          massiv[i, k + 1] = massiv[i, k];
          massiv[i, k] = massiv2;
        }
      }
    }
  }
}   

// НАЧАЛО

int [,] mas = new int [,]
    {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4},
    };

SortMas(mas);

for (int i = 0; i < mas.GetLength(0); i++)
  {
    for (int j = 0; j < mas.GetLength(1); j++)
    {
      Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
  }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int sum(int[,] arr)
{
    int stroka = 0;
    int sum;
    int MaxSum = 0;

    for (int i = 0; i < arr.GetLength(0); i++) // идем по строкам i
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++) // идем по столбцам j (каждому числу в строке i)
        {
            sum = sum + arr[i, j];  // суммируем числа в строке
        }

        if (sum > MaxSum)
        {
            MaxSum = sum;
            stroka = i;
        }
    }
    return stroka + 1; // т.к. начинается с 0
}

// НАЧАЛО

int[,] mas = new int[,]
    {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4},
        {5, 2, 6, 7},
    };

Console.WriteLine($"{sum(mas)} строка");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArr(int[,] mas) // модуль печати двумерного массива
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write(mas[i,j] + " ");
        }
    Console.WriteLine();
    }
}

// НАЧАЛО

int [,] mas1 = new int [,] //дано
    {
        {2, 4},     
        {3, 2},
    };

int [,] mas2 = new int [,] //дано
    {
        {3, 4},     
        {3, 3},
    };

int [,] mas3 = new int [2,2];

for (int i=0; i<mas1.GetLength(0); i++)
{
    for (int j=0; j<(mas1.GetLength(1)-1); j++)
    {
        for (int j2=0; j2<mas2.GetLength(1); j2++)
        {
            for (int i2=0; i2<(mas2.GetLength(0)-1); i2++)
            {
                mas3[i,j2] = mas1[i,j] * mas2[i2,j2] + mas1[i,j+1] * mas2[i2+1,j2];
            }
        }
    }
}

Console.Clear();

Console.WriteLine("Произведение 1-й матрицы: ");
PrintArr(mas1);

Console.WriteLine("на 2-ю матрицу: ");
PrintArr(mas2);

Console.WriteLine("равняется: ");
PrintArr(mas3);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void WriteArray3(int[,,] mas3)
{
    for (int z = 0; z < mas3.GetLength(2); z++)
    {
        for (int x = 0; x < mas3.GetLength(0); x++)
        {
             for (int y = 0; y < mas3.GetLength(1); y++)
            {
                Console.Write($"{mas3[x, y, z]}({x},{y},{z}) ");
                // Console.Write($"{k}) {mas3[i, j, k]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// НАЧАЛО

int[,,] mas = { { { 66, 27 }, { 25, 90 } }, { { 34,  26}, { 41, 55 } } };

WriteArray3(mas);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArr(int [,] mas) // модуль печати двумерного массива
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write(mas[i,j].ToString("00") + " ");
        }
    Console.WriteLine();
    }
}


// НАЧАЛО

int n = 4; // можно изменять

Console.WriteLine();

int[,] mas2 = new int[n, n];

int i = 0, j = 0;

int povorot = 1;

while (n != 0)
{
    int k = 0;
    do { mas2[i, j++] = povorot++; } while (++k < n - 1);
    for (k = 0; k < n - 1; k++) mas2[i++, j] = povorot++;
    for (k = 0; k < n - 1; k++) mas2[i, j--] = povorot++;
    for (k = 0; k < n - 1; k++) mas2[i--, j] = povorot++;

    ++i; ++j; n = n < 2 ? 0 : n - 2;
}
        
PrintArr(mas2);