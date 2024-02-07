using System;
using System.Formats.Asn1;
using System.Globalization;

namespace ConsoleTeste // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando Variáveis
            double A, B, C;
            double perimetro_X, perimetro_Y;
            double area_X, area_Y;

            Console.WriteLine("Entre com as medidas do triângulo X:");
            A = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //parâmetros do X
            perimetro_X = Perimetro(A, B, C);
            area_X = Area(A, B, C,perimetro_X);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //parâmetros do Y
            perimetro_Y = Perimetro(A, B, C);
            area_Y = Area(A, B, C, perimetro_Y);

            Console.WriteLine($"Area de X= {area_X.ToString("F4",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y= {area_Y.ToString("F4",CultureInfo.InvariantCulture)}");

            if(area_X > area_Y)
            {
                Console.WriteLine("Maior área: X");
            }
            else if(area_Y > area_X)
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
