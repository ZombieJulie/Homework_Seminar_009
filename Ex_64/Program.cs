/* Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N. */

Console.WriteLine("Задайте значение N (должно быть больше M): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение M (должно быть меньше N): ");
int m = int.Parse(Console.ReadLine());

string GetNaturalNumber(int a, int b)
{
    if (a >= b) return $"{a} " + GetNaturalNumber(a - 1, b);
    else return ""; 
}

Console.WriteLine(GetNaturalNumber(n, m));

if (n < m)
{
    Console.WriteLine("Некорректно введены данные.");
}
