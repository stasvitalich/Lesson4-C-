//Напишите программу, которая принимает на вход число А
//и выдаёт сумму чисел от 1 до А.

int GetSum(int number)
{
    int sum = 0;
    if (number > 0)
    {
        for (int i = 1; i <=number; i = i + 1)
        {
            sum = sum + i;
        }
    }

    if (number < 0)
    {
        for (int i = 1; i >= number; i = i - 1)
        {
            sum = sum + i;
        }
    }
    return sum;
}

Console.WriteLine("Введите число:");

//Такая конструкция try catch позволяет нам получить от пользователя
//именно числовое значение при вводе. При строке будет ошибка.
try
{
    int a = int.Parse(Console.ReadLine());
    int sum = GetSum(a);
    Console.WriteLine(sum);
}
catch(Exception ex)
{
    Console.WriteLine($"Ошибка. Вы должны ввести число. {ex.Message}");
}


