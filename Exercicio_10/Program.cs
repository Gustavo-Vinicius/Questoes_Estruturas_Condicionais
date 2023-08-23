int a,
    b,
    c;

do
{
    Console.Write("Digite um valor maior que zero para 'a': ");
} while (!int.TryParse(Console.ReadLine(), out a) || a <= 0);

do
{
    Console.Write("Digite um valor maior que zero para 'b': ");
} while (!int.TryParse(Console.ReadLine(), out b) || b <= 0);

do
{
    Console.Write("Digite um valor maior que zero para 'c': ");
} while (!int.TryParse(Console.ReadLine(), out c) || c <= 0);

int menor = Math.Min(Math.Min(a, b), c);
int maior = Math.Max(Math.Max(a, b), c);

int resultadoMultiplicacao = menor * maior;
double resultadoDivisao = (double)maior / menor;

Console.WriteLine($"Menor valor multiplicado pelo maior: {resultadoMultiplicacao}");
Console.WriteLine($"Maior valor dividido pelo menor: {resultadoDivisao}");
