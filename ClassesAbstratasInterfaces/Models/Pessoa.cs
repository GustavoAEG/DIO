using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasInterfaces.Models
{
    public class Pessoa
    {
        //constructor
        public Pessoa(string nome){
            Nome = nome;
        }
        //propriedade           

    
        public string Nome { get; set; }
        public int Idade { get; set; }

        //metodo
        public virtual void Apresentar(){
            Console.WriteLine($"Ola , meu nome é{Nome} e tenho {Idade} anos de idade");
        }
    }
}