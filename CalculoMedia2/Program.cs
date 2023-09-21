using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double A, B, C, D;

        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        D = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10;

        Console.WriteLine("MEDIA = " + D.ToString("f1", CultureInfo.InvariantCulture));

    }

}