
/*
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


void Coor(int chetv)
{
    if(chetv == 1)
    {
Console.WriteLine("В данной четверти диапазон координат x от 0 до + бесконечности по y от 0 до + бесконечности");
    }
    if(chetv == 2)
    {
Console.WriteLine("В данной четверти диапазон координат x от 0 до - бесконечности по y от 0 до + бесконечности");
    } 
    if(chetv == 3)
    {
Console.WriteLine("В данной четверти диапазон координат x от 0 до - бесконечности по y от 0 до - бесконечности");
    } 
    
    if(chetv == 4)
    {
Console.WriteLine("В данной четверти диапазон координат x от 0 до + бесконечности по y от 0 до - бесконечности");
    }
  
}

Console.WriteLine("Введите номер четверти: ");
int chetvert = Convert.ToInt32(Console.ReadLine());

Coor(chetvert);
*/

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
