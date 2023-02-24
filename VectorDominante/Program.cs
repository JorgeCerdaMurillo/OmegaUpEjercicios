using System;

class Program
{
    static void Main(string[] args)
    {// Leer el tamaño del arreglo N
        int N = int.Parse(Console.ReadLine());

        // Leer los enteros del arreglo
        int[] arreglo = new int[N];
        //Lee los valores dentro de larreglo en un arreglo string separado por espacios 
        string[] valores = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++)
        {
            arreglo[i] = int.Parse(valores[i]);
        }
        // Leer los enteros del arreglo
        int[] arreglo2 = new int[N];
        //Lee los valores dentro de larreglo en un arreglo string separado por espacios 
        string[] valores2 = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++)
        {
            arreglo2[i] = int.Parse(valores2[i]);
        }
        bool r = true;
        for (int i = 0; i < N; i++)
        {
            if (arreglo[i] <= arreglo2[i])
            {
                r = false; break;
            }
        }
        if (r)
        {
            Console.Write(1);
        }
        else
        {
            Console.Write(0);
        }
    }
}