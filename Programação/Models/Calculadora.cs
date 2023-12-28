using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_decola_tech.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x-y}");
        }
        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} * {y} = {x*y}");
    }
        public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x/y}");
}
        public void Potencia(double x, double y){
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ y = {pot} ");
        }
        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno de {angulo} é {Math.Round(seno, 4)}");//arredonda o numero para no max 4 casas decimais
        }
        public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O coseno de {angulo} é {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"A tangente de {angulo} é {Math.Round(tangente, 4)}");
        }
        public void RaizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz de {x} = {raiz}");

        }
    }
}