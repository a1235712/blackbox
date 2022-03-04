// Задача 4: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");

string strNumber = Console.ReadLine();
int Number = int.Parse(strNumber);
int x = 1;
int k = 1;

while (x < Number) 
 {  
    if (x % 2 == 0)
    {

        Console.Write(x + " ");
        k++;
    }
    if (k > Number)
    {
        break;
    }
    x++;
}
