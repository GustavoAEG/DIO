using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasInterfaces.Models
{
    public abstract class Contac
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo(){

            Console.WriteLine("O seu saldo é:"+saldo);
        }
        
    }
}