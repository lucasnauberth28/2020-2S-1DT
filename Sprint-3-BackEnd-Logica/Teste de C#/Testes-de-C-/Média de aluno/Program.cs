using System;

namespace Média_de_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            string situação = "";

            Console.WriteLine("Média:  " + media);

            if(media >= 7) {
                situação = "Aprovado";
            }

            else{
                situação = "Reprovado";
            }

            Console.WriteLine(situação);
        }
    }
}
