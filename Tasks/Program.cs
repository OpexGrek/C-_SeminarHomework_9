Console.WriteLine("Choose Task");
Console.WriteLine("Task 1: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("Task 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 1:
        Task1();
        break;
    case 2:
        Task2();
        break;
    default:
        Console.WriteLine("There is no such task");
        break;
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void Task1()
{
    int m = InputNumber("Input M ");
    int n = InputNumber("Input N ");
    int sum = 0;
    int m1 = m;
    Numbers(m, n, sum, m1);
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
void Task2()
{
    int m = InputNumber("Input M ");
    int n = InputNumber("Input N ");
    int numAkker = Akkerman(m, n);
    Console.WriteLine($"M = {m}, N= {n} -> A({m},{n}) = {numAkker}");
}

// Блок функций и методов
int InputNumber(string inputSize)                                 // Функция ввода отрезка чисел
{
    Console.Write(inputSize);
    int outputSize = Convert.ToInt32(Console.ReadLine());
    return outputSize;
}
void Numbers(int m, int n, int sum, int m1)                       // Рекурсия
{
    if (m > n)
    {
        Console.Write($"M = {m1}; N = {n} -> {sum}");
        return;
    }
    sum = sum + m;
    m++;
    Numbers(m, n, sum, m1);
}
int Akkerman(int m, int n)                                        // Функция Аккермана
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}