using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasInterfaces.Models
{
    public sealed class Professor:Pessoa
    {
        public Professor(string nome): base(nome)
        {
            
        }

        public double Salario { get; set; }

        public override void Apresentar(){

            Console.WriteLine($"Ola, meu nome é {Nome} e salario é {Salario}");
        }
    }
}