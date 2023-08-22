// Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor fornecido está na faixa
// entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”.
// Caso contrário, apresentar a mensagem “valor inválido”.

Console.WriteLine("Digite um número :");
int valor = Convert.ToInt32(Console.ReadLine());

switch (valor)
{
    case 0:
        Console.Write("valor válido");
        break;
    case 1:
        Console.Write("valor válido");
        break;
    case 2:
        Console.Write("valor válido");
        break;
    case 3:
        Console.Write("valor válido");
        break;
    case 4:
        Console.Write("valor válido");
        break;
    case 5:
        Console.Write("valor válido");
        break;
    case 6:
        Console.Write("valor válido");
        break;
    case 7:
        Console.Write("valor válido");
        break;
    case 8:
        Console.Write("valor válido");
        break;
    case 9:
        Console.Write("valor válido");
        break;

    default:
        Console.Write("valor inválido");
        break;
}
