using System;

namespace Exercício_2_data_de_nasc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Seja bem vindo, você saberá sua idade pelo seu ano de nascimento e sua quantidade de semanas vividas");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            Console.WriteLine("Por favor, digite seu ano de nascimento");
            string ano = Console.ReadLine();
            int nasc = int.Parse(ano);

            int soma = 2020 - nasc;

            Console.WriteLine(soma + " anos, para saber sua idade em semanas digite ok");
            Console.ReadLine();

            int semanas = soma * 52;

            Console.WriteLine(semanas + (" semanas, sua visita acabou aqui, obrigado."));

        }
    }
}
