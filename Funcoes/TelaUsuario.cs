using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("======================== Cadastro de Usuario ========================");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo: \n\n" +
                    "\n     0 - Sair do Cadastro" +
                    "\n     1 - Para Cadastrar Usuarios" +
                    "\n     2 - Ver Usuarios";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if(valor == 1)
                {
                    var usuario = new Usuario();
                    Console.WriteLine("Cadastre o Nome");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Cadastre o Telefone");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Cadastre o CPF");
                    usuario.CPF = Console.ReadLine();
                    usuario.Gravar();
                }
                else if (valor == 2)
                {
                    var Usuarios = new Usuario().Ler();
                    foreach (Usuario c in Usuarios)
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
