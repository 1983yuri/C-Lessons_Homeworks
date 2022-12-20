
int[] CreateRandomArray(int size, int minValue, int maxValue) // Метод создания и заполнения массива числами в заданном диапазоне
{
    int[] array = new int[size]; // Инициализации массива, выделение памяти

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);  // +1 потому, что [)
    }
    return array; // Возвращаем просто имя массива!!!
}
/*
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min number of elements: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max number of elements: ");
int max = Convert.ToInt32(Console.ReadLine());
 
*/
void ShowArray(int[] array) // Метод вывода массива в консоль
{
    for(int i = 0; i < array.Length; i++)
    {
        
      Console.WriteLine($"array[{i + 1}] is {array[i]}"); //Рабочий вариант но не очень подходящий
    }
}
/*
// Метод переворачивания массива, задача

void ReversArray(int[] array) // Если метод void можно вывести результат без присвоения переменной
{
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
}

int[] maArray = CreateRandomArray(size, min, max);
ShowArray(maArray);
ReversArray(maArray);
ShowArray(maArray); 

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины
bool Treug(int a, int b, int c)
{
    if(a + b > c && a + c > b && b + c > a)
    return true;
    else
    return false;    
}

Console.WriteLine("Введите стороны треугольника: a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите стороны треугольника: b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите стороны треугольника: c:");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Treug(a, b, c));

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
int[] Fib(int a, int b, int n)
{
    int[] array = new int[n]; 
    array[0] = a;
    array[1] = b;
     for(int i = 2; i < array.Length; i++)
     {
        array[i] = array[i -1] + array[i -2];
     }
     return array;
}

Console.WriteLine("Input: number a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input: number b ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input: length output number n ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fib(a, b, n);
ShowArray(myArray);
*/

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] Copy(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
       newArray[i] = array[i];
    }
    return newArray; 
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min number of elements: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max number of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine("Our Array is:");
ShowArray(myArray);
int[] copyArray = Copy(myArray);
Console.WriteLine("The copy of our Array is:");
ShowArray(copyArray);

