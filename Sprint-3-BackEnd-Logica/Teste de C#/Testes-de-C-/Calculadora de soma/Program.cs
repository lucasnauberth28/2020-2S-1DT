using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu primeiro número: ");
            string num1_texto = Console.ReadLine();
            int num1 = int.Parse(num1_texto);

            Console.Write("Digite o seu segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            // Console.Write("O resultado é: ");
            // Console.WriteLine(soma);

            Console.WriteLine("O resultado de " + num1 + " + " + num2 + " é: " + soma);

        }
    }
}
