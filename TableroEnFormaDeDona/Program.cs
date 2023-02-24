using System;

class Program
{
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int W = int.Parse(entrada[0]);
        int H = int.Parse(entrada[1]);
        int X = int.Parse(entrada[2]);
        int Y = int.Parse(entrada[3]);
        int R = int.Parse(entrada[4]);
        int S = int.Parse(entrada[5]);

        int finalX = (X + R) % W;
        int finalY = (Y + S) % H;

        if (finalX < 0)
        {
            finalX += W;
        }

        if (finalY < 0)
        {
            finalY += H;
        }

        Console.WriteLine("{0} {1}", finalX, finalY);
    }
}
