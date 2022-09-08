// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите целое положительное число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int NaturalNumber(int m, int n)

{
    int sum = 0;
    if (m <= 0 || n <= 0 || m <= 0 && n <= 0) return 0;
    if (m == n)
        return sum += n;
    else
        return sum += m + NaturalNumber(m + 1, n);

}

int res = NaturalNumber(number1, number2);
if (res == 0) 
   Console.Write("Вы ввели неверные числа, повторите ввод");
else
   Console.Write($"Сумма чисел в промежутке от M до N равна {res} ");





