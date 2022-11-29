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
*/
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
 
 