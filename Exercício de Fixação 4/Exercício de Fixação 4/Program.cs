using Exercício_de_Fixação_4;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{

    internal class Program
    {
        static void Main(string[] args)
        {
            double Cotacao, Dolares;
            Console.Write("Qual a cotação do dolar?");
            Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares você vai comprar camarada?");
            Dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em Reais {ConversorDeMoeda.Converter_Dolar(Dolares, Cotacao).ToString("F2")}");
        }
    }
}