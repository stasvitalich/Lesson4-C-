//ЗАДАЧА 27
//Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.
//Пример:
//452 -> 11
//82 -> 10
//9012 -> 12

//Напишем метод, который принимает на вход число
//и возвращает число
int GetSum (int number)
{   
    int sum = 0;
    int total = 0;
    for (int i = 1; i <= 10; i = i+1)
    {
        sum = number % 10;
        number = number/10;
        total = total + sum;
    }
    return total;  
}
 
//Инициируем ввод переменной
Console.WriteLine("Введите число: ");

try 
{
    int number = int.Parse(Console.ReadLine());

    //Через новую переменную распечатаем метод:
    int result = Math.Abs(GetSum(number));
    Console.WriteLine(result);
}

catch (Exception ex)
{
    Console.WriteLine($"Ошибка: вы ввели не число, а строку. Попробуйте снова. Error: {ex.Message}");
}
    