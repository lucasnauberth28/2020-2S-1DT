using System;

namespace Exerc_cio_Nota_validada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, por favor digite sua nota:");
            int nota = int.Parse(Console.ReadLine());

                if (nota <=10){
                    Console.WriteLine("nota válida");
                }

                else{
                    Console.WriteLine("Nota inválida");
                }
        }
    }
}
