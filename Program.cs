using ComparandoArea.cs;
using System;
using System.Formats.Asn1;
using System.Globalization;

namespace ConsoleTeste 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando Variáveis
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            double perimetro_X, perimetro_Y;
            double area_X, area_Y;

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //parâmetros do X
            perimetro_X = Perimetro(x.A, x.B, x.C);
            area_X = Area(x.A, x.B, x.C, perimetro_X);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //parâmetros do Y
            perimetro_Y = Perimetro(y.A, y.B, y.C);
            area_Y = Area(y.A, y.B, y.C, perimetro_Y);
            //Gabri anota isso no Fichário por favor!!!
            Console.WriteLine($"Area de X= {area_X.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y= {area_Y.ToString("F4", CultureInfo.InvariantCulture)}");

            if (area_X > area_Y)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (area_Y > area_X)
            {
                Console.WriteLine("Maior área: Y");
            }

        }

        static double Perimetro(double A, double B, double C)
        {
            double perimetro = (A + B + C) / 2;
            return perimetro;
        }

        static double Area(double A, double B, double C, double perimetro)
        {
            double area = Math.Sqrt(perimetro * ((perimetro - A) * (perimetro - B) * (perimetro - C)));
            return area;
        }
    }
}