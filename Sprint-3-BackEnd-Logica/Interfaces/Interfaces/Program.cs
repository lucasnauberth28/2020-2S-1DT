using System;
using Interfaces.Classes;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto produto1 = new Produto();
            produto1.Codigo = 123;
            produto1.Nome = "Playstation 5";
            produto1.Preco = 10000;

            Produto produto2 = new Produto();
            produto2.Codigo = 124;
            produto2.Nome = "XBOX Series X";
            produto2.Preco = 5000;

            Produto produto3 = new Produto();
            produto3.Codigo = 125;
            produto3.Nome = "Nintendo Switch";
            produto3.Preco = 3000;

            Console.ResetColor();
            
            carrinho.Cadastrar(produto1);
            carrinho.Cadastrar(produto2);
            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.Blue;
            carrinho.Alterar(produto2.Codigo, produto3);
            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.Red;
            carrinho.Remover(produto1.Codigo);
            carrinho.Listar();
        }
    }
}
