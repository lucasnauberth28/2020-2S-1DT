using System;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {

            int media = 100;
            int faltas = 5;
            int idade = 17;

            if(media >= 50 && faltas <= 10 && idade >= 16){
                Console.WriteLine("Beleza, vamos ver sua patente");
                Console.WriteLine("Qual o seu nível de 0 a 10");
                int resposta = int.Parse(Console.ReadLine());
                if(resposta >=5){
                    Console.WriteLine("Parabéns, você vai conseguir entrar!");
                }
                else{
                    Console.WriteLine("Que pena... você ainda não te nível para entrar no time");
                }
            }

            else{
                Console.WriteLine("NO cry, ggwp");
            }

            
        }
    }
}
