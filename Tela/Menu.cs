using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_USUARIO = 5;
        public const int CADASTRAR_FORNECEDOR = 6;


        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Aplicação Console 1.0\n" +
                    "\n  Digite uma das opções abaixo: \n\n" +
                    "\n     0 - Sair do Programa" +
                    "\n     1 - Ler Arquivos" +
                    "\n     2 - Tabuada" +
                    "\n     3 - Calcular Média" +
                    "\n     4 - Cadastrar Clientes" +
                    "\n     5 - Cadastrar Usuario" +
                    "\n     6 - Cadastrar Fornecedor";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("============================== Opção Ler Arquivos ==============================");
                    Arquivo.Ler(1);
                    Console.WriteLine("================================================================================");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("============================== Opção Tabuada ==============================");
                    Console.WriteLine("Digite o número que deseja na tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.calcular(numero);
                    Console.WriteLine("===========================================================================");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("============================== Opção Calculo da Média ==============================");
                    Media.Aluno();
                    Console.WriteLine("====================================================================================");
                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    Console.WriteLine("============================ Opção Cadastro Clientes ============================");
                    TelaCliente.Chamar();
                    Console.WriteLine("====================================================================================");
                }
                else if (valor == CADASTRAR_USUARIO)
                {
                    Console.WriteLine("============================ Opção Cadastro Usuário ============================");
                    TelaUsuario.Chamar();
                    Console.WriteLine("====================================================================================");
                }
                else if (valor == CADASTRAR_FORNECEDOR)
                {
                    Console.WriteLine("============================ Opção Cadastro Fornecedor ============================");
                    TelaFornecedor.Chamar();
                    Console.WriteLine("====================================================================================");
                }
                else
                {
                    Console.WriteLine("Opção Inválida, tente novamente com um número de 0 a 6");
                    Console.WriteLine("======================================================");
                }
            }
        }
    }
}
