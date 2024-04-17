// Задача 1: Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.


void Main()
{
restart: // для возврата goto
    int M = ReadInt("Введите число М (начало промежутка): ");
    int N = ReadInt("Введите число N (конец промежутка): ");

    if (M > N) // в условиях задачи не было но добавил. если m больше n то просим повторить ввод
    {
        System.Console.WriteLine("Введены некорректные значения! Число M должно быть меньше числа N. Повторите попытку ");
        goto restart;
    }

    NumbersInBetween(M, N);
}

void NumbersInBetween(int M, int N)
{
    if (M > N) return;
    NumbersInBetween(M, N - 1);
    System.Console.Write(N + ", ");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();