using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Models
{
    public class Pessoa
    {
      public string nome { get; set; }
        public int idade { get; set; }  
        public string idadeString { get; set; }

    DateTime dataAtual = DateTime.Now;
        
        public double altura { get; set; }

        public void Apresentar(){
idadeString="88";
            Console.WriteLine($"Olá, meu nome é {nome}, e tenho {idade} anos");
            Console.WriteLine("Minha altura é de "+altura.ToString("Alto"));
            Console.WriteLine(dataAtual);
int a = Convert.ToInt32(idadeString);
   Console.WriteLine(a);
        }

    }

}