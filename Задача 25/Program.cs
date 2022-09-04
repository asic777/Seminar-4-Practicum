// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Task25();

void Task25()
{
    Console.WriteLine("Задача 25. Возведение числа A в натуральную степень B");

    Console.Write("Введите число A: ");
    int numBase = int.Parse(Console.ReadLine()!);

    Console.Write("Введите число B: ");
    int numPow = int.Parse(Console.ReadLine()!);
  
    Console.WriteLine($"Число {numBase} в степени {numPow} = {Pow(numBase, numPow)}");
}

int Pow(int num, int pow)
{
    int result = num;
    for (int i = 2; i <= pow; i++)
    {
        result = result * num;
    }
    return result;
}