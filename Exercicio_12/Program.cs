Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

int a = 0; // Variável para armazenar o número positivo
int b = 0; // Variável para armazenar o número negativo

if (numero > 0)
{
    a = numero;
}
else if (numero < 0)
{
    b = numero;
}

Console.WriteLine($"Número positivo em A: {a}");
Console.WriteLine($"Número negativo em B: {b}");
