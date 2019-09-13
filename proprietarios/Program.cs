using System;

namespace proprietarios
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Proprietario();
            p.Id = 1;
            p.Nome = "jose";

            var v1 = new Veiculo(1, "vw", "gol");
            var v2 = new Veiculo(2,"fiat","palio");

            p.AdicionarVeiculo(v1);
            p.AdicionarVeiculo(v2);

            p.Imprimir();
            p.ImprimirVeiculos();

        }
    }
}
