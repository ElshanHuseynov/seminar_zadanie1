System.Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"{num1} больше, чем {num2}");
}
else if (num1 < num2)
{
    System.Console.WriteLine($"{num1} меньше, чем {num2}");
}
else
{
    System.Console.WriteLine($"{num1} равно {num2}");
}