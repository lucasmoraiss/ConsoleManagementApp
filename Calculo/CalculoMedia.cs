using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Media
    {    
        public static void Aluno()
        {
            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();
            float qtdNotas = 3;
            Console.WriteLine("Digite as " + qtdNotas + " notas do aluno " + nome);
            List<float> notas = new List<float>();
            float totalNotas = 0;
            for (float i = 1; i <= 3; i++)
            {
                Console.WriteLine("Digite a nota número " + i);
                float nota = float.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }
            float media = totalNotas / notas.Count;
            Console.WriteLine("A média do aluno " + nome + ", é " + media);
            Console.WriteLine("Suas notas são:\n");
            foreach (float nota in notas)
            {
                Console.WriteLine("Nota: " + nota + "\n");
            }
        }
    }
}
