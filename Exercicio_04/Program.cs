Console.WriteLine("Digite o 1º número :");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o 2º número :");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2){
    Console.Write($"Numero {n1} é maior que o {n2}");
}
else if (n2>n1) {
    Console.Write($"O numero {n2} e maior do que {n1}");
}
else {
    Console.Write("Numeros não informados");
}