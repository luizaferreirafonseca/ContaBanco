using ProjetoBanco;
using ProjetoBanco.Data;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            ExibirLogo();
            Console.WriteLine();

            App.Executar(); 



            void ExibirLogo()
            {
                Console.WriteLine("\r\n░██████╗░█████╗░██╗░░░██╗██╗░░░░░██████╗░░█████╗░███╗░░██╗██╗░░██╗\r\n██╔════╝██╔══██╗██║░░░██║██║░░░░░██╔══██╗██╔══██╗████╗░██║██║░██╔╝\r\n╚█████╗░██║░░██║██║░░░██║██║░░░░░██████╦╝███████║██╔██╗██║█████═╝░\r\n░╚═══██╗██║░░██║██║░░░██║██║░░░░░██╔══██╗██╔══██║██║╚████║██╔═██╗░\r\n██████╔╝╚█████╔╝╚██████╔╝███████╗██████╦╝██║░░██║██║░╚███║██║░╚██╗\r\n╚═════╝░░╚════╝░░╚═════╝░╚══════╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝"); 
            }


            /* Console.WriteLine("Somos o Soulbank! O banco do seu sucesso!");
            Console.WriteLine("Para começar, fazer login como:");
            Console.WriteLine("Digite 1 para entrar como Administrador");
            Console.WriteLine("Digite 2 para entrar como Cliente");

            string opcao = Console.ReadLine();

            if(opcao == "1")
            {
                EntrarComoAdmin(); 
            }else if(opcao == "2")
            {
                EntrarComoCliente();
            }
            else
            {
                Console.WriteLine("Digite uma opção válida.");
                Console.Clear();
                Main(args);
            }



            void EntrarComoAdmin()
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

                    Console.WriteLine($"Welcome, {Contas.contaAdmin.Nome}. Select an option:");

                    Contas.contaAdmin.mostrarOpcoesMenuAdmin();



                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sua conta não é válida. Tente novamente");
                    EntrarComoAdmin(); 
                }
            }



           
            void EntrarComoCliente()
            {
                Console.Clear();

                Console.WriteLine("Digite seu cpf");
                string cpf  = Console.ReadLine();   

                Console.WriteLine("Digite sua senha");
                string senha = Console.ReadLine();

               ContaCorrente conta = Contas.contasCorrentes.FirstOrDefault(conta => conta.Senha ==  senha && conta.Cpf == cpf);

                if (conta != null)
                {
                    Console.Clear(); 

                    Console.WriteLine($"Welcome, {conta.Nome}. Escolha uma opção    :");

                    conta.opcoesMenuCliente();


                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sua conta não é válida. Tente novamente");
                    EntrarComoCliente(); 
                }


               




            }*/

            
    

            
         

           
            

           


        }
    }
}