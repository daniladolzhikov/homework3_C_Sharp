// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int N) 
{
    int count = 1;
    while (count <= N)
    {
        Console.WriteLine(count + " - " +count*count*count);
        count++;
    }
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Cube(N);
