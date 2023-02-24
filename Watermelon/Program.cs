using System;

class Program
{
    static void Main(string[] args)
    {
        int w = int.Parse(Console.ReadLine());

        if (w <= 2 || w % 2 != 0)
        {
            Console.WriteLine("NO");
        }
        else
        {
            Console.WriteLine("SI");
        }
    }
}
