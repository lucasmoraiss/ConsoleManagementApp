using Classes;
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
    public class Fornecedor : Base
    {
        public string CNPJ;
        public Fornecedor(string _nome, string _telefone, string _cpf, string _cnpj)
        {
            this.CNPJ = _cnpj;
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.CPF = _cpf;
        }
        public Fornecedor() { }

        public override void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);
            StreamWriter r = new StreamWriter(diretorioComArquivos());
            r.WriteLine("cnpj;nome;telefone;cpf;");
            foreach (Fornecedor b in dados)
            {
                var linha = b.CNPJ + ";" + b.Nome + ";" + b.Telefone + ";" + b.CPF + ";";
                r.WriteLine(linha);
            }
            r.Close();
        }
        public override List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();
            if (File.Exists(diretorioComArquivos()))
            {
                using (StreamReader arquivo = File.OpenText(diretorioComArquivos()))
                {
                    int i = 0;
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');
                        var b = (Fornecedor)Activator.CreateInstance(this.GetType());
                        b.CNPJ = baseArquivo[0];
                        b.SetNome(baseArquivo[1]);
                        b.SetTelefone(baseArquivo[2]);
                        b.SetCPF(baseArquivo[3]);

                        dados.Add(b);
                    }
                }
            }

            return dados;
        }
    }
}