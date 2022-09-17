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
    for (int i = 0; i <= 10; i = number)
    {
        number = number/10;
        
    }
    return number;  
}
 

//Инициируем ввод переменной
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int result = GetSum(number);
Console.WriteLine(result);