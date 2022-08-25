// Задача 49. Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++) // строчки
{
    // j, m , k 
    for (int j = 0; j < matrix.GetLength(1); j++) // cтолбцы
    {
        matrix[i, j] = new Random().Next(11); // [0;10]
        Console.Write(matrix[i, j] + "\t"); // "\t"
    }
    Console.WriteLine();
}


Console.WriteLine("Result array:");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            Console.Write((matrix[i, j] * matrix[i, j] )+ "\t");
        }
        else Console.Write(matrix[i, j] + "\t"); // "\t"
    }
   Console.WriteLine();
}


// Console.Write("Ведите число: ");
//             double a = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine("{0} в квадрате {1}", a, Math.Pow(a, 2));
//             Console.ReadLine();
