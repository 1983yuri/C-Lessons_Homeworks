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

// Метод для вывода массиваб потому что не работают Write и Read 
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


