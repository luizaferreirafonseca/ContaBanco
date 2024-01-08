using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Data
{
    public static class Contas
    {
        public static List<ContaCorrente> contasCorrentes = new List<ContaCorrente>
        {
            new ContaCorrente("Marcus", 40, "123456", "1234224", "456", "marcus@gmail.com"),
            new ContaCorrente("Leo", 50, "789101112", "1209834", "789", "leo@gmail.com"),
            new ContaCorrente("Sofia", 10, "1314151617", "0989834", "1011", "sofia@gmail.com"),
        };

        public static ContaAdmin contaAdmin = new ContaAdmin("Luiza", 27, "2340945689", "98910331", "123", "luiza@gmail.com");


        public static void AdicionarNovaConta(ContaCorrente conta)
        {
            contasCorrentes.Add(conta);
        }

        public static void ListarContas()
        {
            Console.Clear();
            Console.WriteLine("Contas existentes:");
            Console.WriteLine();
            foreach (ContaCorrente conta in contasCorrentes)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Titular: {conta.Nome} | CPF: {conta.Cpf}");
                Console.ResetColor(); 


            }

            Console.WriteLine(); 
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal.");
            Console.ReadKey();

            Console.Clear();
            contaAdmin.mostrarOpcoesMenuAdmin(); 


        }
    }
}
