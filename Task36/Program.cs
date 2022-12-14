// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray( int [] arr)                           // модуль ничего не возвращает, но обрабатывает, то что ему передали, даже если в модуле у параметра другое имя!!!
{
    for (int i=0; i<arr.Length; i++)                  // счетчик по i от 0 до Length
    {
        arr[i]=new Random().Next(-100, 100);          // присваиваем каждому элементу массива случайное число
        Console.Write($"{arr[i]} ");                  // просмотр значений массива
    }

    Console.WriteLine();
}


int CountEven( int [] arr)                            // модуль суммирует элементы массива, которые на нечетных i
{
    int Result = 0;

    for (int i=0; i<arr.Length; i++)                  // счетчик по i от 0 до Length
    {
        if (i % 2 != 0) Result = Result + arr[i];     // если СЧЕТЧИК НЕЧЕТНЫЙ то в Result суммируется очередное значение массива
    }

    return Result;
}

// НАЧАЛО ПРОГРАММЫ

int [] mas = new int[4];                            // создаем пустой массив размерностью 4 (или сколько угодно) 

FillArray(mas);                                      // модулем void заполняем новый пустой массив - у него нет ruturn-а, но параметры обрабатывает!

Console.Write($"Сумма элементов, стоящих на нечётных позициях = { CountEven(mas) }");  //вычисляем retutn модуля и сразу его показываем