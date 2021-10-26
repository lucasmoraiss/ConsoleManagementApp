using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaCliente
    {
        public static void Chamar()
        {
            Console.WriteLine("======================== Cadastro de Cliente ========================");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo: \n\n" +
                    "\n     0 - Sair do Cadastro" +
                    "\n     1 - Para Cadastrar Clientes" +
                    "\n     2 - Ver Clientes";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if(valor == 1)
                {
                    var cliente = new Cliente();
                    Console.WriteLine("Cadastre o Nome");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Cadastre o Telefone");
                    cliente.Telefone = Console.ReadLine();

                    Console.WriteLine("Cadastre o CPF");
                    cliente.CPF = Console.ReadLine();
                    cliente.Gravar();
                }
                else if (valor == 2)
                {
                    var clientes = new Cliente().Ler();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine("===========================================");
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF: " + c.CPF);

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
