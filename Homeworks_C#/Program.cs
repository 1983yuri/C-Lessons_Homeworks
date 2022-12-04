/* Домашняя работа 1
Задача 1 (Напишите программу, которая на вход принимает 2 числа а на выходе выдает какое больше, а какое меньше)

Console.WriteLine("Input a first number: ");
 int  num1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input a second number: ");
 int  num2 = Convert.ToInt32(Console.ReadLine());
 
 if(num1 > num2)
 {
  Console.WriteLine("largest number is " + num1 + ";" + " smallest number is " + num2);  
 }
 else
{
  Console.WriteLine("largest number is " + num2 + ";" + " smallest number is " + num1);  
}

Задача 2 (Напишите программу, которая на вход принимает 3 числа а на выходе выдает максимальное из этих чисел)

Console.WriteLine("Input a first number: ");
 int  num1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input a second number: ");
 int  num2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input a third number: ");
 int  num3 = Convert.ToInt32(Console.ReadLine());

 int max = num1;
 

 if(num1 > num2)
 {
   max = num1;
 }
 else
 {
   max = num2;
 }
 if(max > num3)
 {
 Console.WriteLine("largest number is " + max);
 }
 else
 {
 Console.WriteLine("largest number is " + num3);
 }
 

Задача 3 (Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка))

Console.WriteLine("Input a number: ");
 int  num = Convert.ToInt32(Console.ReadLine());

 if(num % 2  == 0)
 {
 Console.WriteLine("this number is even");
 }
 else
 {
 Console.WriteLine("this number is odd");
 }

 
Задача 4 (Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N)

Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2; // потому, что нам нужны только четные, начинаем с 2

while(current <= num)
{
   // if(current % 2 ==0)
   // {
    Console.Write(current + " "); // Сделал более простое решение и более краткое
        current = current + 2; // Шагаем через цифру, при этом не нужно проверять на четность! 
   // }
   // else
   // {
   // current++;   
   // }
}


Домашняя работа 2
Задача 1 (Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа)

int CutSecondNumber(int number) // Метод выделения второго числа
{
    int cutThird = number / 10;
    int cutSecond = cutThird % 10;
    return cutSecond;
}

bool ChekingDigit(int num) // Метод проверки числа на 3х значность
{
    if (num < 100 || num > 1000)
    {
        return false;
    }
    else
    {
        return true;
    }
}

Console.WriteLine("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());


if (ChekingDigit(num) == true)
{
    int cutsecond = CutSecondNumber(num);
    Console.WriteLine($"New version number {num} is {cutsecond} ");
}
else
{
    Console.WriteLine("The entered number is not three digits!");
}


Задача 2 (Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет)
*/
int CutThirdDigit(int number)
{
  while(number > 999)
    {
    number = number / 10; 
    }
    int thirdNum = number % 10;
    return thirdNum;
}

int CheckNum(int num)
{
if(num < 100)
  {
   num =-1;
   return num; 
  }
   return num; 
}

    

    Console.WriteLine("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int checknum = CheckNum(num);
    int cut = CutThirdDigit(num);

    Console.WriteLine($"The third digit of number {num} is {cut}");
    /* if(num < 100)
  {
    Console.WriteLine("Entered number does not have a third digit");
  }
    else
  {
    int cut = CutThirdDigit(num);
    Console.WriteLine($"The third digit of number {num} is {cut}");  
  }
   */
  
