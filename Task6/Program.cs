//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число: ");
double n = double.Parse(Console.ReadLine());

string otvet;

if ((n % 2) == 0)
    otvet = "четное";
else 
    otvet = "нечетное";

Console.WriteLine(otvet);