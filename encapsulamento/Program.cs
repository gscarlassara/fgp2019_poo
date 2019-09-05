using System;

namespace encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var Conta1 = new Conta("10", "S");
            Conta1.Imprime();
            Conta1.Depositar(200);
            Conta1.Imprime();
            Conta1.sacar(150);
            //Conta1.Saldo = 1000;
            Conta1.Imprime();
            Conta1.Imprime();

            Console.WriteLine("Seu saldo é: " + Conta1.Saldo);

            
            var v = new Vendedor();
            v.Codigo = 10;
            v.ValorVenda = 1000;
            //v.Comissao = 1200;
            v.Imprimir();
            
           
            Conta c1 = new Conta("10","S");
            Conta c2 = new Conta("10","S");
            if (c1.Equals(c2))
               Console.WriteLine("classes iguais");
            else
                Console.WriteLine("classes diferentes");


        }
    }
}
