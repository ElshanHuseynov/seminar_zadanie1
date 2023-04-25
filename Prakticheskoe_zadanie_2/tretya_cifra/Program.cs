System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int thirdDigit = (number / 1) % 10;
    Console.WriteLine("Третья цифра введенного числа: " + thirdDigit);
}
else
 {
     Console.WriteLine("Третьей цифры НЕТ! ");
 }
