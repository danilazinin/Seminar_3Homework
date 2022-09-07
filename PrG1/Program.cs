Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine());
if (a < 100000 && a > 10000)
{
  int a1 = a/10000;
  int a2 = a/1000%10;
  int a5 = a%10;
  int a4 = a%100/10;
  if (a1 == a5 && a2 == a4)
  {
    Console.WriteLine($"{a} -> да");
  }
  else 
  {
    Console.WriteLine($"{a} -> нет");
  }
}
else
{
    Console.WriteLine("Введите пятизначное число");
}

