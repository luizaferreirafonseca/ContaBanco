using System;
using System.Collections.Generic;
using System.Globalization;


namespace ProjetoBanco
{
    public class ContaBase
    {
        public string Nome { get; set; }
       // public int Id { get; private set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        
        public string Senha { get; set; }

        public string Login { get; set; }

        public ContaBase(string nome, int idade, string cpf, string telefone, string senha, string login)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Telefone = telefone;
            Senha = senha;
            Login = login;
        }
    }
}
