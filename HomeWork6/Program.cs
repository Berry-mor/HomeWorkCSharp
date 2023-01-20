//Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int AmountOfNumbers(int n)
{
     
      int count = 0;
    for(int i = 0; i < n; i++)
    {
        Console.WriteLine($"{i + 1} число: ");
        int num = Convert.ToInt32(Console.ReadLine());

              
        if(num > 0) count++;
    }
    return count;
}


Console.WriteLine("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());

int amountNumbers = AmountOfNumbers(n);
 Console.WriteLine($"Количество чисел больше нуля =  {amountNumbers}");
 */



//Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"({x} ; {y})");
}


Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);