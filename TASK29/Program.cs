//ЗАДАЧА 29
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//Элементы массива вводятся пользователем.
//Пример:
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

//Строго задаём массив из 8 элементов: 
int [] NewArray = new int [8];

//Через цикл for инициализируем ввод элементов массива 
//в пределах заданной длины:
for(int i = 0; i < NewArray.Length; i = i + 1)
{
    Console.WriteLine($"Введите элемент массива с индексом {i}");
    NewArray[i] = int.Parse(Console.ReadLine());
}

//Вывод массива
Console.WriteLine();
Console.Write("Вывод массива: [");
for (int i = 0; i < NewArray.Length; i = i + 1)
{   
        //Через конструкцию if else избавляемся от запятой после последнего i:
        if (i < 7)
        {
            Console.Write($"{NewArray[i]}, ");
        }
        else
        {
            Console.Write($"{NewArray[i]}");
        }   
}
Console.Write("]");
