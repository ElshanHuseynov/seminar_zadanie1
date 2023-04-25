double[] arr = { 1.5, 3.7, 2.1, 4.8, 0.9, 2.4, 5.2, 3.0 };

double max = arr[0];
double min = arr[0];

     
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    else if (arr[i] < min)
    {
        min = arr[i];
    }
}

double diff = max - min;

Console.WriteLine($"Максимальный элемент массива: {max}");
Console.WriteLine($"Минимальный элемент массива: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");
    