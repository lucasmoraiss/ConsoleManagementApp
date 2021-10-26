using ConsoleApp1.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente : Base
    {
        public Cliente(string _nome, string _telefone, string _cpf)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.CPF = _cpf;
        }
        public Cliente(int _telefone)
        {
            this.Telefone = _telefone.ToString();
        }
        public Cliente() { }
    }
}
