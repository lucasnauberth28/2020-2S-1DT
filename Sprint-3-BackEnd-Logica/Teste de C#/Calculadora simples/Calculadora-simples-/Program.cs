using System;

namespace Calculadora_simples_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, qual operação você gostaria de fazer? Soma, Multiplicacao, Subtracao ou Divisao");
            string operacao = Console.ReadLine().ToLower();

            Console.WriteLine("Digite o 1º número: ");
            float num1 = float.Parse( Console.ReadLine());

            Console.WriteLine("Digite o 2º número: ");
            float num2 = float.Parse( Console.ReadLine());

            float resultado=0;

            switch (operacao){

                case "soma":
                resultado = num1 + num2;
                break;

                case "subtracao":
                resultado = num1 - num2;
                break;

                case "multiplicacao":
                resultado = num1 * num2;
                break;

                case "divisao":
                resultado = num1 / num2;
                break;

                default:
                Console.WriteLine("Operação inválida! :( ");
                break;

            }

            Console.WriteLine($"Calculo : {num1} com {num2} = {resultado}");
        }
    }
}
