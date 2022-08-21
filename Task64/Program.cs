// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в
//  промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

string OutputOfNumbers(int m, int n)
{
    if (n >= m) return OutputOfNumbers(m, n - 1) + $"{n} ";
    else return string.Empty;
}

Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(OutputOfNumbers(m, n));