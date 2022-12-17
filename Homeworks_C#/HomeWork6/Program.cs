// Домашняя работа 6
//Задача 1 ( Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь)
/*
int SumOfPosNum(int sizenum)
{
   int count = 0;
   int numOfnum = 0;
   int nums = 0;
   while(sizenum > 0)
   {
     Console.WriteLine($"Input the {numOfnum +1} number:");
     nums = Convert.ToInt32(Console.ReadLine());
     numOfnum++;
     sizenum--;

     if(nums > 0)
       count++;
   }
   return count;
}

Console.WriteLine("How many numbers will you input?");
int sizenum = Convert.ToInt32(Console.ReadLine());
int result = SumOfPosNum(sizenum);
Console.WriteLine($"The number of positive is: {result}");


// Задача 2 ( Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем)
*/

Console.WriteLine("Input the number b1 responsible for the location relative to the Y axis:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input angular coefficient k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number b2 responsible for the location relative to the Y axis:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input angular coefficient k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
    if (k1 == k2 && b1 != b2)
        Console.WriteLine("These lines do not intersect!");
    if (k1 == k2 && b1 == b2)
        Console.WriteLine("These lines intersect at all points!");
double x = 0;
    x = (-b2 + b1) / (-k1 + k2);
double y = 0;
    y = k2 * x + b2;

Console.WriteLine($"The intersection point has coordinates: x = {x} y = {y}");
