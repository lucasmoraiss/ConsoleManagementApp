using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cachorro : Animal
    {

        public int Idade;

        private int idadePreDefinida = 2;

        public int Idade2 { 
            get 
            {
                return idadePreDefinida; 
            }
            set
            {
                idadePreDefinida = value;
            }
        }

        public override void Latir()
        {
            Console.WriteLine("Latido");
        }
    }
}
