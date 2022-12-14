// Домашняя работа 5 // Методы создания и заполнения массива случайными числами и его вывод в консоль в начале

int[] CreateRandomArray(int size, int minValue, int maxValue) // Метод создания и заполнения массива числами в заданном диапазоне
{
    int[] array = new int[size]; // Инициализации массива, выделение памяти

    for(int i = 0; i < size; i++)
    {          
        array[i] = new Random().Next(minValue, maxValue + 1);  // +1 потому, что [)    
    }
    return array; // Возвращаем просто имя массива!!!
}

 

void ShowArray(int[] array) // Метод вывода массива в консоль
{
    for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine($"array[{i + 1}] is {array[i]}"); 
    }
}

// Задача 1 (Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.)


Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min element of the array, a three-digit positive number: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the max element of the array, a three-digit positive number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

int EvenOdd(int[] myArray)
{
   int count = 0; 
for(int i = 0; i < myArray.Length; i++)
{
   if(myArray[i] % 2 == 0)
      count++;
}
return count;
}

ShowArray(myArray);
int oddnum = EvenOdd(myArray); 

if(min < 100 || max > 1000)
  Console.WriteLine("You inputed a numbers outside the required range!");
else
  Console.WriteLine($"The number of even elements in the array is: {oddnum}");

   

