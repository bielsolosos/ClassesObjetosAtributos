using Exercício_Guiado__Sem_ver_a_resolução_;
using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fichas_Banco Conta;
            double Deposito;
            int numeroConta;
            string Nome;

            Console.Write("Entre o número da conta ");
            numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o Títular da Conta ");
            Nome = Console.ReadLine();

            string verifica; //Vou fazer um DoWhile aqui para ele repetir essa ação p/ evitar Bugs do usuário
            do
            {
                Console.Write("Haverá Deposíto Inicial? (s/n) ");
                verifica = Console.ReadLine();
            
            } while (verifica != "s" && verifica != "n");
            
            //Fazendo a verificação p/ ver se ativa ou não o evento do if
            if(verifica == "s")
            {
                
                double Deposito_inicial;
                Console.Write("Entre o Valor do depósito inicial ");
                Deposito_inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta = new Fichas_Banco(Deposito_inicial, numeroConta, Nome);
                
            }

            else 
            {
                Conta = new Fichas_Banco(numeroConta, Nome);
            }

            Console.WriteLine("Dados Da Conta: ");
            Console.WriteLine(Conta);

         
            Console.Write("\nEntre o Valor do Depósito ");
            Console.WriteLine("Dados da conta atualizados");
            Deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Conta.AdicionaSaldo(Deposito);
            Console.WriteLine(Conta);

            Console.Write("\nEntre o Valor de Saque ");
            Console.WriteLine("Dados da conta atualizados");
            Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.RemoverSaldo(Deposito);
            Console.WriteLine(Conta);
        }
    }
}