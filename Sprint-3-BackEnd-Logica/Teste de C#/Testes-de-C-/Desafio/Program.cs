using System;

namespace Projeto_1
{
    class Program
    {
        private const char V = 'b';

        static void Main(string[] args)
        {
            Console.WriteLine("Olá nadador, digite aqui a sua idade em anos e nós iremos dizer em qual categoria você se encaixa.");
            Console.ForegroundColor = ConsoleColor.Blue;
            int idade = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            if(idade>=5 && idade<=7){
                Console.WriteLine("Você é um competidor da categoria Infantil A. Boa Sorte!");
            }
            else if(idade>=8 && idade<=10){
                Console.WriteLine("Você é um competidor da categoria Infantil B. Boa Sorte!");
            }
            else if(idade>=11 && idade<=13){
                Console.WriteLine("Você é um competidor da categoria Juvenil A. Boa Sorte!");
            }
            else if(idade>=14 && idade<=17){
                Console.WriteLine("Você é um competidor da categoria Juveil B. Boa Sorte!");
            }else{
                Console.WriteLine("Você é um competidor da categoria Sênior. Boa Sorte!");
            } 
        }
    }
}