using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa //Aplicando o pilar de herança
    {
        public Aluno(string nome) : base(nome) //Aplicando o construtor por herança
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar() //Praticando o polimorfismo
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}");
        }
    }
}