// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Task27();

void Task27()
{
    Console.WriteLine("Задача 27. Сумма цифр числа");

    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"{number} -> {SumNumber(number)}");
}

int SumNumber(int num)
{
    int result = 0;

    while (num > 0)
    {
        result = result + num % 10;
        num /= 10;
    }

    return result;
}