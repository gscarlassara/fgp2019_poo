using System;
using System.Collections.Generic;

namespace classe
{
    public class Classe
    {
        public int codigo;
        public string disciplina;
        public int ano;

        public List<Aluno> alunos = new List<Aluno>();

        public Classe() { }

        public Classe(int codigo, string disciplina, int ano)
        {
           this.codigo = codigo;
           this.disciplina = disciplina;
           this.ano = ano;
        }

        public void AdicionarAlunos(Aluno aluno) {
            alunos.Add(aluno);
        }
    }
}