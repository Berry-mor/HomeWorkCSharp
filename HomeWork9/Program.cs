
//Задача 64: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.

/*
void PrintNumbers(int n)
{
    Console.Write(n + " ");
    if(n > 1) PrintNumbers(n - 1);
    
}
PrintNumbers(5);
*/

//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int RecursionSunNumbers(int m, int n)
{
    if (m <= n) return RecursionSunNumbers(m + 1, n) + m;
    return 0;
}

Console.Write(RecursionSunNumbers(1, 15));
Console.WriteLine();
Console.Write(RecursionSunNumbers(4, 8));
*/

//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

uint Akkerman(uint n, uint m)
{
    if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
uint rez = Akkerman(2,3);
Console.Write(rez + "  ");
rez = 0;
rez = Akkerman(3,2);
Console.Write( rez);