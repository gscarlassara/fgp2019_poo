using System;

namespace classe
{
    class Program
    {
        static void Main(string[] args)
        {
           var poo = new Classe();
           poo.codigo = 1;
           poo.disciplina = "POO";
           poo.ano = 2019;
           Console.WriteLine("dis: {0}", poo.disciplina);

           var ed = new Classe(2, "ED", 2019);
           Console.WriteLine("dis: {0} - {1}",
            ed.disciplina, ed.codigo.ToString()
           );

           var jose = new Aluno();
           jose.codigo = 1;
           jose.nome = "Jose 1";
           Console.WriteLine(jose.nome);

           var maria = new Aluno();
           maria.codigo = 2;
           maria.nome = "Maria";

           var fulano = new Aluno();
           fulano.codigo = 3;
           fulano.nome = "Mario";

           poo.AdicionarAlunos(jose);
           poo.AdicionarAlunos(maria);
           poo.AdicionarAlunos(fulano);

           Console.WriteLine("A classe {0} tem {1} alunos.", poo.disciplina, poo.alunos.Count);

           int contador = 1;
           foreach (var aluno in poo.alunos) {
               Console.WriteLine("Aluno {0} - Codigo: {1} - Nome: {2}.", contador, aluno.codigo, aluno.nome);
               contador ++;
           }
         
        }
    }
}
