using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta //Classe abstrata
    {
        protected decimal saldo; //O protected protege a propriedade de alterações externas, com exceção das classes filhas

        public abstract void Creditar(decimal valor);
        
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é de {saldo}");
        }
    }
}