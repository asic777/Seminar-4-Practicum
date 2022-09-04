// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Task29();

void Task29()
{
    Console.WriteLine("Задача 29. Задание массива и вывод на экран");

    Console.Write("Введите длину массива: ");
    int lengthArray = int.Parse(Console.ReadLine()!);

    Console.Write("Задать массив рандомно? (0 - в ручную, 1 - рандомно): ");
    int answer = int.Parse(Console.ReadLine()!);

    int[] array = FillArray(lengthArray, answer);
    PrintArray(array);
}

int[] FillArray(int count, int randomOn)
{
    int[] resultArray = new int[count];

    for (int i = 0; i < count; i++)
    {
        if (randomOn == 1) resultArray[i] = new Random().Next(0, 100);
        else
        {
            Console.Write($"Введите значение элемента [{i}] массива: ");
            resultArray[i] = int.Parse(Console.ReadLine()!);
        }
    }
    return resultArray;
}

void PrintArray(int[] tempArray)
{
    Console.Write("[{0}", tempArray[0]);
    for (int i = 1; i < tempArray.Length; i++)
    {
        Console.Write(", {0}", tempArray[i]);
    }
    Console.Write("]");
}