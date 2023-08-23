Console.WriteLine("DIGITE UM NUMERO INTEIRO :");
var numero = Convert.ToInt32(Console.ReadLine());

switch (numero)
{
    case 1:
    Console.Write("Um");
    break;
    
    case 2:
    Console.Write("Dois");
    break;

    case 3:
    Console.Write("Três");
    break;

    default:
    Console.WriteLine("Nenhum número foi digitado.");
    break;
}