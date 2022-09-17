//ЗАДАЧА 25

//Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B. Решить задачу с использованием методов.
//Пример:
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Напишем метод, который принимает на вход 2 числа и возвращает одно число:
double GetPow (int a, int b)
{
    double pow = Math.Pow(a, b);
    return pow;
}

//Инициализируем ввод переменных:
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());

//Выводим метод на печать через новую переменную:
double result = GetPow(a, b);
Console.WriteLine(result);