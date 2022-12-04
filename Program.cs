// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Input N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// void ShowNums(int n)
// {
//     Console.Write(n + " ");
//     if(n > 1) ShowNums(n-1);
// }

// ShowNums(N);
// Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Input first number of interval, M: ");
// int numberM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input last number of interval, N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// void SumElemeintOfInterval (int numberM, int numberN, int sum)
// {
//     if (numberM > numberN) 
//     {
//         Console.WriteLine($"Sum of elements of interval from M to N: {sum}"); 
//         return;
//     }
//     sum = sum + (numberM++);
//     SumElemeintOfInterval(numberM, numberN, sum);
// }

// SumElemeintOfInterval(numberM, numberN, 0);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Input number m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number n: ");
int n = Convert.ToInt32(Console.ReadLine());

int funcAkkerman = Akkerman(m, n);

Console.WriteLine($"Function of Akkerman = {funcAkkerman} ");

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}
