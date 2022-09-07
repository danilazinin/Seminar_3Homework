

Console.WriteLine("Введите координаты первой точки");
string[] values = Console.ReadLine().Split(new char[] { ',' });
int x1 = int.Parse(values[0]);
int y1 = int.Parse(values[1]);
int z1 = int.Parse(values[2]);

Console.WriteLine("Введите координаты второй точки");
string[] values_2 = Console.ReadLine().Split(new char[] { ',' });
int x2 = int.Parse(values_2[0]);
int y2 = int.Parse(values_2[1]);
int z2 = int.Parse(values_2[2]);
    
double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);

Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) ->  {result}");
