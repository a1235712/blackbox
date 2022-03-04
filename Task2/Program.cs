//Задача 2: Напишите программу, которая принимает на вход три 
//числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число: ");
string strValue1 = Console.ReadLine();
int value1 = int.Parse(strValue1);

Console.WriteLine("Введите другое число: ");
string strValue2 = Console.ReadLine();
int value2 = int.Parse(strValue2);

Console.WriteLine("Введите третье число: ");
string strValue3 = Console.ReadLine();
int value3 = int.Parse(strValue3);

int max = value1;

if (value2 > max) max = value2;

if (value3 > max) max = value3;

Console.WriteLine ($"Максимум составляет {max}");




