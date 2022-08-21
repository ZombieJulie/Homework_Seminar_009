/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. */

Console.WriteLine("Задайте значение натурального числа m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение натурального числа n: ");
int n = int.Parse(Console.ReadLine());

int GetAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return GetAckermann(m - 1, 1);
    else return GetAckermann(m - 1, GetAckermann(m, n - 1));    
}

Console.WriteLine($"Функция Аккермана = {GetAckermann(m, n)}.");
