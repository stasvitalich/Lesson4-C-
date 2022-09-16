//Вычисление первых 40 чисел Финбоначчи

double Fibonacci (int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for(int i = 1; i < 40; i = i + 1)
{
    Console.WriteLine(Fibonacci(i));
}
