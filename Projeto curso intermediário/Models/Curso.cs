using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_curso_intermediário.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos{get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            for(int i = 0; i < Alunos.Count; i++ )
            {

                string texto = $"Nº {i + 1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}