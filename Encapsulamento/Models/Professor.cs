using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento.Models
{
    public class Professor : Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {Nome} e minha idade é {Idade} anos. Meu salario é {Salario}");
        }

    }
}