using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasInterfaces.Models
{
    public class Corrente : Contac
    {
        public override void Creditar(decimal valor){
            saldo+=valor;
        }
    }
}