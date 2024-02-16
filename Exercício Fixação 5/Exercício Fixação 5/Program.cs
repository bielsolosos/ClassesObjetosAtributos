using Exercício_Fixação_5;
using System;

namespace Exerc5 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Valor_Adicionado = 222.00;
            Fichas_Banco Conta = new Fichas_Banco(2003, "Gabriel");
            Console.WriteLine(Conta);
            Console.WriteLine($"\nSaldo Adicionado: {Valor_Adicionado} ");
            Conta.AdicionaSaldo(Valor_Adicionado);
            Console.WriteLine(Conta);
            Console.WriteLine($"\nSaldo Removido: {Valor_Adicionado} ");
            Conta.RemoverSaldo(Valor_Adicionado);
            Console.WriteLine(Conta);


        }
    }
}