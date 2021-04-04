using System;

namespace Exercício_data_de_nasc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Seja bem-vindo, para continuar digite uma tecla");
            Console.WriteLine("----------------------------------------------------------");
            Console.ReadLine();

            Console.WriteLine("Por favor, digite sua idade, ela será convertida em meses, dias, horas e minutos");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Sua idade será convertida em meses");
            int meses = idade*12;
            Console.WriteLine (meses + " meses, para prosseguir digite ok ");
            Console.ReadLine();

            Console.WriteLine("Sua idade será convertida em dias");
            int dias = meses*365;
            Console.WriteLine(dias + " dias, para prosseguir digite ok");
            Console.ReadLine();

            Console.WriteLine("Sua idade será convertida em Horas");
            int horas = dias*24;
            Console.WriteLine(horas + " horas, para prosseguir digite ok ");
            Console.ReadLine();

            Console.WriteLine("Sua idade será convertida em minutos");
            int minutos = horas*60;
            Console.WriteLine(minutos + " minutos, sua visita acaba aqui, muito obrigado");


            

        }
    }
}
