using System;
using System.Collections.Generic;
using Lista_Objetos.Classes;

namespace Lista_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(1, "Apple Watch", 3522.55f));
            produtos.Add(new Produto(2, "Xiaomi Watch", 1500.55f));
            produtos.Add(new Produto(3, "ASUS Zenfone", 2150.99f));
            produtos.Add(new Produto(4, "Samsung", 2555.80f));
            produtos.Add(new Produto(5, "Motorola Moto G8", 989.99f));

            Produto p1 = new Produto();
            p1.Codigo = 67;
            p1.Nome = "Iphone 12";
            p1.Preco = 8952.56f;

            produtos.Add(p1);

            foreach (Produto elemento in produtos)
            {
                Console.WriteLine(elemento.Nome);
            }

            produtos.RemoveAt(3);
            Console.WriteLine("\nItem removido.\n");
            foreach (Produto elemento in produtos)
            {
                Console.WriteLine(elemento.Nome);
            }

            produtos.RemoveAll(x => x.Codigo == 3);

            Console.WriteLine("\nItem removido.\n");
            foreach (Produto elemento in produtos)
            {
                Console.WriteLine(elemento.Nome);
            }
        }
    }
}