using System;

namespace atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("qual o ano em que você nasceu :");
            int ano = int.Parse(Console.ReadLine());
                int idade = (2020 - ano);

            if(idade >=18){
                Console.WriteLine("Pode votar!!");
            }
            else {
                Console.WriteLine("você ainda não tem idade para votar !");
            }

        }
    }
}
