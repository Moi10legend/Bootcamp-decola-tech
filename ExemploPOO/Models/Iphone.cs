using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }


        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void  InstalarAplicativo(string NomeApp)
        {
            Console.WriteLine($"Instalando o {NomeApp} no Iphone");
        }
    }
}