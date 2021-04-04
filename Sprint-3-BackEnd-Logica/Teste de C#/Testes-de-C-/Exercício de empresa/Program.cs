using System;

namespace Exercício_de_empresa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva seu salário: ");
            double salario = double.Parse(Console.ReadLine());
double reajuste = ((salario * 0.3) + salario);
if (salario >= 500){
                Console.WriteLine("Você não pode receber o aumento");
            }
            else{
                Console.WriteLine("Seu novo salário é de " + reajuste);
            }
        }
    }
}
