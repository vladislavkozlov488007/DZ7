// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и 
// возвращает позицию этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Sootvetstvie(array);

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(1, 10);
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        Console.Write($"{arr[i, j],5}\t");
        Console.WriteLine();
    }
}

void Sootvetstvie(int[,] a)
{
    Console.WriteLine("Введите число от 1 до 10, расположенное в нашей матрице");
    int element = Convert.ToInt32(Console.ReadLine());
    int b = 0;
    int c = 0;
    bool sootv = false;
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            if (a[i, j] == element) 
            {
                sootv = true;
                b = i;
                c = j;
            }
    if (sootv == true)
    System.Console.WriteLine($"Число {element} находится на позиции [{b}, {c}] ");
    else System.Console.WriteLine($"Искомое число {element} в матрице отсутствует");
}