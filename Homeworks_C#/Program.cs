/* Домашняя работа 1
Задача 1 (Напишите программу, которая на вход принимает 2 числа а на выходе выдает какое больше, а какое меньше)

bool WhoIsBiggest(int num1, int num2)
{
if(num1 > num2)
{
return true;
}
else
{
return false;
}
}

Console.WriteLine("Input a first number: ");
 int  numb1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input a second number: ");
 int  numb2 = Convert.ToInt32(Console.ReadLine());

 bool result = WhoIsBiggest(numb1, numb2);
 
 if(result == true)
 {
 Console.WriteLine($"largest number is {numb1} ; smallest number is {numb2}");
 }
 else
 {
 Console.WriteLine($"largest number is {numb2} ; smallest number is {numb1}");
 }
   
   

Задача 2 (Напишите программу, которая на вход принимает 3 числа а на выходе выдает максимальное из этих чисел)


int ThreeMaxDigitNumber(int num1, int num2, int num3)
{
if(num1 > num2)
 {
   int max = num1;
   return max;
 }
 else if(num2 > num3)
 {
   int max = num2;
   return max;
 }
  else
 {
  int max = num3;
  return max;
 }
}
Console.WriteLine("Input a first number: ");
 int  number1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input a second number: ");
 int  number2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input a third number: ");
 int  number3 = Convert.ToInt32(Console.ReadLine());

 int max = ThreeMaxDigitNumber(number1, number2, number3);
 
 
 
 Console.WriteLine($"largest number from: {number1} ; {number2} ; {number3} is {max}");

 
 

Задача 3 (Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка))

bool EvenOdd(int num)
{
if(num % 2  == 0)
{
  return true; 
}
else
{
  return false;
}
}

Console.WriteLine("Input a number: ");
 int  num = Convert.ToInt32(Console.ReadLine());
 
 bool result = EvenOdd(num);

 if(EvenOdd(num) == true)
 {
 Console.WriteLine("this number is even");
 }
 else
 {
 Console.WriteLine("this number is odd");
 }
 

Задача 4 (Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N)
void EvenToN(int num)
{
int current =2; // потому, что нам нужны только четные, начинаем с 2
while(current <= num)
{
    Console.Write(current + " "); // Сделал более простое решение и более краткое
    current = current + 2; // Шагаем через цифру, при этом не нужно проверять на четность!    
}
}

Console.Write("Input an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
EvenToN(number);
 

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

/*
Задача 2 (Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет)
/*
int CutThirdDigit(int number)
{
  while(number > 999)
    {
    number = number / 10; 
    }
    int thirdNum = number % 10;
    return thirdNum;
}

    Console.WriteLine("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());

        
     if(num < 100)
  {
    Console.WriteLine("Entered number does not have a third digit");
  }
    else
  {
    int cut = CutThirdDigit(num);
    Console.WriteLine($"The third digit of number {num} is {cut}");  
  }


Задача 3 (Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным)
*/

bool SanD(int num)
{
  if(num == 6 || num == 7)
  {
  return true;
  }
  else
  {
  return false;
  }
}

Console.WriteLine("Enter a number representing the day of the week from 1 to 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 1 || num > 7)
{
Console.WriteLine("There is no such day of the week!");
}
else
{
bool sandays = SanD(num);

if(sandays == true)
{
  Console.WriteLine("This day is day off!");
}
else
{
  Console.WriteLine("This day is not a day off!");
} 
}
