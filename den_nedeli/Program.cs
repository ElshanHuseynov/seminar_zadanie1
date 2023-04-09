System.Console.WriteLine("Введите день недели (1-7:) ");
int dayOfWeek = int.Parse(Console.ReadLine());

if (dayOfWeek == 6 || dayOfWeek == 7)
{
    System.Console.WriteLine("Это выходной день ");
}
else
{
    System.Console.WriteLine("Это рабочий день ");
}