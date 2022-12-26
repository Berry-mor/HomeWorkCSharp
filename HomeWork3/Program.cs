// Напишите программу, которая принимает
// на вход  число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
KolNum(num);
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
      /*if(number  > 9 && number < 100 )
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
         }*/
  ii = ii * 10;
  i = i / ii;
  }
    /*if (numLev == numPr && number < 9)
      {
          Console.WriteLine("ДА");
      }
    else
      {
         Console.WriteLine("НЕТ");
       }*/
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
 