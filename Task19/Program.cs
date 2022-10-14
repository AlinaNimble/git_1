// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string CheckPalindrom(int Chislo)
{
    string chisloStr = Chislo.ToString();

    string YesNo = "да";

    for(int i=0; i < (chisloStr.Length % 2); i++)
    {
            if (chisloStr[i]!=chisloStr[chisloStr.Length - i - 1]!)
            {
                YesNo = "нет";
                break;
            }
    }
    return YesNo;
}

Console.Write("Введите пятизначное число: ");
string ChisloStr;
ChisloStr = Console.ReadLine(); // с консоли получаем тип string всегда

int ChisloInt;
int.TryParse(ChisloStr, out ChisloInt); //преобразуем String в Int

string otvet = CheckPalindrom(ChisloInt); //вызываем Метод CheckPalindrom, который принимает аргумент ChisloInt и возвращает ответ

Console.WriteLine(otvet);