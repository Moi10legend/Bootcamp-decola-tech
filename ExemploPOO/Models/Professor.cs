using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public sealed class Professor : Pessoa //Herança, e classe selada
    {
        public Professor(string nome) : base(nome) //Aplicando o construtor por herança
        {
            
        }
        public double Salario { get; set; }

        public override void Apresentar() //Polimorfismo
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e meu salário é de {Salario}");
        }
    }
}