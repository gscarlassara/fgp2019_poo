using System;

namespace trabalho01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finalizarAplicacao = false;

            Console.WriteLine("Calculadora em C#\r");
            Console.WriteLine("------------------------\n");

            while (!finalizarAplicacao)
            {
                string numero1 = "";
                string numero2 = "";
                var resultado = 0.0f;

                Console.Clear();
                Console.WriteLine("Escolha a operação:");
                Console.WriteLine("\ta - Adicionar");
                Console.WriteLine("\ts - Subtrair");
                Console.WriteLine("\tf - Fechar");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                if (opcao.Trim().Equals("f"))
                    finalizarAplicacao = true;
                else
                {
                    try
                    {

                        Console.Write("Numero1: ");
                        numero1 = Console.ReadLine();

                        var Numero1 = 0.0f;
                        while (!float.TryParse(numero1, out Numero1))
                        {
                            Console.Write("Número não é válido. Digite um correto: ");
                            numero1 = Console.ReadLine();
                        }

                        Console.Write("Numero2: ");
                        numero2 = Console.ReadLine();

                        var Numero2 = 0.0f;
                        while (!float.TryParse(numero2, out Numero2))
                        {
                            Console.Write("Número não é válido. Digite um correto: ");
                            numero2 = Console.ReadLine();
                        }

                        var Calculadora = new Calculadora();
                        resultado = Calculadora.RealizarOperacao(Numero1, Numero2, opcao);
                        if (double.IsNaN(resultado))
                        {
                            Console.WriteLine("Erro na operação matemática.\n");
                        }
                        else Console.WriteLine("Resultado: {0}\n", resultado);
                        Console.ReadKey();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ocorreu um erro ao processar: " + e.Message);
                    }

                }
            }
        }
    }
}
