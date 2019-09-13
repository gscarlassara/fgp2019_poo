using System;
using System.Collections.Generic;

namespace proprietarios
{
    public class Proprietario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        private List<Veiculo> _veiculos = new List<Veiculo>();
        public List<Veiculo> Veiculos 
          { get => _veiculos; set => _veiculos = value; }

        public void AdicionarVeiculo(Veiculo V) {
            _veiculos.Add(V);
        }

        public void ImprimirVeiculos() {
            /*
               for (int i = 0; i < _veiculos.Count; i++) {
                  Console.WriteLine(_veiculos[i].Id)
            }
            */
            
            foreach (var v in _veiculos) {
                Console.WriteLine("\t Veiculo {0} - Marca {1} - Modelo {2}",
                v.Id,
                v.Marca,
                v.Modelo
                );
            }  
        }

        public void Imprimir() 
        {
                Console.WriteLine("Proprietario {0} - {1} - Total: {2}",
                this.Id,
                this.Nome,
                this._veiculos.Count.ToString()
                );
        }
        
    }
}