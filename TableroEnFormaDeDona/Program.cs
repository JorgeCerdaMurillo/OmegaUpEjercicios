using System;

class Program
{
    static void Main(string[] args)
    {
        int W, H, X, Y, R, S;
        W = int.Parse(Console.ReadLine());
        H = int.Parse(Console.ReadLine());
        X = int.Parse(Console.ReadLine());
        Y = int.Parse(Console.ReadLine());
        R = int.Parse(Console.ReadLine());
        S = int.Parse(Console.ReadLine());

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
