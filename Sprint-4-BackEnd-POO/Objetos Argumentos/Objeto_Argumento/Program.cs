using System;
using Objeto_Argumento.Classes;

namespace Objeto_Argumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Read Dead Redemption", 250.00f);
            Produto p2 = new Produto(2, "GTA 5", 35.90f);
            Produto p3 = new Produto(3, "Detroit Become Human", 120.5f);
            Produto p4 = new Produto(4, "Celeste", 25.90f);

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            carrinho.MostrarProdutos();

        }
    }
}