using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class ContaCorrente : ContaBase
    {

        public double Saldo { get; private set; }

        public ContaCorrente(string nome, int idade, string cpf, string telefone, string senha, string login) : base(nome, idade, cpf, telefone, senha, login)
        {
            Saldo = 0;
        }



        public void Depositar(double valor)
        {
            Saldo = valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor; 
        }



    }
}
