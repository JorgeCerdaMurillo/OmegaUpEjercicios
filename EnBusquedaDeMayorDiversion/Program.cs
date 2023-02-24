using System;

public class Program
{
    static void Main(string[] args)
    {
        // Leer la cantidad N de juguetes
        int N = int.Parse(Console.ReadLine());

        // Leer los niveles de diversión de los N juguetes
        int[] diversión = new int[N];
        for (int i = 0; i < N; i++)
        {
            diversión[i] = int.Parse(Console.ReadLine());
        }

        // Ordenar los juguetes por nivel de diversión de forma descendente
        Array.Sort(diversión);
        Array.Reverse(diversión);

        // Calcular la diversión total dejando exactamente un juguete sin comprar
        int mayorDiversión = 0;
        for (int i = 0; i < N - 1; i++)
        {
            mayorDiversión += diversión[i];
        }

        // Imprimir la mayor diversión posible
        Console.WriteLine(mayorDiversión);
    }
}
