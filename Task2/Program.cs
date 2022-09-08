// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите целое положительное число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Akkerman(int num1, int num2)
{
    if (num1 == 0)
        return num2 + 1;
    else if ((num1 > 0) && (num2 == 0))
        return Akkerman(num1 - 1, 1);
    else if ((num1 > 0) && (num2 > 0))
        return Akkerman(num1 - 1, Akkerman(num1, num2 - 1));
    else
        return 0;
}

int res = Akkerman(number1, number2);
if (number1 < 0 && number2 < 0 || number1 < 0 || number2 < 0)
    Console.WriteLine("Неверный ввод, введите положительные целые числа ");
else
    Console.Write($" A(m,n) = {res}");
