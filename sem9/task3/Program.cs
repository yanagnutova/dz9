// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Пример:
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputInt (string msg)
{
    Console.Write (msg + "  ");
    return Convert.ToInt32 (Console.ReadLine());
}

int AckermannFunct(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    } 
    else if (n == 0) 
    {
        return AckermannFunct(m - 1, 1);
    }
    else
    {
        return AckermannFunct(m - 1, AckermannFunct(m, n - 1));
    }
}

int numberM = InputInt($"Введите число:");
int numberN = InputInt($"Введите аргумент:");
int result = AckermannFunct(numberM, numberN);
Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {result}");
