
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int i = 1;
while (i <= N)
{
    Console.WriteLine($"{i} -> {Math.Pow(i, 3)}");
    i++;
}

