using System;
    class Program
{
static void Main()
    {
 Console.Write("Введіть значення: ");     
double number = Convert.ToDouble(Console.ReadLine());
        int decimalPart = (int)((number - Math.Floor(number)) * 100);
    int digit1 = decimalPart / 10;
    int digit2 = decimalPart % 10;
    int sum = digit1 + digit2; //Задаємо умови для розділення числа на цифри та виведення суми перших дву цифр числа після коми
    Console.WriteLine($"{digit1} + {digit2} = {sum}");
        }
}
