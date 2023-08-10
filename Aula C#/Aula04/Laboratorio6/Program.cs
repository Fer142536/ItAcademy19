namespace Laboratorio6;
using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList contas = new ArrayList();

            ContaPoupanca contaP = new ContaPoupanca(0.10m, new DateTime(1990, 3, 22), "Titular : Fernanda");
            contaP.Depositar(100);
            contas.Add(contaP);

            ContaPoupanca contaP1 = new ContaPoupanca(0.20m, new DateTime(2023, 8, 11), "Titular: Carlos");
            contaP1.Depositar(200);
            contas.Add(contaP1);

        foreach (Conta conta in contas)
            {
                Console.WriteLine($"Titular: {conta.Titular}, Saldo: {conta.Saldo}");
                if (conta is ContaPoupanca cp)
                {
                    Console.WriteLine($"Taxa de Juros: {cp.Juros}, Data de Aniversário: {cp.DataAniversario}");
                }

                Console.WriteLine($"ID: {conta.Id}");
                Console.WriteLine();
            }
        }
    }

