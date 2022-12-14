//Напишите программу, которая принимает на вход число 
//и выдаёт количество цифр в числе
//Пример: 537 => 3

//Напишем метод, который принимает на вход число
//и возвращает число.
//Смысл кода: мы задаём переменную sum, которая равна 1, если число меньше 10,
//в нём 1 цифра. Её и выводим. Но пока число больше или равно 10, мы будем делить его на 10
//всякий раз прибавляя к изначальной сумме единицу.


int GetSum (int number)
{
    int sum = 1;
    while(number >= 10)
    {
        number = number / 10;
        sum = sum + 1;    
    }
    return sum;
}

//Инициализируем ввод числа
Console.WriteLine("Введите число");

//Структура try catch помогает избавиться от ошибок,
//если пользователь вдруг введёт строку вместо цифр
try
{
    int number = int.Parse(Console.ReadLine());
    //После ввода числа, добавляем условие, что если 
    //число отрицательное, то берём его по модулю
    if (number < 0)
    {
        number = Math.Abs(number);
    }
    //Через новую переменную распечатываем метод
    int result = GetSum(number);
    Console.WriteLine(result);
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка, попробуйте снова. {ex.Message}");
}
