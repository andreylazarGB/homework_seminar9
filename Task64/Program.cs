// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

Console.Clear();

int M = Prompt("Введите первое значение: ");
int N = Prompt("Введите второе значение: ");
PrintValue(M, N);

int Prompt(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintValue(int m, int n)
{
    if (m > n) return;
    if (m %2 == 0) Console.Write($"{m} ");
    PrintValue(m + 1, n);
}