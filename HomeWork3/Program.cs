﻿
// Напишите программу, которая принимает
// на вход  число и проверяет, является ли оно палиндромом.
/*

void Itog(int sum, int number)
{
 //Console.WriteLine(sum);
 int ii = 10; 
  int count = sum % 10;
  int i = (sum - count) / ii;
  int numLev = 0;
  int numPr = 0;
  for(;numLev == numPr && number > 9;)
  {
   numLev = number / i ;
   numPr = number % 10 ;
 // Console.WriteLine($"Number {number},NumLev {numLev}, NumPr {numPr}");
  number = (number % i) / 10;
  //Console.WriteLine($"Number {number}");
      if(number  > 9 && number < 100 )
          {
             numLev = number / i;
             numPr =  number % 10;
             //Console.WriteLine($"Number if {number},NumLev {numLev}, NumPr {numPr}");
             if (numLev == numPr)
                {
                  Console.WriteLine($"ДА!!!");
                  break;
                }
         }
  ii = ii * 10;
  i = i / ii;
  }
    
       if (numLev == numPr && number < 9)
      {
          Console.WriteLine("ДА");
      }
    else
      {
         Console.WriteLine("НЕТ");
       }
}
 int  KolNumOne(int number)
{
    int i = 10;
    int count = 1; // считает количество знаков числа
    
            for(;number > 10 && number / i != 0;)
            {
                i = i * 10;
               count++;
               }
            return  i + count;
        
}

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int sum = KolNumOne(num);
Itog(sum, num);
*/
 

//Задача № 21
//Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.
/*
Console.WriteLine("Введите x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

 dist(x1, y1, z1,
             x2, y2, z2);
void dist(float x1, float y1,
              float z1, float x2,
              float y2, float z2)
{
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
    Console.WriteLine(Math.Round(d,2));
    return;
}
*/

//Задача №23
//Напишите программу, которая принимает
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

CubNum(number);
void CubNum(int number)
{
  for(int a = 1; a <= number; a++)
  {
    Console.Write($"{a * a * a},");
  }
}


/*
//Второй вариант задачи 19

int getCharLength(int number)
{
    int currentNumber = number;
    int length        = 1;

    while (currentNumber > 9)
    {
        length++;
        currentNumber /= 10;
    }

    return length;
}

int getCharByPosition(int number, int position)
{
    int numberLength      = getCharLength(number);
  Console.WriteLine($"NumberLength : {numberLength}");
    Console.WriteLine($"Position : {position}");
    int positionFromRight = numberLength - position - 1;

    int devider = 1;
    for (int i = 0; i < positionFromRight; i++)
    {
        devider *= 10;
    }

    int result = number / devider % 10;
    return result;
}

// Работает только с положительными значениями
bool isPalindrome(int number)
{
    int length = getCharLength(number);

    if (number <= 0)
    {
      Console.WriteLine("Ошибка: число должно быть положительным");
        return false;
    }

    if (length <= 1)
    {
      Console.WriteLine("Ошибка: число должно быть длиннее");
        return false;
    }

    for (int i = 0; i < length / 2; i++)
    {
        int left  = getCharByPosition(number, i);
        int right = getCharByPosition(number, length - i - 1);
Console.WriteLine($"Left : {left}");
Console.WriteLine($"Right : {right}");
        if (left != right)
        {
            return false;
        }
    }
    return true;
}

    Console.WriteLine("Введите любое целое положительное значение, чтобы проверить, является ли оно палиндромом:");

    int number = -1;
    number = Convert.ToInt32(Console.ReadLine());
    bool result = isPalindrome(number);

    if (result == true)
    {
          Console.WriteLine($"Это значение {number} полиндром!");
    }
    else
    {
          Console.WriteLine($"Это значение {number} не полиндром!");
    }

    return 0;
*/