using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] nomes = new string[10];
           string nome2;

           for (var i = 0; i < nomes.Length; i++)
           {
               Console.WriteLine("Digite o " +i+ "° nome");
               nomes[i] = Console.ReadLine();
           }

           foreach(string nome in nomes){
               {
                   
                   Console.WriteLine("Digite o nome que você deseja encontrar, lembrando que o nome precisa estar na lista");
                   nome2 = Console.ReadLine();

                   if (nome2 == nome)
                   {
                       Console.WriteLine("ACHEI! " +nome2);
                       break;
                   }else
                   {
                       Console.WriteLine("NÃO ACHEI.");
                       break;
                   }
               }
           }
           
        }
    }
}
