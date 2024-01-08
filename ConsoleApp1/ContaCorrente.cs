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




        public void opcoesMenuCliente()
        {
            
            Console.WriteLine("Digite 1 para exibir seu saldo");
            Console.WriteLine("Digite 2 para depósito");
            Console.WriteLine("Digite 3 para saque");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ExibirSaldo();
                    break;
                case 2:
                    Depositar();
                    break;
                case 3:
                    Sacar();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        }



        public void ExibirSaldo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"O seu saldo é {Saldo} reais");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal.");
            Console.ReadKey();

            Console.Clear();
            opcoesMenuCliente(); 
        }



        public void Depositar()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor do depósito:");
            double valorDeposito = double.Parse(Console.ReadLine());
            Saldo += valorDeposito;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Depósito realizado com sucesso!");
            Console.ResetColor();
            Console.WriteLine();

        
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal.");
            Console.ReadKey();

            Console.Clear();
            opcoesMenuCliente();

        }

        public void Sacar()
        {
            Console.Clear(); 
            Console.WriteLine("Digite o valor do saque:");
            double valorSaque = double.Parse(Console.ReadLine());
            Saldo -= valorSaque;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Saque realizado com sucesso!");
            Console.ResetColor();
            Console.WriteLine(); 

            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal.");
            Console.ReadKey();

            Console.Clear();
            opcoesMenuCliente();
        }



    }
}
