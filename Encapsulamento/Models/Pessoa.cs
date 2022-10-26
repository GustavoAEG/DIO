using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento.Models
{
    public class Pessoa
    {
    public string Nome { get; set; }
    public int Idade { get; set; }

public virtual void Apresentar(){

    Console.WriteLine($"Opa, meu nome é {Nome} e tenho {Idade} anos de idade");
}

    }
}