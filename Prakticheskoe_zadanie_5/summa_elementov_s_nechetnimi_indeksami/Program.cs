int[] arr = new int[10];
Random random = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(1, 101);
}

Console.WriteLine("Элементы массива:");

int sum = 0;

for (int i = 1; i < arr.Length; i += 2)
{
    Console.WriteLine(arr[i]);
    sum += arr[i];
}

Console.WriteLine($"Сумма элементов с нечётными индексами: {sum}");