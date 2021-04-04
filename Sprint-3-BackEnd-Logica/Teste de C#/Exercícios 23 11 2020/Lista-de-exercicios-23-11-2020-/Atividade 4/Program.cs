using System;

namespace Lista_de_exercicios_23_11_2020_
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior=0, menor, i=0, numero=0, tl=0;

            Console.WriteLine("Olá, digite alguns números e eu irei te dizer qual o maior e menor valor entre eles");
            Console.Write("Deseja escrever quantos números?");
            tl = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o 1º número? ");
            numero = Convert.ToInt32(Console.ReadLine());
            maior = numero;
            menor = numero;
            i=1;

            for(i = 2; i <= tl; i++){
                 Console.Write("Qual o " + i +"º número? ");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero < menor){
                menor = numero;
                }
            if (numero > maior){
                maior = numero;
                }
            }

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
            Console.ReadKey();




             
        }
    }

}

