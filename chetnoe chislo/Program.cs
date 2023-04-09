Console.Write("Ведите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    System.Console.WriteLine($" Число {num} является четным! ");
}
else
{
    System.Console.WriteLine($"Число {num} является нечетным! ");
}