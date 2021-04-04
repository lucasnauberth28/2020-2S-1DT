using System;
using EX2.Classes;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
                Console.WriteLine($"Código = {produto1.Codigo}\nNome = {produto1.Nome ?? "Nome não inserido"}\nDescrição = {produto1.Descricao ?? "Descrição não encontrada."}\nEstoque = {produto1.Estoque}");

            Produto produto2 = new Produto(1);
                Console.WriteLine($"Código = {produto2.Codigo}\n Nome = {produto2.Nome ?? "Nome não inserido"}\nDescrição = {produto2.Descricao ?? "Descrição não encontrada"}\nEstoque = {produto2.Estoque}");

            Produto produto3 = new Produto(1, "Produto 10", "Este é o produto 10", 20);
            Console.WriteLine($"Codigo = {produto3.Codigo}\nNome = {produto3.Nome ?? "Nome não inserido."}\nDescrição = {produto3.Descricao ?? "Descrição do produto não encontrada"}\nEstoque = {produto3.Estoque}");            
        }
    }
}

