using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
        // Para participar do time de CS o aluno precisa media maior ou igual a 80 
        //E faltas menores ou igual a 10% dos dias letivos.}


        Console.WriteLine("__________________________________________________________");
        Console.WriteLine("Bem vindo a seletiva para o time de Counter Strike");
        Console.WriteLine("__________________________________________________________");
        Console.WriteLine("Você gostaria de participar? digite sim ou não");
        string resposta = Console.ReadLine();

        if(resposta == "sim"){
            Console.WriteLine("Que legal! vamos ver seu perfil escolar");
            Console.WriteLine("Insira sua média escolar");
            int media = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua quantidade de faltas");
            int faltas = int.Parse(Console.ReadLine());
            if(media>=50 && faltas <=10){
                Console.WriteLine("Parabéns, seja bem-vindo");
            }
            else{
                Console.WriteLine("Ahh, que pena... você precisa melhorar nos estudos para entrar no time");
            }
        }

        else{
            Console.WriteLine("Entendi, boa sorte nos seus projetos");
        }


    }
}
}