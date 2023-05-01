// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

void Palindrome(int number)
{
    int originalNumber = number;
    int reverseNumber = 0;

    while (number != 0)
    {
        reverseNumber = reverseNumber * 10 + number % 10;
        number /= 10;
    }
    if (originalNumber == reverseNumber)
    {
        Console.WriteLine("Это палиндром!");
    }
    else
    {
        Console.WriteLine("Это не палиндром.");
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);