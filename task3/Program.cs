// Задача 3: Задайте произвольный массив. Выведете
//  его элементы, начиная с конца. Использовать
//   рекурсию, не использовать циклы

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 1, 20);

    System.Console.WriteLine($"[" + string.Join(", ", array) + "]");

    PrintArray(array, arraySize);

}

void PrintArray(int[] array, int arraySize) 
{
    if(arraySize < 1 ) return;
    System.Console.Write(array[arraySize - 1] + " "); // в презентации примерах решения не стоят запятые между числами
    PrintArray(array, arraySize -1 );
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    return tempArray;
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();