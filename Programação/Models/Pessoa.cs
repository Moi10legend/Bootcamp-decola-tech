using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programacao.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void ToPresent()
        {Console.WriteLine($"Hello, my name is {Name} \n and i'm {Age} years old");
        }
    }
}