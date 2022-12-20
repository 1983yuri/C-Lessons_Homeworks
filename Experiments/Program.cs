// Задача про двух друзей и собаку
/*
int FriendsVsDog(double distance, int firstFriendSpeed, int secondFriendSpeed, int dogSpeed)
{
    int count = 0;
    int friend = 2;
    double time = 0;

while(distance > 10)
{
  if(friend == 1)
      {
      time = distance / (firstFriendSpeed + dogSpeed);
      friend = 2;
      distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
      count++;
      }
  else
      {
      time = distance / (secondFriendSpeed + dogSpeed);
      friend = 1;
      distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
      count++; 
      }     
}
return count;
}


Console.WriteLine("Enter the distance in meters: ");
double distance = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a first friend speed: ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a second friend speed: ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a dog speed: ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

int friendvsdog = FriendsVsDog(distance, firstFriendSpeed, secondFriendSpeed, dogSpeed);


Console.Write($"The dog will run from one friend to the second friend: {friendvsdog} times!");



int[] FillArray(int size, int minValue, int maxValue)
{
    int i = 0;
    int[] array = new int[size];
    while(i < size)
   {
    array[i] = new Random().Next(minValue, maxValue -1); 
    i++;
   }
   return array;
}

void ShowArray(int[] array)
{
    int i = 0;
    int j = 0;
    while(i < array.Length)
    {
      Console.WriteLine($" element [{j + 1}] is {array[i]}");
      i++;
      j++;
    }
    
}

Console.WriteLine("Input the array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of the array size: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = FillArray(size, minValue, maxValue);
ShowArray(myArray);


// Объектно - ориентированное
class Person
 {
 public string firstName;
 public string lastName;

 public void ShowFullName()
 {
Console.WriteLine($"Name is “ {firstName} {lastName}");
 }
 }

Petr = new Person();
Petr.firstName = “Petr”;

Petr.ShowFullName();
*/