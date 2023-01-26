// Задача 47. Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.
/*
double[,] RandomDoubleArray(int m, int n)
{
    Random rand = new Random();
    
    double[,] array = new double[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int  j = 0; j < n; j++)
            array[i, j] = rand.Next(10, 100) + rand.NextDouble();
            
    }
    
    return array;
}

void ShowArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j],2) + "\t");
        }
        Console.WriteLine();
    }

}

    int m = 6;
    int n = 6;
    double[,] newArray = RandomDoubleArray(m,n);
    ShowArray(newArray);
*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandomArray(int m, int n)
{
    int[,] array  = new int[m, n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1,100);
        }
    }
    return array;
}

int CheckAvailability(int[,] array)
{
    Console.WriteLine("Input number element string:");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number element column:");
    int j = Convert.ToInt32(Console.ReadLine());
    int numBool = 0;

    if (i < array.GetLength(0) && j < array.GetLength(1))
       {
        numBool = 1;
   
       }
return numBool;
}
int m = 5;
int n = 4;
int[,] newArray = CreateRandomArray(m, n);
if(CheckAvailability(newArray) == 1)
{
    Console.WriteLine($" Элемент с такими индексами в массиве существует");
}
else 
{
Console.WriteLine($" Элемент с такими индексами в массиве НЕ существует");
}
*/

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void AverageNumberColumn(int[,] array)
{
//int num = array.GetLength(1);
double average;
for(int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i,j];
        //average = sum / array.GetLength(1);
       
    }
//Console.Write($"{sum} {array.GetLength(1)}" + "\t");
average = sum / array.GetLength(0);
double aver = Math.Round(average,2);
Console.Write($"{aver}" + "\t");

}
}
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

int m = 3;
int n = 4;
int[,] newArray = CreateRandomArray(m, n);
ShowArray(newArray);
Console.WriteLine();

AverageNumberColumn(newArray);

