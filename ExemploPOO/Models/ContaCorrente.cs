using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            numeroConta = NumeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if(saldo <= valor)
            {
               saldo -= valor; 
               Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor de saque excede o total do saldo");
            }
        }
            
        public void ExibirSaldo()
        {
          Console.WriteLine($"O saldo disponível é de: {saldo}");
        }
            
        
    }
}