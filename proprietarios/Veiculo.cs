namespace proprietarios
{
    public class Veiculo
    {   //forma abreviada - metodos get/set publicos
        //referenciando propriedadades privadas
        public int Id { get; set; }  
        public string Modelo { get; set; }
        public string Marca { get; set; }
        //construtor opcional
        public Veiculo(int _id, string _modelo, string _marca)  
        {
            this.Id = _id;
            this.Modelo = _modelo;
            this.Marca = _marca;
        }

    }
}