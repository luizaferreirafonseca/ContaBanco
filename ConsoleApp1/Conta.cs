using System;
using System.Collections.Generic;
using System.Globalization;


namespace ProjetoBanco
{
    internal class Conta
    {
        public string Nome { get; set; }
       // public int Id { get; private set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

       

        public Conta() { }

        public Conta(string nome, int idade, string cpf, string telefone) {
            Nome = nome;   
            Idade = idade;
            Cpf = cpf;
            Telefone = telefone;
        }





        public override string ToString()
        {
            return Nome
            +
            Idade
            +
            Cpf
            +
            Telefone;
        }



    }
}
