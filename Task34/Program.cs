﻿// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray( int [] arr)                           // модуль ничего не возвращает, но обрабатывает, то что ему передали, даже если в модуле у параметра другое имя!!!
{
    for (int i=0; i<arr.Length; i++)                  // счетчик по i от 0 до Length
    {
        arr[i]=new Random().Next(100, 1000);          // присваиваем каждому элементу массива случайное 3-значное число
        Console.Write($"{arr[i]} ");                  // просмотр значений массива
    }

    Console.WriteLine();                              // в конце работы модуля выводим перевод на новую строку
}


int CountEven( int [] arr)                            // модуль считает четные числа (элементы целиком, не цифры!) в массиве
{
    int Result = 0;

    for (int i=0; i<arr.Length; i++)                  // счетчик по i от 0 до Length
    {
        if (arr[i] % 2 == 0) Result = Result + 1;     // если i-е значение массива четное (начинается с 0 !), то Result+1
    }

    return Result;
}

// НАЧАЛО ПРОГРАММЫ

int [] mas = new int[4];                             // создаем пустой массив размерностью 4 (или сколько угодно) 

FillArray(mas);                                      // модулем void заполняем новый пустой массив - у него нет ruturn-а, но параметры обрабатывает!

Console.Write($"Чётных чисел в массиве = { CountEven(mas) }");  //вычисляем retutn модуля и сразу его показываем