// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран. Данные вводятся с консоли
//  пользователем

int [] UserArray()
{
    int [] array = new int [8];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int [] fillArray = UserArray();
Console.WriteLine(string.Join(",", fillArray));
