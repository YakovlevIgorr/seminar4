// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

int Degree(int number,int degree)
{
    int summ = number;
    for(int i = 1; i < degree; i++)
    {
        summ = summ * number;
    }
    return summ;
}

Console.WriteLine("Введите число ");
int numberUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень ");
int degreeUser = Convert.ToInt32(Console.ReadLine());
int summTotal = Degree(numberUser,degreeUser);
Console.WriteLine($"Число возведенное в степень = {summTotal}");

