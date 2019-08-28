using System;
namespace conta
{
    public class Conta
    {
        public string Numero;
        public double Saldo = 0;
        public string ativa = "S";

        public Conta() {
            //Console.WriteLine("Chamada ao contrutor");
            //Saldo = 1000;
        }
        public Conta(string num, string ativa = "N") {
            Numero = num;
            this.ativa = ativa;
        }

        public void Depositar(double valor) {
            this.Saldo += valor;
            Console.WriteLine("Deposito de R$ {0} efetivado. ", valor);
        }

        public void Depositar(double valor, Conta origem) {
            if (origem.sacar(valor)) {
                this.Depositar(valor);
            } else
                Console.WriteLine("Não há saldo disponivel para transferencia");
        }

        public bool sacar(double valor) {
            if (this.Saldo > valor) {
                this.Saldo -= valor;
                Console.WriteLine("Saque de R$ {0} efetivado. ", valor);
                return true;
            }
            Console.WriteLine("Não há saldo disponível");
            return false;
        }

        public void Imprime() {
            //Console.WriteLine("Conta: " + Numero);
            //Console.WriteLine("saldo: " + Saldo);
            //Console.WriteLine("ativo: " + ativa);
            Console.WriteLine("Conta: {0} - saldo: {1} - ativa: {2}",
            this.Numero,
            this.Saldo,
            this.ativa);
        }

        
    }
}