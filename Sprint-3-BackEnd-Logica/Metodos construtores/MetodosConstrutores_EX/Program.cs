using System;
using MetodosConstrutores_EX.Classes;

namespace MetodosConstrutores_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            string sobreNome = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, sobreNome);
        }
    }
}
