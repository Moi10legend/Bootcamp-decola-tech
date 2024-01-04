using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() //O virtual indica que as classes filhas vão poder praticar suas mudanças individuais.
    {
        Console.WriteLine($"Olá eu sou o {Nome} e tenho {Idade} anos");
    }
    }
   
    
}