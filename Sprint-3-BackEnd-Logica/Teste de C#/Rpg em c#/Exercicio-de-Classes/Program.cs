using System;

namespace Exercicio_de_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem player1 = new Personagem();
            player1.nome =  "Tsukamoto";
            player1.idade = 32;
            player1.armadura = "Face-Shield";
            player1.ia = "Study and skill";

            Personagem player2 = new Personagem ();
            player2.nome =  "Lucas Nauberth";
            player2.idade = 17;
            player2.armadura = "Óculos";
            player2.ia = "Study";

            Console.WriteLine($" Partida {player1.nome} VS {player2.nome}");
            Console.WriteLine($" Player: {player1.nome} | habilidade: {player1.armadura} || Player: {player2.nome} | habilidade: {player2.armadura}");
            Console.WriteLine($" Player: {player1.nome} | IA: {player1.ia} || Player: {player2.nome} | IA: {player2.ia}");
            
            Console.WriteLine("=========================BATALHA=====================================");

            // Iniciando Luta
            Console.WriteLine("=============================================");
            Console.WriteLine($" {player1.nome} usou {player1.Ataque1()}");
            Console.WriteLine($" {player2.nome} usou {player2.Defesa()}");
            Console.WriteLine("=============================================");
            Console.WriteLine($" {player1.nome} usou {player1.Ataque1()}");
            Console.WriteLine($" {player1.nome} causou {player1.dmgatq1()}");
            Console.WriteLine("=============================================");
            Console.WriteLine($" {player2.nome} usou {player2.Ataque2()}");
            Console.WriteLine($" {player1.nome} {player1.evasive()}");
            Console.WriteLine("=============================================");

        }
    }
}
