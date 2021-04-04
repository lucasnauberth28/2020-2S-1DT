using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            Console.WriteLine("Gostaria de utilizar qual combustivel: [a]=alcool | [g]=gasolina");
             opcao=char.Parse(Console.ReadLine());
            switch(opcao){
                case 'a':
                case 'A':
                  Console.WriteLine("Qual a quantidade de combutivel?");
                  double litros1=uint.Parse(Console.ReadLine());
                  double resultado1= litros1 * 4.90;
                if(litros1 <=20){
                    double resultado2= resultado1-resultado1*0.3;
                     Console.WriteLine($"você terá que pagar {resultado2}");
                }
                else{
                    double resultado2= resultado1-resultado1*0.5;
                     Console.WriteLine($"você terá que pagar {resultado2}");
                }
                break;
                case 'g':
                 case 'G':
               Console.WriteLine("Qual a quantidade de combutivel?");
                  double litros2=uint.Parse(Console.ReadLine());
                  double resultado3= litros2 * 5.30;
                if(litros2 <=20){
                    double resultado2= resultado3-resultado3*0.4;
                     Console.WriteLine($"você terá que pagar {resultado2}");
                }
                else{
                    double resultado2= resultado3-resultado3*0.6;
                     Console.WriteLine($"você terá que pagar {resultado2}");
                }
                break;
            }
        }
    }
}
