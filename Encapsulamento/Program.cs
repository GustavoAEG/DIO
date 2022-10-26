// See https://aka.ms/new-console-template for more information

using Encapsulamento.Models;

ContaCorrente conta1 = new ContaCorrente(123,500);

conta1.ExibirSaldo();
conta1.Sacar(500);
conta1.ExibirSaldo();

Aluno a1 = new Aluno();

a1.Nome="Paulo";
a1.Idade=15;
a1.Nota=10.0;
a1.Apresentar();

Professor p1 = new Professor();

p1.Nome="Roberto";
p1.Idade=24;
p1.Salario=2.000;
p1.Apresentar();

