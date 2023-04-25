int[] arr = new int[10];
Random random = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(100, 1000);
}

Console.WriteLine("Элементы массива:");

int count = 0;

foreach (int element in arr)
{
    Console.WriteLine(element);
    if (element % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чётных чисел в массиве: {count}");
    