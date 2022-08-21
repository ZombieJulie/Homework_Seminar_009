/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. */

Console.WriteLine("Задайте значение M (должно быть меньше N): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение N (должно быть больше М): ");
int n = int.Parse(Console.ReadLine());

int GetSum(int m, int n)
{
    if (m > n) return 0;
    if (n == m) return n;
    return m + GetSum(m + 1, n);
}
Console.Write($"Сумма натуральных элементов между {m} и {n} = {GetSum(m, n)}");

if (m > n)
{
    Console.Write(" (не удается вычислить - некорректно введены данные).");
}
