// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший 
// общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

Console.Clear();

int M = Prompt("Введите первое значение: ");
int N = Prompt("Введите второе значение: ");
int k = M;
if (M < N) k = N;
Console.WriteLine($"Наибольший общий делитель для {M} и {N} равен: {GetNOD(M, N, k)}");

int Prompt(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int GetNOD(int m, int n, int k)
{
    if (((m % k) == 0) && ((n % k) == 0)) return k;
    return GetNOD(m, n, k - 1);
}



