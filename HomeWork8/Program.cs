//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
//Метод генерации массива
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }

    }
    return array;
}

//Метод вывода массива в консоль

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Метод обмена элементов
void Swap(ref int el1, ref int el2)
{
    var temp = el1;
    el1 = el2;
    el2 = temp;
}

//Метод сортировки пузырьком

int[,] BubbleSort(int[,] newArray)
{
    for (int k = 0; k < newArray.GetLength(0); k++)
    {
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1) - 1; j++)
            {
                if (newArray[i, j] < newArray[i, j + 1])
                    Swap(ref newArray[i, j], ref newArray[i, j + 1]);
            }
        }
    }
    return newArray;
}

int m = 3;
int n = 4;

int[,] newArray = CreateArray(m, n);
Console.WriteLine("Первоначальный массив");
ShowArray(newArray);
Console.WriteLine();
Console.WriteLine("Отсортированный массив");
int[,] sortArray = BubbleSort(newArray);
ShowArray(sortArray);

*/

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
//Метод генерации массива
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }

    }
    return array;
}

//Метод вывода массива в консоль
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Метод подсчета суммы элементов по строкам массива
int[] SumLineArray(int[,] newArray)
{

    int[] sumArray = new int[newArray.GetLength(0)];
    int sum = 0;

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        // 
        for (int j = 0; j < newArray.GetLength(1); j++)
        {

            sum += newArray[i, j];
        }
        sumArray[i] = sum;
        Console.Write(sum + " ");
        sum = 0;
    }

    Console.WriteLine();

    return sumArray;
}

//Метод определения строки минимальной суммы
int MinLineSum(int[] a)
{
    int minEl = 0;
    int min = a[0];
    for (int i = 1; i < a.Length; i++)
    {

        if (a[i] < min)
        {
            minEl = i;
        }
    }
    return minEl;
}

int m = 3;
int n = 5;
int[,] newArray = CreateArray(m, n);
Console.WriteLine("Первоначальный массив");
ShowArray(newArray);
Console.WriteLine();
int[] a = SumLineArray(newArray);
int numLine = MinLineSum(a);
Console.WriteLine($"Номер строки с минимальной суммой:  {numLine + 1}");

*/

//Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
/*
//Генерация первой матрицы
int[,] CreateMatrixOne(int m, int n)
{
    int[,] matrixOne = new int[m, n];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            matrixOne[i, j] = new Random().Next(1, 5);
        }

    }
    return matrixOne;
}

//Генерация второй матрицы
int[,] CreateMatrixTwo(int m, int n)
{
    int[,] matrixTwo = new int[m, n];
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            matrixTwo[i, j] = new Random().Next(1, 5);
        }

    }
    return matrixTwo;
}

//Метод вывода массива в консоль
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Метод перемножения матриц
int[,] MultipliedMatrix(int m, int n, int[,] a, int[,] b)
{
    int[,] c = new int[m, n];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            c[i, j] = 0;
            for (int k = 0; k < a.GetLength(0); k++)
            {
                c[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return c;
}

int m = 2;
int n = 2;

int[,] a = CreateMatrixOne(m, n);
Console.WriteLine("Первая матрица");
ShowArray(a);

int[,] b = CreateMatrixTwo(m, n);
Console.WriteLine("Вторая матрица");
ShowArray(b);

int[,] d = MultipliedMatrix(m, n, a, b);
Console.WriteLine("Произведение матриц");
ShowArray(d);
*/

//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу,которая будет построчно выводить массив, добавляя индексы
//каждого элемента.
/*
//Методформирования трехмерного массива
int[,,] CreateThreeDimensionalArray(int m, int n, int l)
{
    int[,,] array = new int[m, n, l];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = new Random().Next(10, 100);
        }
    }
    return array;
}

//Метод вывода массива в консоль
void ShowThreeArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Массив № {i + 1} \n");
        for (int j = 0; j < array.GetLength(1); j++)
        {

            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");
    }

}

int m = 3;
int n = 3;
int l = 3;

int[,,] newArray = CreateThreeDimensionalArray(m, n, l);
ShowThreeArray(newArray);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

