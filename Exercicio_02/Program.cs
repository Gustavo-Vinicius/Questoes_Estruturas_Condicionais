Console.WriteLine("Digite o modulo : ");
double x = Convert.ToDouble (Console.ReadLine());

if(x >= 0){
    Console.WriteLine(x);
}else {
    Console.WriteLine(x * (-1)); //Não existe raiz de número negativo, então impri
}