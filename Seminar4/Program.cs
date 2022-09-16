//Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке

//Пишем метод, который вернёт нам массив
int[] GetArray()
{
    int[] array = new int [8];
    //При помощи цикла for мы обращаемся к каждому элементу массива
    //от 0 до 7
    for (int i = 0; i < array.Length; i = i + 1)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

//Пишем метод, который печатает наш массив. 
void PrintArrayToConsole(int[] array)
{
    for (int i = 0; i < array.Length; i = i + 1)
    {
        Console.WriteLine(array[i]);
    }
}

//Выводим на печать через новую переменную:
int[] array = GetArray();
PrintArrayToConsole(array);