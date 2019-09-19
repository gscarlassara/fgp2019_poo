using System;
using casas.Modelos;

namespace casas
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bd = new ImoveisDBContext()) {
                var Imovel1 = new Imovel();
                Imovel1.numero = 20;
                Imovel1.endereco = "Rua Primero";
                bd.Add(Imovel1);
                bd.SaveChanges();
                Console.WriteLine("fim");

                Imovel1.endereco = "Novo endereco";
                bd.SaveChanges();

                var i = bd.Imoveis.Find(1);
                Console.WriteLine("codigo do imovel procurado: {}" i.numero)
            
            }
        }
    }
}
