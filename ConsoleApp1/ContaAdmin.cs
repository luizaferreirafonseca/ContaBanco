using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco.Data;

namespace ProjetoBanco
{
    public class ContaAdmin : ContaBase
    {
        public ContaAdmin(string nome, int idade, string cpf, string telefone, string senha, string login) : base(nome, idade, cpf, telefone, senha, login)
        {
        }

        public  void CadastrarNovaConta()
        {



            Console.WriteLine("Name:");
            string nomeTitular = Console.ReadLine();

            Console.WriteLine("Age:");
            int idadeTitular = int.Parse(Console.ReadLine());

            Console.WriteLine("Document (Register)");
            string cpfTitular = (Console.ReadLine());

            Console.WriteLine("Cellphone");
            string celularTitular = (Console.ReadLine());

            Console.WriteLine("Digite um e-mail para login:");
            string loginTitular = (Console.ReadLine());

            Console.WriteLine("Crie uma senha");
            string senhaTitular = (Console.ReadLine());

            ContaCorrente novaConta = new ContaCorrente(nomeTitular, idadeTitular, cpfTitular, celularTitular, loginTitular, senhaTitular);

            Contas.AdicionarNovaConta(novaConta);


            Console.Clear();

            Console.WriteLine("Conta registrada com sucesso!");

            


        }










    }
}
