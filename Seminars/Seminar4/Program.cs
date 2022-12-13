/*
int NumOfDigits(int num)
{
    int count = 0;

    while(num != 0)
    if(num == 0) count = 1;
    {
        count++; // Без разницы сначала расчет, потом счетчик или наоборот
        num /= 10; // тоже самое, что num = num / 10;
    }
    return count;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumOfDigits(number);

Console.WriteLine($"Number of digits in {number} is {result}");

/*
Задача 1 с семинара , ЦИКЛ "for" (Напишите программу, которая выводит на экран сумму чисел от 1 до N)

int SumN(int num)
{    
    int result = 0; // Перед циклом for, лучше сразу инициализировать переменную для записи результата
    for(int count = 1; count <= num; count++)
    {
        result += count; // Тоже самое, что result = result + count
    }
    return result;
}

Console.WriteLine("Input integer number: ");
int usernum = Convert.ToInt32(Console.ReadLine());

int sumN = SumN(usernum);
Console.WriteLine($"Sum of numbers from 1 to {usernum} is {sumN}");


Задача 2 с семинара , ЦИКЛ "for" (Напишите программу, которая выводит на экран факториал чисел от 1 до N)


int Fact(int num)
{
    int result = 1; // Начинаем с 1 т.к. умножение на 0 даст 0 и программа не будет работать, если пользователь введет 0, цикл не сработает и выдаст результат = 1
    for(int count = 2; count <= num; count++)
    {
        result *= count; // Тоже самое, что result = result * count
    }
    return result;
}

Console.WriteLine("Input an integer number: ");
int usernum = Convert.ToInt32(Console.ReadLine());

int sumMult = Fact(usernum);
Console.WriteLine($"The factorial of {usernum} is {sumMult}");


Массивы(Метод заполнения массива случайными числами в заданном диапазоне)
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // Инициализации массива, выделение памяти

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);  // +1 потому, что [)
    }
    return array; // Возвращаем просто имя массива!!!
}

// Метод для вывода массива 
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        
      Console.WriteLine($"array[{i + 1}] is {array[i]}"); //Рабочий вариант но не очень подходящий
    }
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min number of elements: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max number of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);


