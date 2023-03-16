// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int M = Prompt("Введите первое значение: ");
int N = Prompt("Введите второе значение: ");
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна: {CalculateSummOfDigits(M, N)}");

int Prompt(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int CalculateSummOfDigits( int m, int n)
{
    if (m > n) return 0;
    return m + CalculateSummOfDigits(m + 1, n);
}

