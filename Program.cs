//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Ввведите число");
int n1 = Convert.ToInt32(Console.ReadLine());
int Sum(int num)
{
    if (num == 1)
    {
    return 1;
    }
    Console.Write(num);
    return Sum(num - 1);   
}
int n2= Sum(n1);

Console.WriteLine((n2));



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Ввведите первое число");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите второе число");
int n1 = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = m1; i <= n1; i++)
{
    sum = sum + i;
}
Console.WriteLine(sum);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Ввведите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите второе число");
int n = Convert.ToInt32(Console.ReadLine());
int AM(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (m == 0)
        return AM(n - 1, 1);
    else
        return AM(n - 1, AM(n, m - 1));

}
Console.WriteLine(AM(m, n));
