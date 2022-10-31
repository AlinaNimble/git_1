// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int MinMax(int [] mass)
{
    int max=0;

    for (int i=0; i<mass.Length; i++)
    {
        if (mass[i] > max)
        {
            max = mass[i];
        }
    }

   int min=max;
 
    for (int i=0; i<mass.Length; i++)
    {
         if (mass[i] < min)
        {
            min = mass[i];
        }
    }

   return (max-min);
};

// НАЧАЛО ПРОГРАММЫ
int [] m = {3, 7, 22, 2, 78};

Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {MinMax(m)}");