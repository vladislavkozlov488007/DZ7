// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце. Например, задан массив:
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
 
Console.WriteLine("Введите количетсво строк"); 
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количетсво столбцов"); 
int cols = Convert.ToInt32(Console.ReadLine()); 
int[,] array = new int[rows, cols]; 
FillArray(array); 
PrintArray(array); 
arithmetic(array); 

void FillArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
        for (int j = 0; j < array.GetLength(1); j++) 
            array[i, j] = new Random().Next(0, 10); 
} 
 
void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
            Console.Write($"{array[i, j],5}\t"); 
        Console.WriteLine(); 
    } 
} 

void arithmetic(int[,] array) 
{ 
    double[] arr = new double [cols]; 
    for (int i = 0; i < array.GetLength(1); i++) 
    {
        double sum = 0; 
        for (int j = 0; j < array.GetLength(0); j++) 
        { 
            sum = (sum + array[j, i]); 
        } 
        arr[i] = sum/rows; 
        Console.Write($"{Math.Round(arr[i],1),5}\t"); 
    } 
}
