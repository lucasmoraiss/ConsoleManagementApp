using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Email
    {
        private Email() { }

        private static Email instancia;
        public string Origem;
        public string Destino;
        public string Titulo;
        public string Corpo;

        public void EnviarEmail()
        {
            Console.WriteLine("Enviando Email para " + Destino + "\nTítulo: " + Titulo + "\nCorpo: " + Corpo);
        }

        public static Email Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Email();
                }
                return instancia;
            }
        }
    }
}
