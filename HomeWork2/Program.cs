// Напишите программу которая на вход принимаеттрехзначное число и на выходе показывает вторую цифру этого числа
/*
int Dogs(int number)
{
    int rez = ((number % 100) / 10);
    return rez;
}

Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

int pup = Dogs(num);
Console.WriteLine();
Console.WriteLine(pup);
*/
//ЗАДАЧА 13
//Напишите программу  которая выводит третью цифру заданного числа или сообщает что третьей цифры нет
/*
void Dobs(int number)
{
    int i = 10000;
    int count = 0;
    int c = 100;
    if(number >= 100 && number < 1000)
    {
        c = number %  10;
        
        Console.WriteLine(c);
    }
    else 
    {
        for(int a = 0; a < 10; a++)
        {
            if(number > 999 && number / i != 0)
            {
                i = i * 10;
                c = c * 10;
            }
            else
            {
                count = (number / (c / 10)) % 10 ;
                Console.WriteLine(count);
                break;
            }
        } 
        

    }
    
}

void Dogs(int number)
{
     if (number < 100 )
    {
         Console.Write("Третьей цифры нет ");
    }
    else
    {
        Dobs(number);
    }
}
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Dogs(num);
*/

//ЗАДАЧА 15
//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
/*
void Dogs(int num)
{

    if(num < 10)
    {
        if(num == 6 || num == 7) 
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
        
    }
}
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Dogs(num);
*/