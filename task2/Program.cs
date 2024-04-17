// Задача 2: Напишите программу вычисления функции
//  Аккермана с помощью рекурсии. Даны два 
//  неотрицательных числа m и n.


using System.Reflection;

void Main()
{
restart: // для возврата goto
    int M = ReadInt("Введите число М (начало промежутка): ");
    int N = ReadInt("Введите число N (конец промежутка): ");

    if (M < 0 || N < 0) // проверка на положительные числа. 
    {
        System.Console.WriteLine("Введены некорректные значения! Введите положительные числа! ");
        goto restart;
    }

    System.Console.WriteLine(ackerman(M, N));
}

int ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return ackerman(m - 1, 1);
    else return ackerman(m - 1, ackerman(m, n - 1));
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();