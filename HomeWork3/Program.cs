
// Напишите программу, которая принимает
// на вход  число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
//KolNum(num);
int sum = KolNumOne(num);
Itog(sum, num);
void Itog(int sum, int number)
{
 Console.WriteLine(sum);
 int ii = 10; 
  int count = sum % 10;
  int i = (sum - count) / ii;
  int numLev = 0;
  int numPr = 0;
  for(;numLev == numPr && number > 9;)
  {
   numLev = number / i ;
   numPr = number % 10 ;
  Console.WriteLine($"Number {number},NumLev {numLev}, NumPr {numPr}");
  number = (number % i) / 10;
  Console.WriteLine($"Number {number}");
      if(number  > 9 && number < 100 )
          {
             numLev = number / i;
             numPr =  number % 10;
             Console.WriteLine($"Number if {number},NumLev {numLev}, NumPr {numPr}");
             if (numLev == numPr)
                {
                  Console.WriteLine($"ДА!!!");
                  break;
                }
          }
      else
         {
            ii = ii * 10;
            i = i / ii;
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

void KolNum(int number)
{
   
     if(number < 10) Console.WriteLine("Число однозначное");   
}
 */

//Задача № 21
//Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.

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

 distance(x1, y1, z1,
             x2, y2, z2);
void distance(float x1, float y1,
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