Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (number < 10000 || number > 99999) 
{
    Console.WriteLine("Число должно быть пятизначным!");
    return;
}
string numberString = number.ToString();
 for (int i = 0, j = numberString.Length - 1; i < j; i++, j--) 
 {
        
    if (numberString[i] != numberString[j]) 
    {
            Console.WriteLine("Число не является палиндромом");
            return;
    }
}
Console.WriteLine("Число является палиндромом");
    