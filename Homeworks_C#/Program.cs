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

Домашняя работа 3
Задача 1 (Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом)
Вариант - частный

void Pal(int num) // Элементарное решение для 5 значного числа без цикла, далее общее решение
{
 if(num % 10 == num / 1000000 && // 
    num % 100 / 10 == num / 100000 % 10)
 {
 Console.WriteLine("This number is palindrom!");
 }
 else
 {
 Console.WriteLine("This number is not a palindrome!");
 }
 }
 
Console.WriteLine("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Pal(num);

Вариант решения общий

void Pal(int num)
{
  int revers = 0;
  int temp = num;
  while(temp > 0)
  {
    revers = revers * 10 + temp % 10; // Формируем реверсное число по одному элементу
    temp = temp / 10; // Отсекаем по одному элементу справа налево от изначального числа 
  }
  if(revers == num)
  {
    Console.WriteLine($"This number -  {num} is a polindrom!");
  }
  else
  {
    Console.WriteLine($"This number -  {num} is not a polindrom!");
  }
}
Console.WriteLine("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Pal(num);

Задача 2 (Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве)


double Lenght(double x1, double y1, double z1, double x2, double y2, double z2)
{
return Math.Round(Math.Sqrt (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2); // Теорема пифагора для куба + округление значения до 2 знаков после запятой   
}

Console.WriteLine("Введите координату х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double lenght = Lenght(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстояние между двумя точками равно: {lenght}");

Задача 3 (Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N)
*/

void CubeToN(int num) 
{
int current = 1; 
while(current <= num)
{   
    Console.Write(Math.Pow(current, 3) + " "); // Начинаем с 1 и возводим в степень 3 пока current <= num
    current++;    
}
}

Console.Write("Input an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeToN(number);
