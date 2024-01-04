using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Cauladora : ICalculadora
    {
        public int Dividir(int num1, int num2)
        {
            int divisao = num1 / num2;
            return divisao;
        }

        public int Multiplicar(int num1, int num2)
        {
            int multiplicacao = num1 * num2;
            return multiplicacao;
        }

        public int Somar(int num1, int num2)
        {
            int soma = num1 + num2;
            return soma;
        }

        public int Subtrair(int num1, int num2)
        {
           int subtracao = num1 - num2;
           return subtracao;

        }
    }
}