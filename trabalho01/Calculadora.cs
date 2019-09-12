namespace trabalho01
{
    public class Calculadora
    {
        public float RealizarOperacao(float Numero1, float Numero2, string operacao)
        {
            float resultado = float.NaN; 
            switch (operacao)
            {
                case "a":
                    resultado = Adicionar(Numero1, Numero2);
                    break;
                case "s":
                    resultado = Subtrair(Numero1, Numero2);
                    break;
                default:
                    break;
            }
            return resultado;
        }

        private float Adicionar(float Numero1, float Numero2) {
            return Numero1 + Numero2;
        }

        private float Subtrair(float Numero1, float Numero2) {
            return Numero1 - Numero2;
        }
    }
}