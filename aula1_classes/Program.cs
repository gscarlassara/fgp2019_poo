using System;

namespace conta
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            //Console.WriteLine("Hello World!");
            //vou criar classe Conta
            var C1 = new Conta();  //c1 instancia de classe
            C1.Numero = "12";
            //C1.Saldo = 0;
            C1.ativa = "S";
            C1.Depositar(100);
            C1.Imprime();

            var Conta2 = new Conta("X234");
            Conta2.Imprime();

            var Conta3 = new Conta("X3", "Temporario");
            Conta3.Imprime();
            Conta3.Depositar(50);
            Conta3.Depositar(100);
            Conta3.Imprime();
            Conta3.sacar(100);
            Conta3.Depositar(20,C1);
            Conta3.Imprime();
            Conta3.sacar(1000);
            Conta3.Imprime();
            */

            Conta Conta1 = new Conta("10", "S");
            Conta1.Imprime();
            Conta1.Depositar(100);
            Conta1.Imprime();
            Conta1.Depositar(300);
            Conta1.Imprime();
            Conta1.sacar(150);
            Conta1.Imprime();
            //Conta1.Saldo = 100000;
            //Conta1.Imprime(); 



        }
    }
}
