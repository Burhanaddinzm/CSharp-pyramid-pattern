int n, x, y, z;
Console.WriteLine("Input row count:");
int.TryParse(Console.ReadLine(), out n);
if (n <= 60)
{
    for (x = 1; x <= n; x++)
    {
        for (y = 1; y <= n - x; y++)
        {
            Console.Write(" ");
        }
        for (z = 1; z <= x; z++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}
else
    Console.WriteLine("Can't input more that 60 rows!");