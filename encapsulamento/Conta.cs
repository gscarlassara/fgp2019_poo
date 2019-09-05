using System;
namespace encapsulamento
{
    public class Conta
    {
        private string numero;
        private double saldo = 0;
        private string ativa = "S";

        public string Numero { get => numero; set => numero = value; }
        public string Ativa { get => ativa; set => ativa = value; }
        public double Saldo { get => saldo; }

        public Conta() {
        }
        
        public Conta(string num, string ativa = "N") {
            this.numero = num;
            this.ativa = ativa;
        }

        public void Depositar(double valor) {
            this.saldo += valor;
            Console.WriteLine("Deposito de R$ {0} efetivado. ", valor);
        }

        public void Depositar(double valor, Conta origem) {
            if (origem.sacar(valor)) {
                this.Depositar(valor);
            } else
                Console.WriteLine("Não há saldo disponivel para transferencia");
        }

        public bool sacar(double valor) {
            if (this.saldo > valor) {
                this.saldo -= valor;
                Console.WriteLine("Saque de R$ {0} efetivado. ", valor);
                return true;
            }
            Console.WriteLine("Não há saldo disponível");
            return false;
        }

        public void Imprime() {
            Console.WriteLine("Conta: {0} - saldo: {1} - ativa: {2}",
            this.numero,
            this.saldo,
            this.ativa);
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Conta c = obj as Conta;
            if ( (this.Numero.Equals(c.Numero)) 
                  && (this.Ativa.Equals(c.Ativa)) 
               )
                return true;
            return false;          
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            return 1;
        }
    }
}