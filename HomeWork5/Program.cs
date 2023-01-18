/*

//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
int[] GetArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] +" ");
    }
    Console.WriteLine();
    return array;
}

int EvenNum(int[] getArray)
{
    int count = 0;
    for(int i = 0; i < getArray.Length; i++)
    {
        if (getArray[i] % 2 == 0) count++;
    }
    return count;
}
Console.WriteLine("Введите размерность массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] getArray = GetArray(size);
Console.WriteLine("------------------------------------------");
int num = EvenNum(getArray);
Console.WriteLine("Количество четных чисел: " +num);

*/
//---------------------------------------------------------------------------------------

/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] +" ");
    }
    Console.WriteLine();
    return array;
}

int EvenNum(int[] getArray)
{
    int sum = 0;
    for(int i = 0; i < getArray.Length; i++)
    {
        if (i % 2 != 0) sum += getArray[i];
    }
    return sum;
}
Console.WriteLine("Введите размерность массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] getArray = GetArray(size);
Console.WriteLine("------------------------------------------");
int num = EvenNum(getArray);
Console.WriteLine("Сумма чисел на нечетных позициях: " +num);

*/
//-----------------------------------------------------------------------------------------

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


double[] GetArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
    array[i] = rand.Next(1, 100) + rand.NextDouble();
    Console.Write(array[i] +" ");
    }
    Console.WriteLine();
    return array;
}

double MinMax(double[] getArray)
{
    double min = getArray[0];
    double max = getArray[0];
    for(int i = 0; i < getArray.Length; i++)
    {
        if(getArray[i] < min)
        {
            min = getArray[i];
        }
        else if(getArray[i] > max)
        {
            max = getArray[i];
        }
    }
    Console.WriteLine("MAX = " +max);
    Console.WriteLine("MIN = " +min);
    //double minimax = 0;
    double minimax = Math.Round(max, 2) - Math.Round(min, 2);
    return minimax;
}

Console.WriteLine("Введите размерность массива:");
int size = Convert.ToInt32(Console.ReadLine());
double[] getArray = GetArray(size);
Console.WriteLine("------------------------------------------");
double num = MinMax(getArray);
Console.WriteLine("Разница =  " +num);