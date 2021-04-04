using System;

namespace Semáfaro
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite a cor do semáfaro: (vermelho, amarelo ou verde) ");
           string start = (Console.ReadLine());

           if(start == "Vermelho"){
               Console.WriteLine("Freie e espere o carro");

           }

           if(start == "amarelo"){
               Console.WriteLine("Desacelere e dirija atentamente");
           }

           if(start == "verde"){
               Console.WriteLine("Prossiga a sua viagem");
           }
        }
    }
}
