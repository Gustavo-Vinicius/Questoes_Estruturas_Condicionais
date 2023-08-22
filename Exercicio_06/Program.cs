Console.WriteLine("Digite o primeiro número :");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número :");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2) {
    Console.Write($"N1: {n1} é maior número.\n");
    Console.Write($"N2: {n2} é menor número.");
 }
 else if (n2 > n1) {
    Console.Write($"N2: {n2} é maior número.\n");
    Console.Write($"N1: {n1} é menor número.");
 } 
 else if (n1 == n2) {
    Console.Write($"Número 1 {n1} é igual a Número 2 {n2}");
 } 
else {
    Console.WriteLine("Nenhum número foi informado");
}