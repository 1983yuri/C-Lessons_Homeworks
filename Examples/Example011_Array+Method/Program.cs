void FillArray(int[] collection) // Метод заливки массива
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // Метод печати массива
{
  int count = col.Length;
  int position = 0;
  while(position < count)
  {
    Console.WriteLine(col[position]);
    position++;
  }  
}

int IndexOf(int[] collection, int find) // Метод поиска нужного элемента массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
      if(collection[index] == find)
      {
        position = index;
        break;
      }
      index++;  
    }
    return position;
}

int[] array = new int[10];
FillArray(array); // Методы мы описали выше самостоятельно
array[4] = 4; // Вручную заполнили позиции по индексу в массиве для теста
array[7] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 453); // Ищем значение, которое заведомо отсутствует для теста
Console.WriteLine(pos);