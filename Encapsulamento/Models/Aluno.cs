using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {Nome} e minha idade é {Idade} anos. SOU NOTA {Nota}");
        }
    }
}