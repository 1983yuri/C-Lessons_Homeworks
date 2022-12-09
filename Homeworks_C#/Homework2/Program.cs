/*Домашняя работа 2
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
*/