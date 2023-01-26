//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Ввведите число");
int N = Convert.ToInt32(Console.ReadLine());
int Sum(int num)
{
    if (num == 1)
    {
    return 1;
    }
    Console.Write(num);
    return Sum(num - 1);   
}
int nat= Sum(N);

Console.WriteLine((nat));