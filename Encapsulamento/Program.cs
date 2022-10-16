// See https://aka.ms/new-console-template for more information

using Encapsulamento.Models;

ContaCorrente conta1 = new ContaCorrente(123,500);

conta1.ExibirSaldo();
conta1.Sacar(500);
conta1.ExibirSaldo();