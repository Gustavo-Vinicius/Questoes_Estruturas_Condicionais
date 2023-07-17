Console.WriteLine("Digite a primeira nota :");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a segunda nota :");
double nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a terceira nota :");
double nota3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a quarta nota :");
double nota4 = Convert.ToDouble(Console.ReadLine());

double resultado = (nota1 + nota2 + nota3 + nota4) / 4;

if (resultado >= 7)
{
    Console.Write("Aprovado com Distinção!");
}
else if (resultado < 7)
{
    Console.Write("Reprovado. \n");
}

if (resultado < 7)
{
    Console.WriteLine("Digite a nota da recuperacao :");
    double recuperacao = Convert.ToDouble(Console.ReadLine());

    double novoResultado = (resultado + recuperacao) / 2;

    if (novoResultado >= 7)
    {
        Console.Write("Aprovado na recuperação !");
    }
    else if (novoResultado < 7)
    {
        Console.Write("Reprovado, mesmo com a nota da recuperação !");
    }
}
