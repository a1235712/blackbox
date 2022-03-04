//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");

string strNumber = Console.ReadLine();
int Number = int.Parse(strNumber);
int x = Number % 2;

if (x == 0) Console.WriteLine($"Число {Number} является четным");

else 

Console.WriteLine($"Число {Number} является нечетным");


