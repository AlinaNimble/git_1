// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 3267912 -> 6

void Char3(int chislo)
{
    string chisloStr = chislo.ToString(); //преобразовали int в string
    string otvet = "третьей цифры нет"; //готовый ответ на случай если не найдем

    for(int i=0; i < chisloStr.Length; i++)
    {
        if (i == 2) //счет начинается с 0
        {
            otvet = chisloStr[i].ToString(); //преобразовали char в string
            break;
        }
    }
    Console.WriteLine(otvet);
}

Char3(3267912); //вызываем метод, который принимает аргументы, но ничего не возвращает