//Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
//в промежутке от M до N с помощью рекурсии.

//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

int InputInt (string msg)
{
    Console.Write (msg + "  ");
    return Convert.ToInt32 (Console.ReadLine());
}

void EvenNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    else if (m % 2 != 0)
    {
        m++;
    }
    Console.Write($"{m} ");
    EvenNumbers(m + 2, n);
}

int numberM = InputInt ("Введите число M");
int numberN = InputInt ("Введите число N");

EvenNumbers(numberM,numberN);
