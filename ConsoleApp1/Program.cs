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
            Console.WriteLine("This is B-Five, your new bank!");
            Console.WriteLine("Para começar, fazer login como:");
            Console.WriteLine("Digite 1 para entrar como Administrador");
            Console.WriteLine("Digite 2 para entrar como Cliente");

            string opcao = Console.ReadLine();

            if(opcao == "1")
            {
                EntrarComoAdmin(); 
            }if(opcao == "2")
            {
                EntrarComoCliente();
            }
            else
            {
                Console.WriteLine("Digite uma opção válida.");
                Console.Clear();
                //Main(args);
            }



            void EntrarComoAdmin()
            {
                Console.Write("Digite o seu login: "); 
                string login = Console.ReadLine();

                Console.WriteLine();
                Console.Write("Digite sua senha: ");
                string senha = Console.ReadLine();

                if (login == Contas.contaAdmin.Login && senha == Contas.contaAdmin.Senha)
                {
                    Console.Clear();

                    Console.WriteLine($"Welcome, {Contas.contaAdmin.Nome}. Select an option:");

                    OpcoesMenuAdmin();



                }
            }

            void OpcoesMenuAdmin()
            {


                Console.WriteLine("Digite 1 para cadastrar uma nova conta no sistema");
                Console.WriteLine("Digite 2 para deletar uma conta do sistema");
                Console.WriteLine("Digite 3 para listar todas as contas do sistema");
                Console.WriteLine("Digite 0 para sair do sistema");


                int numero; 
                string entrada = Console.ReadLine();
                if(int .TryParse(entrada, out numero))
                {
                    Console.WriteLine(numero);
                }
                //int opcaoEscolhida= int.Parse(Console.ReadLine());
                //Console.WriteLine(opcaoEscolhida);

                /* switch (opcaoEscolhida)
                {
                    case 1:
                        Contas.ListarContas();   //Cadastrar();  
                        break;
                    case 2: Console.WriteLine("Programa encerrado");
                        //DeletarConta();
                        break;
                    case 3: Console.WriteLine("oi");   //Contas.ListarContas(); 
                        break;
                    case 0: Console.WriteLine("Programa encerrado");
                        break;
                    default: Console.WriteLine("Invalid option");
                        break;
                } */


            }


            void Cadastrar()
            {
                Contas.contaAdmin.CadastrarNovaConta();

                Console.Clear();

                Console.WriteLine("Deseja cadastrar outro usuário? S/N");
                char resposta = char.Parse(Console.ReadLine());
                if (resposta == 'S')
                {
                    Console.Clear();
                    Cadastrar();
                    


                }
                else
                {
                    Console.Clear();
                    OpcoesMenuAdmin(); 
                }



            }



           
            void EntrarComoCliente()
            {
                Console.WriteLine("oi");
            }

            
           /* void CadastrarNovaConta()
            {
                
                Console.Clear();
                Cadastrar();

              

                
                Console.Clear();

                Perguntar();

                void Perguntar()
                {

                    Console.Clear();

                    Console.WriteLine("Conta registrada com sucesso!");
                   
                  
                    Console.WriteLine("Deseja cadastrar outro usuário? S/N");
                    char resposta = char.Parse(Console.ReadLine());
                    if (resposta == 'S')
                    {
                        Console.Clear();
                        Cadastrar();
                        Perguntar(); 


                    }
                    else
                    {
                        Console.Clear();
                        ExibirOpcoesMenu();
                    }


                }
           */

            
               /* void DeletarConta()
                {
                    Console.Clear();
                    Console.WriteLine("Digite o CPF da conta que deseja deletar:");
                    string cpfParaDeletar = Console.ReadLine();

                    // Procura a conta na lista com o CPF fornecido
                    ContaBase contaParaDeletar = contas.FirstOrDefault(conta => conta.Cpf == cpfParaDeletar);

                    if (contaParaDeletar != null)
                    {
                        // Remove a conta da lista
                        contas.Remove(contaParaDeletar);
                        Console.WriteLine("Conta deletada com sucesso!");
                        Console.WriteLine(contas.Count);
                    }
                    else
                    {
                        Console.WriteLine("Conta não encontrada. Verifique o CPF digitado.");
                    }

                    Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal.");
                    Console.ReadKey();

                    Console.Clear();
                    ExibirOpcoesMenu();
                } */ 


            




           /* void DeletarConta()
            {
                Console.Clear();
                Console.WriteLine("Digite o CPF da conta que deseja deletar:");
                string cpfParaDeletar = Console.ReadLine();


                // Procura a conta na lista com o CPF fornecido
                ContaBase contaParaDeletar = contas.FirstOrDefault(conta => conta.Cpf == cpfParaDeletar);

                if (contaParaDeletar != null)
                {
                    // Remove a conta da lista
                    contas.Remove(contaParaDeletar);
                    Console.WriteLine("Conta deletada com sucesso!");
                    Console.WriteLine(contas.Count);
                }
                else
                {
                    Console.WriteLine("Conta não encontrada. Verifique o CPF digitado.");
                }

                Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal.");
                Console.ReadKey();

                Console.Clear();
                ExibirOpcoesMenu();

            } */

           
            

           


        }
    }
}