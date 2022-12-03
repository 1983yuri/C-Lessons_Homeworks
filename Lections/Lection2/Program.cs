// int CutNimber(int num)
// {
//     int ed = num % 10;
//     int sot = num / 100;

//     int result = sot * 10 + ed;
//     return result;
// }

// int runnum = new Random().Next(100, 1000);
// int newnum = CutNimber(runnum);

// Console.WriteLine($"New version of number {runnum} is {newnum}");

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int MaxNum(int num)
// {
//     int ed = num % 10;
//     int ten = num /10;
//     int result;
//     if(ed > ten)
//         result = ed;
//     else
//         result = ten;
//     return result;
// }

// int newnum = new Random().Next(10, 100);
// int max = MaxNum(newnum);

// Console.WriteLine($"Random number is {newnum} max num {max}");



//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

// bool Krat(int num1, int num2, int num3)
// {
//     int div1 = num1 % num2;
//     int div2 = num1 % num3;
//     if(div1 == 0 && div2 == 0)
//         return true;
//     else
//         return false;
// }

// Console.Write("Input number 1 ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 2 ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 3 ");
// int numC = Convert.ToInt32(Console.ReadLine());

// bool result = Krat(numA, numB, numC);
//  Console.WriteLine(result);

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool Kvad(int num1, int num2)
{
    int result1 = num1 * num1;
    int result2 = num2 * num2;
    if(result1 == num2 || result2 == num1)
        return true;
    else
        return false;
}

Console.Write("Input number 1 ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2 ");
int numB = Convert.ToInt32(Console.ReadLine());

bool result = Kvad(numA, numB);
Console.WriteLine(result);