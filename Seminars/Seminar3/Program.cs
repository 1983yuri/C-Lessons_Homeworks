/*
Семинар 3
Задача 1 (Пользователь вводит координаты точки "x" и "y", а программа выдает в какой четверти на шкале координат она находится)

int FindQuadrant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input an x-coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an y-coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadNum = FindQuadrant(xA, yA);

Console.WriteLine($"The point A({xA}, {yA}) is on the {quadNum} quadrant");



Задача 2 (Пользователь вводит четверть на шкале координат, а программа выдает какие значения может принимать координата)


void Coor(int chetv)
{
    if(chetv == 1)
    {
Console.WriteLine("In a given quarter, the range of x coordinates is from 0 to + infinity, of y from 0 to + infinity");
    }
    if(chetv == 2)
    {
Console.WriteLine("In a given quarter, the range of x coordinates is from 0 to - infinity, of y from 0 to + infinity");
    } 
    if(chetv == 3)
    {
Console.WriteLine("In a given quarter, the range of x coordinates is from 0 to - infinity, of y from 0 to - infinity");
    } 
    
    if(chetv == 4)
    {
Console.WriteLine("In a given quarter, the range of x coordinates is from 0 to + infinity, of y from 0 to - infinity");
    }
    if(chetv > 4 || chetv < 1)
    {
Console.WriteLine("This quarter does not exist!");        
    }
  
}

Console.WriteLine("Set quarter number from 1 to 4: ");
int chetvert = Convert.ToInt32(Console.ReadLine());

Coor(chetvert);


Задача 3 (Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве)

double Lenght(double x1, double y1, double x2, double y2)
{
return Math.Sqrt (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));    
}

Console.WriteLine("Введите координату х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double lenght = Lenght(x1, y1, x2, y2);

Console.WriteLine($"Расстояние между двумя точками равно: {lenght}");

Задача 4 (Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.)
*/

void QuadToN(int num) 
{
int current = 1; 
while(current <= num)
{   
    Console.Write(Math.Pow(current, 2) + " "); // Начинаем с 1 и возводим в степень 2 пока current <= num
    current++;    
}
}

Console.Write("Input an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
QuadToN(number);