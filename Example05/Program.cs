/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

 void GetResult(int firstNumeric, int secondNumeric)
 {
    if (firstNumeric * firstNumeric == secondNumeric)
    {
        Console.WriteLine($"Numeric {secondNumeric} = {firstNumeric}^2");
        return;
    }

    if (secondNumeric * secondNumeric == firstNumeric)
    {
        Console.WriteLine($"Numeric {firstNumeric} = {secondNumeric}^2");
        return;
    }
    Console.WriteLine($"Плохой результат");
 }

 GetResult(121, 11);
