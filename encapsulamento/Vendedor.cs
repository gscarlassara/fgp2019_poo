using System;
namespace encapsulamento
{
    public class Vendedor
    {
        private double comissao = 0;
        public int Codigo { get; set; }
        public double ValorVenda { get; set; }
        public double Comissao {
            private set {
                comissao = value;
            }

            get {
                comissao = this.CalcularComissao();
                return comissao;
            }
        }

        private double CalcularComissao() {
            this.comissao = this.ValorVenda * 0.10;
            return this.comissao;
        }

        public void Imprimir() {
            Console.WriteLine("Codigo: {0} - Total da venda: {1} - comissão: {2}",
            this.Codigo, this.ValorVenda, this.Comissao);
        }
    }
}