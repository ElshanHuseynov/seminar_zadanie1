// Console.Write("Введите число N: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.WriteLine("Чётные числа от 1 до N:");
//         for (int i = 2; i <= n; i += 2)
//         {
//             Console.Write(i + " ");
//         }


int[] Random(int number)
{
    int[] result = new int[number];
    for (int y = 0; y < number; y++)
        result[y] = (new Random().Next(0, 2));
    return result;
}
Console.Write("Введите количество цифр: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(String.Join(", ", Random(number)));