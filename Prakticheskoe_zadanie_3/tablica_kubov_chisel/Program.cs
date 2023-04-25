class Program {
    static void Main(string[] args) 
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Таблица кубов чисел от 1 до " + n + ":");
        for (int i = 1; i <= n; i++) 
        {
            Console.WriteLine(i + "^3 = " + Math.Pow(i, 3));
        }

        Console.ReadLine();
    }
}
