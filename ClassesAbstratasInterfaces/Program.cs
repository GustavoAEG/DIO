using ClassesAbstratasInterfaces.Models;
using ClassesAbstratasInterfaces.Interfaces;

Corrente c = new Corrente();

c.Creditar(500);
c.ExibirSaldo();

Aluno a = new Aluno("Paulo P.");

a.Nota=10.0;
a.Apresentar();

Professor p = new Professor("Roberto");

p.Salario=5.000;
p.Apresentar();

ICalculadora calc = new Calculadora();

Console.WriteLine(calc.Dividir(5,5));

