static bool PertenceFibo(int n)
{
    int a = 0, b = 1, c = 0;

    if (n == 0 || n == 1) return true;

    while (c < n)
    {
        c = a + b;
        a = b;
        b = c;
    }

    return c == n;
}

Console.WriteLine("Digite um numero para verificar a sequencia de Fibonacci: ");
int n = int.Parse(Console.ReadLine());

if (PertenceFibo(n))
{
    Console.WriteLine($"{n} Pertence a seq Fibonacci. ");

}
else
{
    Console.WriteLine($"{n} Nao Pertence a seq Fibonacci. ");
}


