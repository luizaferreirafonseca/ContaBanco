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



        public void mostrarOpcoesMenuAdmin()
        {
            Console.WriteLine("Digite 1 para cadastrar uma nova conta no sistema");
            Console.WriteLine(); 
            Console.WriteLine("Digite 2 para deletar uma conta do sistema");
            Console.WriteLine();
            Console.WriteLine("Digite 3 para listar todas as contas do sistema");
            Console.WriteLine();
            Console.WriteLine("Digite 0 para sair do sistema");

            int opcaoEscolhida = int.Parse(Console.ReadLine());
            

            switch (opcaoEscolhida)
            {
                case 1:
                    CadastrarNovaConta();
                    break;
                case 2:
                    DeletarConta();
                    break;
                case 3:
                    Contas.ListarContas();  
                    break;
                case 0:
                    Console.WriteLine("Programa encerrado");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu de Acesso.");
            Console.ReadKey();

            Console.Clear();
            App.Executar(); 

        }

        private void CadastrarNovaConta()
        {

            Console.Clear();

            Console.WriteLine("Nome:");
            string nomeTitular = Console.ReadLine();

            Console.WriteLine("Idade:");
            int idadeTitular = int.Parse(Console.ReadLine());

            Console.WriteLine("Documento (CPF)");
            string cpfTitular = (Console.ReadLine());

            Console.WriteLine("Celular");
            string celularTitular = (Console.ReadLine());

            Console.WriteLine("Digite um e-mail para login:");
            string loginTitular = (Console.ReadLine());

            Console.WriteLine("Crie uma senha");
            string senhaTitular = (Console.ReadLine());

            ContaCorrente novaConta = new ContaCorrente(nomeTitular, idadeTitular, cpfTitular, celularTitular, loginTitular, senhaTitular);

            Contas.AdicionarNovaConta(novaConta);


            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Conta registrada com sucesso!");
            Console.ResetColor(); 

            Console.WriteLine("Deseja cadastrar outro usuário? S/N");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 'S')
            {
                Console.Clear();
                CadastrarNovaConta();



            }
            else
            {
                Console.Clear();
                mostrarOpcoesMenuAdmin();
            }


        }




        private void DeletarConta()
        {
            Console.Clear();
            Console.WriteLine("Digite o CPF da conta que deseja deletar:");
            string cpfParaDeletar = Console.ReadLine();

            ContaCorrente contaParaDeletar = Contas.contasCorrentes.FirstOrDefault(conta => conta.Cpf == cpfParaDeletar);


            if (contaParaDeletar != null)
            {
                
                Contas.contasCorrentes.Remove(contaParaDeletar);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Conta deletada com sucesso!");
                Console.ResetColor(); 


            }
            else
            {
                Console.WriteLine("Conta não encontrada. Verifique o CPF digitado.");
            }

            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal.");
            Console.ReadKey();

            Console.Clear();
            mostrarOpcoesMenuAdmin();
        }



    }
}
