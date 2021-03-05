using System;
using System.Globalization;

namespace Exercicio_Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, X2, Y2, distancia1, distancia2, distancia3, distancia4;

            string[] v = Console.ReadLine().Split(' ');
            X = double.Parse(v[0]);
            Y = double.Parse(v[1]);

            v = Console.ReadLine().Split(' ');
            X2 = double.Parse(v[0]);
            Y2 = double.Parse(v[1]);

            distancia1 = X2 - X;
            distancia2 = Y2 - Y;
            distancia3 = Math.Pow(distancia1, 2.0) + Math.Pow(distancia2, 2.0);
            distancia4 = Math.Sqrt(distancia3);

            Console.WriteLine(distancia4.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
