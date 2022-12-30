// Домашняя работа 9

// Задача 1 (Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии)
/*
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

} 

Console.WriteLine("Input the value of the number: ");
int nums = Convert.ToInt32(Console.ReadLine()); 
ShowNumbers(nums); 
*/

// Задача 2 (Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N)

int SumNumbersOfSection (int numM, int numN)

{
    if (numM < numN) return SumNumbersOfSection(numM, numN - 1) + numN; 
    else if (numM > numN) return SumNumbersOfSection(numM - 1, numN) + numM;
    else return numM;
}

Console.WriteLine("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbersOfSection(numM, numN);
Console.WriteLine($"The sum of numbers of section from number M to number M is: {sum}");

                         


