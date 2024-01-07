using ProjetoBanco;
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
            Console.WriteLine("Please, let's start by writing your name:");


            string nome = Console.ReadLine();
            Console.WriteLine($"Welcome, {nome}. Select an option:");

            List<Conta> contas = new List<Conta>();

            ExibirOpcoesMenu(); 

            void ExibirOpcoesMenu()
            {
                Console.WriteLine("Digite 1 para cadastrar uma nova conta no sistema");
                Console.WriteLine("Digite 2 para deletar uma conta do sistema");
                Console.WriteLine("Digite 3 para listar todas as contas do sistema");
                Console.WriteLine("Digite 4 para acesso à conta corrente do usuário");
                Console.WriteLine("Digite 0 para sair do sistema");

                int opcaoEscolhida= int.Parse(Console.ReadLine());

                switch (opcaoEscolhida)
                {
                    case 1: CadastrarNovaConta();
                        break;
                    case 2:
                        DeletarConta();
                        break;
                    case 3:
                        Console.WriteLine("Programa encerrado"); //ListarUsuarios();
                        break;
                    case 4:
                        Console.WriteLine("Programa encerrado"); //DetalhesUsuario();
                        break;
                    case 0: Console.WriteLine("Programa encerrado");
                        break;
                    default: Console.WriteLine("Invalid option");
                        break;
                }


            }

           

            
            void CadastrarNovaConta()
            {
                
                Console.Clear();
                Cadastrar();

               void Cadastrar()
                {

                    Console.WriteLine("Name:");
                    string nomeTitular = Console.ReadLine();

                    Console.WriteLine("Age:");
                    int idadeTitular = int.Parse(Console.ReadLine());

                    Console.WriteLine("Document (Register)");
                    string cpfTitular = (Console.ReadLine());

                    Console.WriteLine("Cellphone");
                    string celularTitular = (Console.ReadLine());

                    Conta novaConta = new Conta(nomeTitular, idadeTitular, cpfTitular, celularTitular);

                    contas.Add(novaConta);


                }

                
                Console.Clear();

                Perguntar();

                void Perguntar()
                {

                    Console.Clear();

                    Console.WriteLine("Conta registrada com sucesso!");
                    Console.WriteLine($"Contas: {contas.Count}");
                  
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

                void DeletarConta()
                {
                    Console.Clear();
                    Console.WriteLine("Digite o CPF da conta que deseja deletar:");
                    string cpfParaDeletar = Console.ReadLine();

                    // Procura a conta na lista com o CPF fornecido
                    Conta contaParaDeletar = contas.FirstOrDefault(conta => conta.Cpf == cpfParaDeletar);

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
                }


            }




            void DeletarConta()
            {
                Console.Clear();
                Console.WriteLine("Digite o CPF da conta que deseja deletar:");
                string cpfParaDeletar = Console.ReadLine();


                // Procura a conta na lista com o CPF fornecido
                Conta contaParaDeletar = contas.FirstOrDefault(conta => conta.Cpf == cpfParaDeletar);

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

            }

           
            

           


        }
    }
}