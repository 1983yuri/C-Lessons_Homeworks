int count = 0;
double distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int friend = 2;
double time = 0;


while(distance > 10)
{
  if(friend == 1)
      {
      time = distance / (FirstFriendSpeed + DogSpeed);
      friend = 2;
      distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
      count++;
      }
  else
      {
      time = distance / (SecondFriendSpeed + DogSpeed);
      friend = 1;
      distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
      count++;
      }         
}
Console.Write(count);

    

