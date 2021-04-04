using System;

namespace Exercicio_Login_
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "";
            string pass = "";

            while(true){
                Console.WriteLine("Digite seu email:");
                    email= Console.ReadLine();

                Console.WriteLine("Digite sua senha :");
                pass = Console.ReadLine();

                if(email == pass){
                    Console.WriteLine("Por favor,  não escreva senha e email iguais, para prosseguir, digite ok");
                    Console.ReadLine();

                }else{break;}
            }
            Console.WriteLine("Seja bem vindo! " + email);
        }
    }
}
