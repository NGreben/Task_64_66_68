/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m, n;
Console.Write("Введите М: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write("Введите N: ");
int.TryParse(Console.ReadLine(), out n);

Console.Write($"-> {OutNumbers(m, n)}");

int OutNumbers(int m, int n)
{
    int sum = m;
    if (m == n)
        return sum;
    return sum += OutNumbers(m + 1, n);
}