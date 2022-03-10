// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

Console.Clear();

Console.Write("Введите размерность по X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите размерность по Y: ");
int Y = int.Parse(Console.ReadLine());
int[,] array = new int[X, Y];
Random rnd = new Random();


void ArrayFill(int[,] mass)
{
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            mass[i, j] = rnd.Next(10, 100);
        }
    }
}

void ArrayPrint(int[,] mass)
{
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            Console.Write(mass[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArrayCorrect(int[,] mass)
{
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            if (i % 2 == 0 && j % 2 == 0) mass[i, j] *= mass[i, j];
        }
    }
}
ArrayFill(array);
ArrayPrint(array);
ArrayCorrect(array);
ArrayPrint(array);