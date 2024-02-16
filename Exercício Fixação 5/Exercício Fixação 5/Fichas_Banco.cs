using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Fixação_5
{
    internal class Fichas_Banco
    {
        public double Saldo_Banco {  get; private set; }
        public int Numero_Conta { get; private set; }
        public String Nome_Titular { get; set; }

        public Fichas_Banco(double Saldo, int Numero,String Nome)
        {
            Saldo_Banco = Saldo;
            Numero_Conta = Numero;
            Nome_Titular = Nome;
        }

        public Fichas_Banco(int Numero, String Nome)
        {
            Saldo_Banco = 0;
            Numero_Conta = Numero;
            Nome_Titular = Nome;
        }

        public void AdicionaSaldo(double Valor)
        {
            Saldo_Banco += Valor;
        }

        public void RemoverSaldo(double Valor)
        {
            Saldo_Banco -= Valor;
        }

        public override string ToString()
        {
            return "Nome: " + Nome_Titular + ", Número da Conta: " + Numero_Conta + ", Saldo: $ " + Saldo_Banco ;
        }
    }
}
