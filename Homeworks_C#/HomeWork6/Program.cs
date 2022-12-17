// Домашняя работа 6
//Задача 1 ( Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь)

int SunOfPosNum(int sizenum)
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
int result = SunOfPosNum(sizenum);
Console.WriteLine($"The number of positive {result}");
