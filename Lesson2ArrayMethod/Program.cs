//НАПИСАНИЕ МЕТОДА, КОТОРЫЙ РАСПЕЧАТЫВАЕТ МАССИВ
//НАПИСАНИЕ МЕТОДА, КОТОРЫЙ ЗАПОЛНЯЕТ МАССИВ РАНДОМНЫМИ ЧИСЛАМИ


//Инициализируем двумерный массив - матрицу
int[,] matrix = new int[3, 4];

//Создаём метод, позволяющий распечатать матрицу
void PrintArray (int[,] matr)
{
    for (int rows2 = 0; rows2 < matr.GetLength(0); rows2 = rows2 + 1)
    {
        for (int columns2 = 0; columns2 < matr.GetLongLength(1); columns2 = columns2 + 1)
        {
            Console.Write($"{matr[rows2, columns2]} ");
        }
            Console.WriteLine();
    }
}

//Через создание новой переменной выводим на печать наш метод
PrintArray(matrix);

//Метод, позволяющий заполнить наш массив рандомными числами
void FillArray(int[,] matr)
{
     for (int rows2 = 0; rows2 < matr.GetLength(0); rows2 = rows2 + 1)
    {
        for (int columns2 = 0; columns2 < matr.GetLongLength(1); columns2 = columns2 + 1)
        {
            matr[rows2, columns2] = new Random().Next(1, 10);
        }
    }
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);