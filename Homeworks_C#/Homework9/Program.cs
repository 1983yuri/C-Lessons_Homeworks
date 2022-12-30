// Домашняя работа 9

// Задача 1 (Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии)

void ShowNumbers(int n)
{
    if (n > 1)                           // Рекурсивно
    {
        Console.Write(n + " ");
        ShowNumbers(n - 1);
    }
    if (n < 1) 
    {
        Console.Write(n + " ");
        ShowNumbers (n + 1);       
    }
    if (n == 1)
    {
        Console.Write(n + " ");
    }

/*   
    if(n > 0)                           // Интеративно
    {
        while(n >= 1)
        {
            Console.Write(n + " ");
            n--;
        }     
    }
    else if(n < 0)
    {
        while(n <= 1)
        {
            Console.Write(n + " ");
            n++;
        }
    }
*/
} 

Console.WriteLine("Input the value of the number: ");
int nums = Convert.ToInt32(Console.ReadLine()); 
ShowNumbers(nums); 


// Задача 2 ()

                         


