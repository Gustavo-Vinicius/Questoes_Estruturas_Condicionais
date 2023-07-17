Console.WriteLine(" Digite o 1º número :");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Digite o 2º número :");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Digite o 3º número :");
int n3 = Convert.ToInt32(Console.ReadLine());

int[] arr = new[] { n1, n2, n3 };

foreach (int value in arr)
{
    Console.Write(value + " ");
}
