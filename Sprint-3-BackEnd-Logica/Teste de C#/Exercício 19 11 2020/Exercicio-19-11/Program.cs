using System;

namespace Exercicio_19_11_
{
    class Program
    {
        static void Main(string[] args)
        {
            string user;
            string acompanhamento;

            string[] produtos = {"Headset", "Mouse", "Teclado", "Mousepad", "Monitor", "Hardware"};
            string[] color = {"Azul", "Vermelho", "Preto", "RGB"};

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Bem vindo a Nauberth´s Store!");
            Console.WriteLine("--------------------------------");  

            Console.WriteLine("Deseja tunar seu computador? Vamos nessa!");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Qual produto você procura? Mouse, Headset, Mousepad, Monitor, Teclado ou Hardware?");

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine(produtos[i]);
            }

            user = Console.ReadLine();

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Que escolha interessante! {user} agora, por favor, escolha a cor do seu produto: Vermelho, Azul, Preto ou RGB");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < color.Length; i++)
            {
                Console.WriteLine(color[i]);
            }

            acompanhamento = Console.ReadLine();

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine($"Aproveite seu {user} com a cor {acompanhamento}");
            Console.WriteLine("----------------------------------------------------------------------------");
        }
    }
}
