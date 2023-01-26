﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();


int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

float pointOfIntersectionX(int b1, int k1, int b2, int k2)
{
    float x = 0;
    float temp = 0;
    if (k1!=k2)
    {
        temp = (b2-b1);
        x = temp /(k1 - k2);
    }
    else 
    {
        Console.WriteLine("Ошибка: k1 не должно быть равно k2");
    }
    return x; 
}

float pointOfIntersectionY(float x, int b1, int k1)
{ 
    float y = k1*x + b1;
    return y;
}

Console.ForegroundColor = ConsoleColor.DarkCyan;
int b1 = getUserData("Введите b1:");
int k1 = getUserData("Введите k1:");
int b2 = getUserData("Введите b2:");
int k2 = getUserData("Введите k2:");
float X = pointOfIntersectionX(b1,k1,b2,k2);
float Y = pointOfIntersectionY(X,b1,k1);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Прямые пересекаются в точке: ({X},{Y})");
Console.ResetColor();