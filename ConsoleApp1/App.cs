using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco;
using ProjetoBanco.Data;

namespace ProjetoBanco
{
    static class App { 

        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****************************************");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Somos o SoulBank! O banco do seu sucesso!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Para começar, fazer login como:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite 1 para entrar como Administrador");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite 2 para entrar como Cliente");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****************************************");
            Console.ResetColor();
            Console.WriteLine();

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                EntrarComoAdmin();
            }
            else if (opcao == "2")
            {
                EntrarComoCliente();
            }
            else
            {
                Console.WriteLine("Digite uma opção válida.");
                Console.Clear();
                App.Executar();
            }

        }


    public static void EntrarComoAdmin()
    {


        Console.Clear();

        Console.Write("Digite o seu login: ");
        string login = Console.ReadLine();

        Console.WriteLine();
        Console.Write("Digite sua senha: ");
        string senha = Console.ReadLine();

        if (login == Contas.contaAdmin.Login && senha == Contas.contaAdmin.Senha)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Olá, {Contas.contaAdmin.Nome}. Escolha uma opção:");
            Console.ResetColor();
            Console.WriteLine();

            Contas.contaAdmin.mostrarOpcoesMenuAdmin();



        }
        else
        {
            Console.Clear();
            Console.WriteLine("Sua conta não é válida. Tente novamente");
            EntrarComoAdmin();
        }
    }




    public static void EntrarComoCliente()
    {
        Console.Clear();

        Console.WriteLine("Digite seu cpf");
        string cpf = Console.ReadLine();

        Console.WriteLine("Digite sua senha");
        string senha = Console.ReadLine();

        ContaCorrente conta = Contas.contasCorrentes.FirstOrDefault(conta => conta.Senha == senha && conta.Cpf == cpf);

        if (conta != null)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Olá, {conta.Nome}. Escolha uma opção    :");
            Console.ResetColor();
            Console.WriteLine();    

            conta.opcoesMenuCliente();


        }
        else
        {
            Console.Clear();
            Console.WriteLine("Sua conta não é válida. Tente novamente");
            EntrarComoCliente();
        }







    }



}
}
