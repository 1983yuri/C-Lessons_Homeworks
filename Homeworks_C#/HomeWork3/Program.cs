/*Домашняя работа 3
Задача 1 (Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом)
Вариант - частный

void Pal(int num) // Элементарное решение для 5 значного числа без цикла, далее общее решение
{
 if(num % 10 == num / 10000 &&  
    num % 100 / 10 == num / 1000 % 10)
 {
 Console.WriteLine("This number is a palindrom!");
 }
 else
 {
 Console.WriteLine("This number is not a palindrome!");
 }
 }
 
Console.WriteLine("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Pal(num);
/*
Вариант решения общий

void Pal(int num)
{
  int revers = 0;
  int temp = num;
  while(temp > 0)
  {
    revers = revers * 10 + temp % 10; // Формируем реверсное число по одному элементу на каждой итерации
    temp = temp / 10; // Отсекаем по одному элементу справа налево от изначального числа на каждой итерации
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
*/
