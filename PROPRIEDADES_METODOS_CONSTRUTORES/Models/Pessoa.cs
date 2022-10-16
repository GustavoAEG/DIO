using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPRIEDADES_METODOS_CONSTRUTORES.Models
{
    public class Pessoa
    {

        public string _nome;
        public string Nome
        {
            get=> _nome.ToUpper(); //body expression

            set
            {
                if (value == "")
                {

                    throw new ArgumentException("Valor Nome, não pode ser vazio");
                }
                _nome = value;

            }

        } 
        
        private int _idade; //isso e campo
        public int Idade //isso e propriedade
        
        { 
           
            get=> _idade;
            
            set{
                
            if(value<=0){

                throw new ArgumentException("Esta idade não pode ser considerada");
            }
            _idade=value;
            }
            
            }

            public string Sobrenome { get; set; }
            public string NomeCompleto=>$"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar()
                {
            Console.WriteLine($"Nome:{NomeCompleto} Idad,e: {Idade}");
        }// aquié um get... esta apenas pegando o valor
    }


}
