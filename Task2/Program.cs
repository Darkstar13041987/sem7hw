﻿// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkerFunction(m,n);


// вызов функции Аккермана
void AkkerFunction(int m, int n)
{
    Console.Write(Akker(m, n)); 
}

// функция Аккермана
int Akker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akker(m - 1, 1);
    }
    else
    {
        return (Akker(m - 1, Akker(m, n - 1)));
    }
}