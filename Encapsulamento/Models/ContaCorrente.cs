using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial){

            NumeroConta = numeroConta;
            saldo = saldoInicial;

        }
        public int NumeroConta { get; set; }      
        private decimal saldo;
        public void Sacar(decimal valor){

if(saldo >= valor){
    
            saldo-=valor;
            Console.WriteLine("saque realizado");

}else{

Console.WriteLine("valor desejado e maior que valor disponivel");
}
        }
        public void ExibirSaldo(){
            Console.WriteLine("Seu saldo disponivel é " + saldo); 
        }
    }
}