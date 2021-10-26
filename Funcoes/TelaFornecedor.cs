using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaFornecedor
    {
        public static void Chamar()
        {
            Console.WriteLine("======================== Cadastro de Fornecedor ========================");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo: \n\n" +
                    "\n     0 - Sair do Cadastro" +
                    "\n     1 - Para Cadastrar Fornecedors" +
                    "\n     2 - Ver Fornecedores";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if(valor == 1)
                {
                    var Fornecedor = new Fornecedor();

                    Console.WriteLine("Cadastre o CNPJ");
                    Fornecedor.CNPJ = Console.ReadLine();
                    Fornecedor.Gravar();

                    Console.WriteLine("Cadastre o Nome");
                    Fornecedor.Nome = Console.ReadLine();

                    Console.WriteLine("Cadastre o Telefone");
                    Fornecedor.Telefone = Console.ReadLine();

                    Console.WriteLine("Cadastre o CPF");
                    Fornecedor.CPF = Console.ReadLine();
                    Fornecedor.Gravar();
                }
                else if (valor == 2)
                {
                    var Fornecedores = new Fornecedor().Ler();
                    foreach (Fornecedor c in Fornecedores)
                    {
                        Console.WriteLine("===========================================");
                        Console.WriteLine("CNPJ: " + c.CNPJ);
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF do Gerente: " + c.CPF);

                        Console.WriteLine("===========================================");
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Comando não encontrado");
                }
            }
        }
    }
}
