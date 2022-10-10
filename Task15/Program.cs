// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string CheckВayOff(int NumDay)
{
    string YesNo;
    if (NumDay > 5)
    {
        YesNo = "да";    
    }
    else
    {
        YesNo = "нет";    
    }

    return YesNo;
}

Console.Write("Введите номер дня недели: ");
string NumDayStr;
NumDayStr = Console.ReadLine(); // с консоли получаем тип string всегда

int NumDay;
int.TryParse(NumDayStr, out NumDay); //преобразуем String в Int

string otvet = CheckВayOff(NumDay); //вызываем Метод CheckВayOff, который принимает аргумент NumDay и возвращает ответ

Console.WriteLine(otvet);
