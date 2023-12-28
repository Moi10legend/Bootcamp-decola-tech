using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_curso_intermediário.Models
{
    public class Pessoa
    {

        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

        }
        private string _nome; 
        private int _idade;

        public string Nome {
            
            get => _nome.ToUpper(); //Maneira mais utilizada de chamar o ToUpper (body expressions)
            //  get{
            //     return _nome.ToUpper();//Obtém o valor, que nesse caso vai converter todas as letras do nome para maiúsculo

            //  }
             
             set{

                if(value == ""){

                    throw new ArgumentException("O nome não pode ser vazio"); //Encerra o programa caso o valor dado seja vazio
                }

                _nome = value; //Caso o valor não seja vazio, ele atribuirá o valor dado a variável _nome
             } 
        }
        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); //Utilizando apenas o get

        
        public int Idade { 
            
            get => _idade;
        
            set{
                if(value <= 0){
                    throw new ArgumentException("A idade não pode ser menor ou igual a zero");
                
                }

                _idade = value;
            } 
        }

        public void Apresentar() {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}