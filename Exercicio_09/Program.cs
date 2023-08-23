Console.WriteLine("Digite o valor A :");
int valorA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n Digite o valor B:");
int valorB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor C :");
int valorC = Convert.ToInt32(Console.ReadLine());

if (valorA + valorB > valorC && valorA + valorC > valorB && valorB + valorC > valorA)
{
    Console.WriteLine("Forma um Triângulo.");
}
else if(valorA + valorB == valorC && valorA + valorC == valorB && valorB + valorC == valorA){
    Console.WriteLine("Forma um triângulo Equilátero.");
}
else if(valorA + valorB == valorC && valorA + valorC == valorB && valorB + valorC != valorA){
    Console.WriteLine("Forma um triângulo Isóscelos.");
}
else if(valorA + valorB != valorC && valorA + valorC != valorB && valorB + valorC != valorA){
    Console.WriteLine("Forma um triângulo Escaleno.");
}


