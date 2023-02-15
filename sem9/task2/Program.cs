//Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int InputInt (string msg)
{
    Console.Write (msg + "  ");
    return Convert.ToInt32 (Console.ReadLine());
}

void SummNumbers(int m, int n, int sum)
{
    if (m == n)
    {
        Console.Write($"{sum} ");
        return;
    }
    m++;
    sum = sum + m;
    SummNumbers(m, n, sum);
}

int numberM = InputInt ("Введите число M");
int numberN = InputInt ("Введите число N");
int sum = numberM;
Console.Write($"Сумма натуральных чисел равна ");
SummNumbers(numberM, numberN, sum);