// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int A = 452;

string B = $"{A}";                  // int -> String     (можно еще A.ToString())
                                    // переводим для того, что string - это всего лишь МАССИВ из символов (char)!

int result=0;

for (int i=0; i<B.Length; i++)      // B - строка, т.е. массив символов 
{
    string C = B[i].ToString();     // Char -> String

    result = result + int.Parse(C); // String -> int
    
}

Console.WriteLine(result);