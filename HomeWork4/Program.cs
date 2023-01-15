
/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int GetExpon(int a, int b){
        int sum = 1;

for(int i = 0; i < b; i++){
    sum = sum * a;
}
return sum;
}

Console.WriteLine("Введите число для возведения в степень:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа:");
int exp = Convert.ToInt32(Console.ReadLine());

int degree = GetExpon(num, exp);
Console.WriteLine(degree);
*/
//-----------------------------------------------------------------
/*
//Задача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.

int GetNumber(int num){
    int sum = 0;
    while(num != 0){
        sum += (num % 10);
        num /= 10;
    }
    return sum;
}
Console.WriteLine("Input number:");
int inputNum = Convert.ToInt32(Console.ReadLine());

int sumNumber = GetNumber(inputNum);
Console.WriteLine(sumNumber);
*/

//----------------------------------------------------------------------


//Задача 29: Напишите программу, которая задаёт массив из m элементов
// и выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Ввод элементов массива окончен");
     Console.WriteLine("------------------------------------");
    return array;
}

void PrintArray(int[] array)
{
       Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        int lenArray = array[i];
        Console.Write(lenArray + ",");
    }
     Console.Write("]");
   
}

Console.WriteLine("Введите размерность массива:");
int inputSize = Convert.ToInt32(Console.ReadLine());
int[] getArray = CreateArray(inputSize);
PrintArray(getArray);