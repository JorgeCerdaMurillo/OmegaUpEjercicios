using System;

public class Program
{
    static void Main(string[] args)
    {
        // Leer el tamaño del arreglo N
        int N = int.Parse(Console.ReadLine());

        // Leer los enteros del arreglo
        int[] arreglo = new int[N];
        //Lee los valores dentro de larreglo en un arreglo string separado por espacios 
        string[] valores = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++)
        {
            arreglo[i] = int.Parse(valores[i]);
        }

        // Leer el entero P
        int P = int.Parse(Console.ReadLine());

        // Imprimir los valores del arreglo que sean pares o impares según el valor de P
        for (int i = 0; i < N; i++)
        {
            if (arreglo[i] % 2 == P)
            {
                Console.Write(arreglo[i] + " ");
            }
        }
    }
}

