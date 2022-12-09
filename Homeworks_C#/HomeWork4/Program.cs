/*
Задача с семинара 1, ЦИКЛ "for" (Напишите программу, которая выводит на экран сумму чисел от 1 до N)

int SumN(int num)
{    
    int result = 0; // Перед циклом for, лучше сразу инициализировать переменную для записи результата
    for(int count = 1; count <= num; count++)
    {
        result += count; // Тоже самое, что result = result + count
    }
    return result;
}

Console.WriteLine("Input integer number: ");
int usernum = Convert.ToInt32(Console.ReadLine());

int sumN = SumN(usernum);
Console.WriteLine($"Sum of numbers from 1 to {usernum} is {sumN}");


Задача с семинара 2, ЦИКЛ "for" (Напишите программу, которая выводит на экран факториал чисел от 1 до N)
*/

int Fact(int num)
{
    int result = 1; // Начинаем с 1 т.к. умножение на 0 даст в итоге 0, если пользователь введет 0, цикл не сработает и выдаст результат = 1
    for(int count = 2; count <= num; count++)
    {
        result *= count; // Тоже самое, что result = result * count
    }
    return result;
}

Console.WriteLine("Input an integer number: ");
int usernum = Convert.ToInt32(Console.ReadLine());

int sumMult = Fact(usernum);
Console.WriteLine($"The factorial of {usernum} is {sumMult}");
